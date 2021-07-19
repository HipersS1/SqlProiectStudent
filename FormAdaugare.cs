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
    public partial class FormAdaugare : Form
    {
        StudentDataBaseDataContext studentDataContext;
        SqlConnection connection;

        public FormAdaugare()
        {
            InitializeComponent();
        }

        public FormAdaugare(int Mode)
        {
            InitializeComponent();
            studentDataContext = new StudentDataBaseDataContext();
            connection = new SqlConnection("Data Source=DESKTOP-0SKN5UJ\\SQLEXPRESS;Initial Catalog=StudentDataBase;Integrated Security=True");
            if (Mode == 1)
                panelStudent.Visible = true;
            if (Mode == 2)
                panelMaterie.Visible = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            int i = 0;
            int ValidID = 1;
            var nextValidID = false;
            if (panelStudent.Visible)
            {
                command = new SqlCommand("insert into StudentTable values (@idStudent, @nume, @prenume, @cnp, @an)", connection);

                do
                {
                    nextValidID = (from StudentTable in studentDataContext.StudentTables
                                   where StudentTable.IDStudent == ValidID
                                   select StudentTable).Any();
                    if (nextValidID == true)
                        ValidID++;
                } while (nextValidID == true);
                

                command.Parameters.AddWithValue("@idStudent", ValidID);
                command.Parameters.AddWithValue("@nume", txtBoxNume.Text.Trim());
                command.Parameters.AddWithValue("@prenume", txtBoxPrenume.Text.Trim());
                command.Parameters.AddWithValue("@cnp", txtBoxCNP.Text.Trim());
                command.Parameters.AddWithValue("@an", txtBoxAn.Text.Trim());
                connection.Open();
                i = command.ExecuteNonQuery();
                connection.Close();
                ClearTextBox(panelStudent);
                AdaugareMateriiStudent(ValidID, connection, studentDataContext);
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
                connection.Close();
                ClearTextBox(panelMaterie);
            }

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
    }

}
