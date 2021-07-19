using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SqlProiectStudent.DataAccess.DataObjects;
using static SqlProiectStudent.Functii;

namespace SqlProiectStudent
{

    public partial class FormModificare : Form
    {
        StudentDataBaseDataContext studentDataContext;
        SqlConnection connection;
        int verificareAn;
        int idStudent;

        public FormModificare()
        {
            InitializeComponent();

        }

        public FormModificare(int Mode, string info)
        {
            InitializeComponent();
            studentDataContext = new StudentDataBaseDataContext();
            connection = new SqlConnection("Data Source=DESKTOP-0SKN5UJ\\SQLEXPRESS;Initial Catalog=StudentDataBase;Integrated Security=True");
            if (Mode == 1)
            {
                string[] vectStr = info.Split(',');
                panelStudent.Visible = true;
                string c = "SELECT MaterieTable.IDMaterie, MaterieTable.Materia, NoteTable.NotaLaborator, NoteTable.NotaExamen" +
                        " FROM NoteTable" +
                        " INNER JOIN MaterieTable on MaterieTable.IDMaterie = NoteTable.IDMaterie" +
                        " Where NoteTable.IDStudent = " + vectStr[0];
                AfisareTabelInfo(c, connection, dataGridTable);
                txtBoxNume.Text = vectStr[1];
                txtBoxPrenume.Text = vectStr[2];
                txtBoxCNP.Text = vectStr[3];
                txtBoxAn.Text = vectStr[4];
                verificareAn = Convert.ToInt32(vectStr[4]);
                

                comboBoxMaterii.ValueMember = "Select";
                comboBoxMaterii.DataSource = (from MaterieTable in studentDataContext.MaterieTables
                                              where MaterieTable.An.ToString() == txtBoxAn.Text
                                              select MaterieTable.Materia).ToList();
                var studentID = (from StudentTable in studentDataContext.StudentTables
                                 where txtBoxCNP.Text == StudentTable.CNP
                                 select StudentTable.IDStudent).FirstOrDefault();
                idStudent = studentID;
            }
            if (Mode == 2)
                panelMaterie.Visible = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            int i = 0;
            if (panelStudent.Visible)
            {
                string c = "SELECT MaterieTable.IDMaterie, MaterieTable.Materia, NoteTable.NotaExamen, NoteTable.NotaLaborator" +
                        " FROM NoteTable" +
                        " INNER JOIN StudentTable on StudentTable.IDStudent = NoteTable.IDStudent" +
                        " INNER JOIN MaterieTable on MaterieTable.IDMaterie = NoteTable.IDMaterie";
                command = new SqlCommand("insert into StudentTable values (@idStudent, @nume, @prenume, @cnp, @an)", connection);
                SqlCommand cmdCount = new SqlCommand(c, connection);

                connection.Open();
                int RecordCount = Convert.ToInt32(cmdCount.ExecuteScalar());

                command.Parameters.AddWithValue("@idStudent", ++RecordCount);
                command.Parameters.AddWithValue("@nume", txtBoxNume.Text.Trim());
                command.Parameters.AddWithValue("@prenume", txtBoxPrenume.Text.Trim());
                command.Parameters.AddWithValue("@cnp", txtBoxCNP.Text.Trim());
                command.Parameters.AddWithValue("@an", txtBoxAn.Text.Trim());
                i = command.ExecuteNonQuery();
                ClearTextBox(panelStudent);
                
            }
            else if (panelMaterie.Visible)
            {
                command = new SqlCommand("insert into MaterieTable values (@idMaterie, @nume, @an, @semestru)", connection);
                SqlCommand cmdCount = new SqlCommand("select count(*) from MaterieTable", connection);

                connection.Open();
                int RecordCount = Convert.ToInt32(cmdCount.ExecuteScalar());

                command.Parameters.AddWithValue("@idMaterie", ++RecordCount);
                command.Parameters.AddWithValue("@nume", txtBoxNumeMaterie.Text.Trim());
                command.Parameters.AddWithValue("@an", txtBoxAnMaterie.Text.Trim());
                command.Parameters.AddWithValue("@semestru", txtBoxSemestruMaterie.Text.Trim());
                i = command.ExecuteNonQuery();
                ClearTextBox(panelMaterie);
            }

            connection.Close();
            if (i != 0)
                MessageBox.Show("Data Saved");
            else
                MessageBox.Show("Error");
        }
        public void ClearTextBox(Panel p)
        {
            foreach (Control a in p.Controls)
            {
                if (a is TextBox)
                    a.Text = string.Empty;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearTextBox(panelStudent);
            ClearTextBox(panelMaterie);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            var studentID = (from StudentTable in studentDataContext.StudentTables
                     where txtBoxCNP.Text == StudentTable.CNP
                     select StudentTable.IDStudent).FirstOrDefault();
            var materieID = (from MaterieTable in studentDataContext.MaterieTables
                     where comboBoxMaterii.SelectedItem.ToString() == MaterieTable.Materia
                     select MaterieTable.IDMaterie).FirstOrDefault();
            var noteIntroduse = (from NoteTable in studentDataContext.NoteTables
                                    where materieID == NoteTable.IDMaterie && NoteTable.NotaExamen.HasValue && NoteTable.NotaLaborator.HasValue
                                    select NoteTable).Any();
            if (verificareAn.ToString() != txtBoxAn.Text)
            {
                command = new SqlCommand("update StudentTable set An = @an", connection);
                command.Parameters.AddWithValue("@an", Convert.ToInt32(txtBoxAn.Text));
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                AdaugareMateriiStudent(studentID, connection, studentDataContext);
            }

            int i = 0;

            if (panelStudent.Visible)
            {
                if (string.IsNullOrEmpty(txtBoxNotaExamen.Text) && string.IsNullOrEmpty(txtBoxNotaLaborator.Text))
                    return;
                connection.Open();
                if (noteIntroduse != true)
                {
                    command = new SqlCommand("insert into NoteTable values (@idStudent, @idMaterie, @notaLab, @notaExam)", connection);
                    command.Parameters.AddWithValue("@idStudent", studentID);
                    command.Parameters.AddWithValue("@idMaterie", materieID);
                    command.Parameters.AddWithValue("@notaLab", Convert.ToDouble(txtBoxNotaLaborator.Text.Trim()));
                    command.Parameters.AddWithValue("@notaExam", Convert.ToDouble(txtBoxNotaExamen.Text.Trim()));
                }
                else
                {
                    command = new SqlCommand("update NoteTable set NotaLaborator = @notaLaborator, NotaExamen = @notaExamen where IDStudent = @idStudent and IDMaterie = @idMaterie", connection);
                    command.Parameters.AddWithValue("@idStudent", studentID);
                    command.Parameters.AddWithValue("@idMaterie", materieID);
                    command.Parameters.AddWithValue("@notaLaborator", Convert.ToDouble(txtBoxNotaLaborator.Text.Trim()));
                    command.Parameters.AddWithValue("@notaExamen", Convert.ToDouble(txtBoxNotaExamen.Text.Trim()));
                }
                i = command.ExecuteNonQuery();
                connection.Close();
                if (i != 0)
                    MessageBox.Show("Data Modified");
                else
                    MessageBox.Show("Error");
            }
            txtBoxNotaExamen.Clear();
            txtBoxNotaLaborator.Clear();
        }

        private void dataGridTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var editedCellLaborator = this.dataGridTable.Rows[e.RowIndex].Cells["NotaLaborator"];
            var editedCellExamen = this.dataGridTable.Rows[e.RowIndex].Cells["NotaExamen"];
            var newValueLaborator = editedCellLaborator.Value;
            var newValueExamen = editedCellExamen.Value;

            var studentID = (from StudentTable in studentDataContext.StudentTables
                             where txtBoxCNP.Text == StudentTable.CNP
                             select StudentTable.IDStudent).FirstOrDefault();
            if (newValueLaborator is null)
                newValueLaborator = "NULL";
            if (newValueExamen is null)
                newValueExamen = "NULL";

            SqlCommand command = new SqlCommand("update NoteTable set NotaLaborator = @notaLaborator, NotaExamen = @notaExamen where IDStudent = @idStudent and IDMaterie = @idMaterie", connection);
            command.Parameters.AddWithValue("@idStudent", studentID);
            command.Parameters.AddWithValue("@idMaterie", Convert.ToInt32(this.dataGridTable.Rows[e.RowIndex].Cells[0].Value));
            command.Parameters.AddWithValue("@notaLaborator", newValueLaborator);
            command.Parameters.AddWithValue("@notaExamen", newValueExamen);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void eliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("DELETE FROM NoteTable WHERE IDStudent = " + idStudent, connection))
            {
                command.ExecuteNonQuery();
            }

            using (SqlCommand command = new SqlCommand("DELETE FROM StudentTable WHERE IDStudent = " + idStudent, connection))
            {
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}
