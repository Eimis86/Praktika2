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
    
    public partial class destomasdalykas : Form
    {
        private rep repos = new rep();

        string con = "Data Source=LAPTOP-8L9JC76E\\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True";

        public destomasdalykas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Astudentoid.Text != "" && Adalykoid.Text != "")
                {

                    using (SqlConnection sqlCon = new SqlConnection(con))
                    {
                        sqlCon.Open();
                        studijuojamasdalykas studdalyk = new studijuojamasdalykas();
                        studdalyk.SDstudentoID = Convert.ToInt32(Astudentoid.Text.Trim());
                        studdalyk.SDdalykoID = Convert.ToInt32(Adalykoid.Text.Trim());
                        //if () {
                        //student.Grupe = Agrupe.Text.Trim();
                        studijuojamasdalykas register = repos.Insertstuddalyk(studdalyk);
                    }

                    Clear();
                }
                else
                {
                    MessageBox.Show("All fields must be written");
                }
                void Clear()
                {
                    Astudentoid.Text = Adalykoid.Text = "";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
