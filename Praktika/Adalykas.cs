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
    public partial class Adalykas : Form
    {
        rep repos = new rep();
        string con = "Data Source=LAPTOP-8L9JC76E\\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True";
        public Adalykas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dalykopavadinimas.Text != "" && destytojoid.Text != "")
                {

                    using (SqlConnection sqlCon = new SqlConnection(con))
                    {
                        sqlCon.Open();
                        dalykas dalykas= new dalykas();
                        dalykas.Dpavadinimas = dalykopavadinimas.Text.Trim();
                        dalykas.Did = Convert.ToInt32(destytojoid.Text.Trim());
                        //if () {
                        dalykas register = repos.Insertdalykas(dalykas);
                    }

                    Clear();
                }
                else
                {
                    MessageBox.Show("All fields must be written");
                }
                void Clear()
                {
                    dalykopavadinimas.Text = destytojoid.Text = "";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
