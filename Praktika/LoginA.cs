using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Praktika.BackEnd.Model;
using Praktika.BackEnd.Server;
using System.Data.SqlClient;

namespace Praktika
{
    public partial class LoginA : Form
    {
        private rep repos;
        //DestytAdmin darepos;
        public LoginA()
        {
            InitializeComponent();
            repos = new rep();
          //  darepos = new rep();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DestytAdmin desad = repos.Logindes(ALU.Text, ALP.Text);
                    if(desad.RoleDes == "D")
                    {
                      DestytMain f = new DestytMain(desad);
                        f.ShowDialog();
                    }
                    else if (desad.RoleDes == "A")
                    {
                        AdminMain f = new AdminMain(desad);
                        f.ShowDialog();
                    }
                    else
                    {
                    // MessageBox.Show("neveikia");
                    }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Studentlogin_Click(object sender, EventArgs e)
        {
            Users student = repos.Loginstud(susername.Text,spassword.Text);
            if (student.Role == "S")
            {
               // string user = ALU.Text;
               // string pass = ALP.Text;
                StudMain f = new StudMain(student);
                f.ShowDialog();
            }
            else
            {

            }
        }
    }
}
