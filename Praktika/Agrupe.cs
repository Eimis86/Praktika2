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
    public partial class Agrupe : Form
    {

        private rep repos = new rep();

        string con = "Data Source=LAPTOP-8L9JC76E\\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True";
        public Agrupe()
        {
            InitializeComponent();
        }

        private void buttongrupe_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {

                    using (SqlConnection sqlCon = new SqlConnection(con))
                    {
                        sqlCon.Open();
                        Grupes pavadinimas = new Grupes();
                        pavadinimas.pavadinimas = textBox1.Text.Trim();
                        //if () {
                        //pavadinimas.pavadinimas = Agrupe.Text.Trim();
                        Grupes register = repos.Insertgrupe(pavadinimas);
                    }
                    Clear();
                }
                else
                {
                    MessageBox.Show("All fields must be written");
                }
                void Clear()
                {
                    textBox1.Text = "";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
