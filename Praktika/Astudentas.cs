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
using Praktika.BackEnd.Model;
using Praktika.BackEnd.Server;

namespace Praktika
{
    public partial class Astudentas : Form
    {
        private rep repos = new rep();

        string con = "Data Source=LAPTOP-8L9JC76E\\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True";
        public Astudentas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Afirstname.Text != "" && Asurname.Text != ""  )
                {

                    using (SqlConnection sqlCon = new SqlConnection(con))
                    {
                        sqlCon.Open();
                        Users student = new Users();
                        student.Firstname = Afirstname.Text.Trim();
                        student.Surname = Asurname.Text.Trim();
                        student.Username = student.Firstname;
                        student.Password = student.Surname;
                        student.Role = "S";
                        //if () {
                        //student.Grupe = Agrupe.Text.Trim();
                        Users register = repos.InsertDB(student);
                    }

                    Clear();
                }
                else
                {
                    MessageBox.Show("All fields must be written");
                } 
                void Clear()
                {
                    Afirstname.Text = Asurname.Text = "";
                }
            }

            //MessageBox.Show(user.ToString());


            // MessageBox.Show("You are registered, now");

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Astudentas_Load(object sender, EventArgs e)
        {

        }
    }
}

