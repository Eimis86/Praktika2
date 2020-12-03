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
    public partial class Adestytojas : Form
    {

        private rep repos = new rep();

        string con = "Data Source=LAPTOP-8L9JC76E\\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True";
        public Adestytojas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dfirstname.Text != "" && Dsurname.Text != "" )
                {

                    using (SqlConnection sqlCon = new SqlConnection(con))
                    {
                        sqlCon.Open();
                        DestytAdmin des = new DestytAdmin();
                        des.FirstnameDes = Dfirstname.Text.Trim();
                        des.SurnameDes = Dsurname.Text.Trim();
                        des.UsernameDes = des.FirstnameDes;
                        des.PasswordDes = des.SurnameDes; 
                        des.RoleDes = "D";
                        DestytAdmin register = repos.InsertDBdes(des);
                        Clear();
                    }
                    void Clear()
                    {
                        Dfirstname.Text = Dsurname.Text =  "";
                    }

                }
                else
                {
                    MessageBox.Show("All fields must be written");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
