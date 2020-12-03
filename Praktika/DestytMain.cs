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
    public partial class DestytMain : Form
    {
        rep repos = new rep();
        string con = "Data Source=LAPTOP-8L9JC76E\\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True";
        DestytAdmin desad;

        public DestytMain(DestytAdmin desad)
        {
            InitializeComponent();
            this.desad = desad;
            showstudijuojamasdalykas();
            //Console.WriteLine(desad.UsernameDes);
        }

       /* public DestytMain(DestytAdmin desad)
        {
            this.desad = desad;
        }*/

        private void showstudijuojamasdalykas()
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);

                // Users users = new Users();
                //string username = studID.Text.Trim(); 
                //MessageBox.Show(desad.PasswordDes);
                
                string sqlquery = "SELECT s.Firstname, s.Surname, d.pavadinimas, ds.Firstname, ds.Surname, sd.studento_ID, sd.dalyko_ID,sd.Kontras, sd.Savarankiskas, sd.Egzas FROM Studentas s INNER JOIN Studijuojamas_dalykas sd ON s.Studento_ID = sd.studento_ID INNER JOIN dalykas d ON d.dalyko_ID = sd.dalyko_ID INNER JOIN destytojas ds ON d.destytojo_ID = ds.destytojo_ID WHERE ds.Username = @Username AND ds.Password = @Password";
                SqlCommand sqlcom = new SqlCommand(sqlquery, sqlCon);
                sqlcom.Parameters.AddWithValue("@Username", desad.UsernameDes);
                sqlcom.Parameters.AddWithValue("@Password", desad.PasswordDes);
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
        //Iveda kontra
            private void button1_Click(object sender, EventArgs e)
            {

                try
                {
                    if (studID.Text != "" && kontras.Text != "" && dalykID.Text != "" )
                    {
                        if (Convert.ToInt32(kontras.Text) >= 1 && Convert.ToInt32(kontras.Text) <= 10)
                        {
                            using (SqlConnection sqlCon = new SqlConnection(con))
                            {
                            sqlCon.Open();
                            studijuojamasdalykas ivertinimas = new studijuojamasdalykas();
                            ivertinimas.SDkontras = Convert.ToInt32(kontras.Text);
                            ivertinimas.SDstudentoID = Convert.ToInt32(studID.Text);
                            ivertinimas.SDdalykoID = Convert.ToInt32(dalykID.Text);
                            //if () {
                            //pavadinimas.pavadinimas = Agrupe.Text.Trim();
                            studijuojamasdalykas register = repos.Insertkontras(ivertinimas);
                            }
                        Clear();
                        }
                        else
                        {
                            MessageBox.Show("netinka pazymys");
                        }
                    }
                    else
                    {
                        MessageBox.Show("iveskite id");
                    }
                    void Clear()
                    {
                        studID.Text = kontras.Text= dalykID.Text = "";
                    }
                    showstudijuojamasdalykas();
            }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

            }
        //iveda savarankiska
        private void ivestisavarankiska_Click(object sender, EventArgs e)
        {
            try
            {
                if (SstudID.Text != "" && savarankiskas.Text != "" && SdalykID.Text != "")
                {
                    if (Convert.ToInt32(savarankiskas.Text) >= 0 && Convert.ToInt32(savarankiskas.Text) <= 10)
                    {            
                    using (SqlConnection sqlCon = new SqlConnection(con))
                    {
                        sqlCon.Open();
                        studijuojamasdalykas ivertinimas = new studijuojamasdalykas();
                        ivertinimas.SDsavarankiskas = Convert.ToInt32(savarankiskas.Text);
                        ivertinimas.SDstudentoID = Convert.ToInt32(SstudID.Text);
                        ivertinimas.SDdalykoID = Convert.ToInt32(SdalykID.Text);
                        studijuojamasdalykas register = repos.Insertsavarankiskas(ivertinimas);
                    }
                    Clear();
                    }
                    else
                    {
                        MessageBox.Show("netinka pazymys");
                    }
                }
                else
                {
                    MessageBox.Show("iveskite id");
                }
                void Clear()
                {
                    SstudID.Text = savarankiskas.Text = SdalykID.Text = "";
                }
                showstudijuojamasdalykas();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        //iveda egza
        private void ivestiegza_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstudID.Text != "" && egzas.Text != "" && EdalykID.Text != "")
                {
                    if (Convert.ToInt32(egzas.Text) >= 0 && Convert.ToInt32(egzas.Text) <= 10) {
                        using (SqlConnection sqlCon = new SqlConnection(con))
                        {
                            sqlCon.Open();
                            studijuojamasdalykas ivertinimas = new studijuojamasdalykas();
                            ivertinimas.SDegzas = Convert.ToInt32(egzas.Text);
                            ivertinimas.SDstudentoID = Convert.ToInt32(EstudID.Text);
                            ivertinimas.SDdalykoID = Convert.ToInt32(EdalykID.Text);
                            studijuojamasdalykas register = repos.Insertegzas(ivertinimas);
                        }
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("netinka pazymys");
                    }
                }
                else
                {
                    MessageBox.Show("iveskite id");
                }
                void Clear()
                {
                    EstudID.Text = egzas.Text = EdalykID.Text = "";
                }
                showstudijuojamasdalykas();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void DestytMain_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
