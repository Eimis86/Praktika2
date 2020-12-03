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
    public partial class Astudgupe : Form
    {

        string con = "Data Source=LAPTOP-8L9JC76E\\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True";

        rep repos = new rep();
        public Astudgupe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Astud.Text != "" && Agrupe.Text != "")
                {

                    using (SqlConnection sqlCon = new SqlConnection(con))
                    {
                        sqlCon.Open();
                        Users users = new Users();
                        users.StudentoID = Convert.ToInt32(Astud.Text.Trim());

                        users.Grupe = Convert.ToInt32(Agrupe.Text.Trim());
                       
                        //if () {
                        //pavadinimas.pavadinimas = Agrupe.Text.Trim();
                        Users register = repos.Inserttogrupe(users.Grupe, users.StudentoID);
                    }
                    Clear();
                }
                else
                {
                    MessageBox.Show("All fields must be written");
                }
                void Clear()
                {
                    Astud.Text = Agrupe.Text = "";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
