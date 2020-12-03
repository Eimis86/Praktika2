using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Praktika.BackEnd.Server;
using Praktika.BackEnd.Model;
using System.Data.SqlClient;

namespace Praktika
{
    

    public partial class StudMain : Form
    {
        rep repos = new rep();
        string con = "Data Source=LAPTOP-8L9JC76E\\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True";
        Users users;
        public StudMain(Users users)
        {
            InitializeComponent();
            this.users = users;
            showstudent();
            Console.WriteLine(users.Username);
        }

       private void showstudent()
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                // Users users = new Users();
                //string username = studID.Text.Trim(); 
               // MessageBox.Show(users.Username);
                string sqlquery = "SELECT Firstname, Surname, pavadinimas, Kontras, Savarankiskas, Egzas FROM Studentas s INNER JOIN Studijuojamas_dalykas sd ON s.Studento_ID = sd.studento_ID INNER JOIN dalykas d ON d.dalyko_ID = sd.dalyko_ID WHERE s.Username = @username AND s.Password = @Password";
                SqlCommand sqlcom = new SqlCommand(sqlquery, sqlCon);
                sqlcom.Parameters.AddWithValue("@password", users.Password);
                sqlcom.Parameters.AddWithValue("@username",users.Username);
                sqlCon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void StudMain_Load(object sender, EventArgs e)
        {

        }

        private void Rodyti_Click(object sender, EventArgs e)
        {
            /*if (studID.Text != "")
            {

                using (SqlConnection sqlCon = new SqlConnection(con))
                {
                    sqlCon.Open();
                    Users student = new Users();
                    student.Username = studID.Text.Trim();
                    Users veikia = StudMain.showstudent(veikia);
                    Clear();
                }
                void Clear()
                {
                    studID.Text = "";
                }
            }
            else
            {
                MessageBox.Show("All fields must be written");
            }*/
        }
    }
}
