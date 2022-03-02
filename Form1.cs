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
using static SqlProiectStudent.Functii;


namespace SqlProiectStudent
{
    public partial class Form1 : Form
    {
        // comentariu
        // comentariu 2
        SqlConnection connection;
        string strStudent, strMaterie;
        int ButtonTag;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-0SKN5UJ\\SQLEXPRESS;Initial Catalog=StudentDataBase;Integrated Security=True");
            strStudent = "select IDStudent, Nume, Prenume, CNP, An from StudentTable";
            strMaterie = "select IDMaterie, Materia, An, Semestru from MaterieTable";
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            AfisareTabelInfo(strStudent, connection, dataGridTable);
            ButtonTag = 1;
            buttonStudent.BackColor = Color.Blue;
            buttonMaterie.BackColor = Color.White;
        }

        private void buttonMaterie_Click(object sender, EventArgs e)
        {
            AfisareTabelInfo(strMaterie, connection, dataGridTable);
            ButtonTag = 2;
            buttonStudent.BackColor = Color.White;
            buttonMaterie.BackColor = Color.Blue;
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
                if (ButtonTag == 1)
                    AfisareTabelInfo(strStudent, connection, dataGridTable);
                if (ButtonTag == 2)
                    AfisareTabelInfo(strMaterie, connection, dataGridTable);
            }
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

            using (FormModificare form = new FormModificare(ButtonTag, obj.ToString()))
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
                if (ButtonTag == 1)
                    AfisareTabelInfo(strStudent, connection, dataGridTable);
                if (ButtonTag == 2)
                    AfisareTabelInfo(strMaterie, connection, dataGridTable);
            }
        }
    }
}
