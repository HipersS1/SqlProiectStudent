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

namespace SqlProiectStudent
{
    public partial class Form1 : Form
    {
        int ButtonTag;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            string afisare = "select IDStudent, Nume, Prenume, CNP, An from StudentTable";
            AfisareTabelInfo(afisare);
            ButtonTag = 1;
            buttonStudent.BackColor = Color.Blue;
            buttonMaterie.BackColor = Color.White;
        }

        private void buttonMaterie_Click(object sender, EventArgs e)
        {
            string afisare = "select IDMaterie, Materia, An, Semestru from MaterieTable";
            AfisareTabelInfo(afisare);
            ButtonTag = 2;
            buttonStudent.BackColor = Color.White;
            buttonMaterie.BackColor = Color.Blue;

        }
        public void AfisareTabelInfo(string c)
        {
            dataGridTable.DataSource = null;
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0SKN5UJ\\SQLEXPRESS;Initial Catalog=StudentDataBase;Integrated Security=True"))
            {
                connection.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter(c, connection);
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);

                dataGridTable.DataSource = dataTable;
            }
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            if (ButtonTag != 1 && ButtonTag != 2)
                return;
            using (FormAdaugare form = new FormAdaugare(ButtonTag))
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            if (ButtonTag == 1)
                AfisareTabelInfo("select IDStudent, Nume, Prenume, CNP, An from StudentTable");
            if (ButtonTag == 2)
                AfisareTabelInfo("select IDMaterie, Materia, An, Semestru from MaterieTable");
        }

        private void dataGridTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StringBuilder obj = new StringBuilder();
            if (ButtonTag != 1 && ButtonTag != 2)
                return;
            var row = dataGridTable.CurrentRow;
            foreach (DataGridViewCell cell in row.Cells)
            {
                obj.Append(string.Format("{0},", cell.Value));
            }
            obj.Remove(obj.Length-1, 1);
            //MessageBox.Show(obj.ToString());
            ///
            using (FormModificare form = new FormModificare(ButtonTag, obj.ToString()))
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }
    }
}
