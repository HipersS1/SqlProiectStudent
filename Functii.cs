using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SqlProiectStudent.DataAccess.DataObjects;
using System.Windows.Forms;

namespace SqlProiectStudent
{
    class Functii
    {
        public static void AdaugareMateriiStudent(int idStudent,SqlConnection connection, StudentDataBaseDataContext studentDataContext)
        {
            SqlCommand command;
            connection.Open();
            var idMaterii = (from MateriiTable in studentDataContext.MaterieTables
                             where MateriiTable.An == (from StudentTable in studentDataContext.StudentTables
                                                       where idStudent == StudentTable.IDStudent
                                                       select StudentTable.An).FirstOrDefault()
                             select MateriiTable.IDMaterie).ToList<int>();

            foreach (var mat in idMaterii)
            {
                command = new SqlCommand("insert into NoteTable values (@idStudent, @idMaterie, NULL, NULL)", connection);
                command.Parameters.AddWithValue("@idStudent", idStudent);
                command.Parameters.AddWithValue("@idMaterie", mat);
                int i = command.ExecuteNonQuery();
                if (i == 0)
                    MessageBox.Show("Eroare la introducerea materiilor");
            }
            connection.Close();
        }
    }
}
