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
    public partial class AdminMain : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-8L9JC76E\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True");
       // Users user;
        public AdminMain(Users users)
        {
            InitializeComponent();
            showStudents();
            showTutor();
            showgrupe();
            showdalykas();
            showdestomadalyka();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Astudentas f = new Astudentas();
            f.ShowDialog();
            showStudents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adestytojas f = new Adestytojas();
            f.ShowDialog();
            showTutor();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'praktikaDataSet3.Studentas' table. You can move, or remove it, as needed.
           // this.studentasTableAdapter2.Fill(this.praktikaDataSet3.Studentas);
            // TODO: This line of code loads data into the 'praktikaDataSet2.Studentas' table. You can move, or remove it, as needed.
           // this.studentasTableAdapter1.Fill(this.praktikaDataSet2.Studentas);
            // TODO: This line of code loads data into the 'praktikaDataSet1.Studentas' table. You can move, or remove it, as needed.
            //this.studentasTableAdapter.Fill(this.praktikaDataSet1.Studentas);
            // TODO: This line of code loads data into the 'praktikaDataSet.Users' table. You can move, or remove it, as needed.
           // this.usersTableAdapter.Fill(this.praktikaDataSet.Users);

        }
        /*private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Studentai", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }*/
        private void showStudents()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-8L9JC76E\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True");
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Studentas]", sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-8L9JC76E\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True");
            SqlCommand cmd;
            int ID = Convert.ToInt32(deleteuser.Text);
            if (ID != 0)
            {
                con.Open();
                cmd = new SqlCommand("Delete Studijuojamas_dalykas where studento_ID=@Studento_ID ",con);
                cmd.Parameters.AddWithValue("@Studento_ID",ID);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("delete Studentas where Studento_ID=@Studento_ID", con);
                
                cmd.Parameters.AddWithValue("@Studento_ID", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sekmingai istrinta!");
                dataGridView1.DataSource = null;
                showStudents();
                showdestomadalyka();
                //DisplayData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void deleteuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showTutor()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-8L9JC76E\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True");
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [destytojas]", sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-8L9JC76E\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True");
            SqlCommand cmd;
            int ID = Convert.ToInt32(deletedestyt.Text);
            if (ID != 0)
            {
                //string dalykasa = null;
                con.Open();
                

                cmd = new SqlCommand("delete destytojas where destytojo_ID=@destytojo_ID", con);
                cmd.Parameters.AddWithValue("@destytojo_ID", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sekmingai istrinta!");
                dataGridView2.DataSource = null;
                showTutor();
          
                //DisplayData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }

        }

        //grupes lentele
        private void showgrupe()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-8L9JC76E\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True");
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Grupe]", sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView3.DataSource = dt;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Agrupe f = new Agrupe();
            f.ShowDialog();
            showgrupe();
        }
        //trina grupes
        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-8L9JC76E\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True");
            SqlCommand cmd;
            int ID = Convert.ToInt32(deletegrupe.Text);
            if (ID != 0)
            {
                con.Open();
                cmd = new SqlCommand("Update Studentas set Grupes_ID=null where Grupes_ID = @Grupes_ID", con);
                cmd.Parameters.AddWithValue("@Grupes_ID", ID);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("delete grupe where Grupes_ID=@Grupes_ID ", con);
                cmd.Parameters.AddWithValue("@Grupes_ID", ID);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Sekmingai istrinta!");
                dataGridView3.DataSource = null;
                showgrupe();
                showStudents();
                //DisplayData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }

        }

        //dalyko lentele
        private void showdalykas()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-8L9JC76E\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True");
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [dalykas]", sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView4.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Adalykas f = new Adalykas();
            f.ShowDialog();
            showdalykas();
        }
        //trina dalykus
        private void button7_Click(object sender, EventArgs e)
        {

                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-8L9JC76E\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True");
                SqlCommand cmd;
                int ID = Convert.ToInt32(deletedalykas.Text);
                if (ID != 0)
                {
                    con.Open();
                    cmd = new SqlCommand("delete Studijuojamas_dalykas where dalyko_ID=@dalyko_ID ", con);
                    cmd.Parameters.AddWithValue("@dalyko_ID", ID);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Update Studijuojamas_dalykas set studento_ID=null Where dalyko_ID=@dalyko_ID", con);
                    cmd.Parameters.AddWithValue("@dalyko_ID", ID);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Update dalykas set destytojo_ID=null Where dalyko_ID=@dalyko_ID",con);
                    cmd.Parameters.AddWithValue("@dalyko_ID", ID);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("delete dalykas where dalyko_ID=@dalyko_ID ", con);
                    cmd.Parameters.AddWithValue("@dalyko_ID", ID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Sekmingai istrinta!");
                    dataGridView4.DataSource = null;
                    showdalykas();
                    showdestomadalyka();
                    //DisplayData();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Delete");
                }

        }

        //destomas dalykas lentele
        private void showdestomadalyka()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-8L9JC76E\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True");
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Studijuojamas_dalykas]", sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView5.DataSource = dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            destomasdalykas f = new destomasdalykas();
            f.ShowDialog();
            showdestomadalyka();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-8L9JC76E\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True");
            SqlCommand cmd;
            int ID = Convert.ToInt32(deletedestomadalyka.Text);
            if (ID != 0)
            {

                cmd = new SqlCommand("delete Studijuojamas_dalykas where studijuojamo_dalyko=@studijuojamo_dalyko", con);
                con.Open();
                cmd.Parameters.AddWithValue("@studijuojamo_dalyko", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sekmingai istrinta!");
                dataGridView5.DataSource = null;
                showdestomadalyka();
                //DisplayData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Astudgupe f = new Astudgupe();
            f.ShowDialog();
            showStudents();
        }
        //trina viska su des
        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-8L9JC76E\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True");
            SqlCommand cmd;
            int ID = Convert.ToInt32(deletedestyt.Text);
            if (ID != 0)
            {
                string dalykasa = null;
                con.Open();
                cmd = new SqlCommand("Select dalyko_ID from dalykas where destytojo_ID=@destytojo_ID", con);
                cmd.Parameters.AddWithValue("@destytojo_ID", ID);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    dalykasa = da.GetValue(0).ToString();
                    //return dalykasa;
                    //MessageBox.Show(dalykasa);
                }
                da.Close();
                //string a = dalykasa;
                // MessageBox.Show(dalykasa);
                Convert.ToInt32(dalykasa);
                cmd = new SqlCommand("Update Studijuojamas_dalykas set studento_ID=null Where dalyko_ID=@dalyko_ID", con);
                cmd.Parameters.AddWithValue("@dalyko_ID", dalykasa);
                cmd.ExecuteNonQuery();
                /*cmd = new SqlCommand("Update Studijuojamas_dalykas set dalyko_ID=null Where dalyko_ID=@dalyko_ID", con);
                cmd.Parameters.AddWithValue("@dalyko_ID", dalykasa);
                cmd.ExecuteNonQuery();*/
                cmd = new SqlCommand("delete Studijuojamas_dalykas where dalyko_ID=@dalyko_ID ", con);
                cmd.Parameters.AddWithValue("@dalyko_ID", dalykasa);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Update dalykas set destytojo_ID=null Where destytojo_ID=@destytojo_ID", con);
                cmd.Parameters.AddWithValue("@destytojo_ID", ID);
                cmd.ExecuteNonQuery();
                //MessageBox.Show(dalykasa);
                cmd = new SqlCommand("delete dalykas where dalyko_ID=@dalyko_ID  ", con);
                cmd.Parameters.AddWithValue("@dalyko_ID", dalykasa);
                cmd.ExecuteNonQuery();
                /*cmd = new SqlCommand("Update dalykas set destytojo_ID=null Where destytojo_ID=@destytojo_ID", con);
                cmd.Parameters.AddWithValue("@destytojo_ID", ID);
                cmd.ExecuteNonQuery();*/

                cmd = new SqlCommand("delete destytojas where destytojo_ID=@destytojo_ID", con);
                cmd.Parameters.AddWithValue("@destytojo_ID", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sekmingai istrinta!");
                dataGridView2.DataSource = null;
                showTutor();
                showdalykas();
                showdestomadalyka();
                //DisplayData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
        //trina destytoja ir dalyka
        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-8L9JC76E\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True");
            SqlCommand cmd;
            int ID = Convert.ToInt32(deletedestyt.Text);
            if (ID != 0)
            {
                string dalykasa = null;
                con.Open();
                cmd = new SqlCommand("Select dalyko_ID from dalykas where destytojo_ID=@destytojo_ID", con);
                cmd.Parameters.AddWithValue("@destytojo_ID", ID);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    dalykasa = da.GetValue(0).ToString();
                    //return dalykasa;
                    //MessageBox.Show(dalykasa);
                }
                da.Close();
                //string a = dalykasa;
                // MessageBox.Show(dalykasa);
                Convert.ToInt32(dalykasa);
                /*cmd = new SqlCommand("Update Studijuojamas_dalykas set studento_ID=null Where dalyko_ID=@dalyko_ID", con);
                cmd.Parameters.AddWithValue("@dalyko_ID", dalykasa);
                cmd.ExecuteNonQuery();*/
                /*cmd = new SqlCommand("Update Studijuojamas_dalykas set dalyko_ID=null Where dalyko_ID=@dalyko_ID", con);
                cmd.Parameters.AddWithValue("@dalyko_ID", dalykasa);
                cmd.ExecuteNonQuery();*/
                /*cmd = new SqlCommand("delete Studijuojamas_dalykas where dalyko_ID=@dalyko_ID ", con);
                cmd.Parameters.AddWithValue("@dalyko_ID", dalykasa);
                cmd.ExecuteNonQuery();*/
                cmd = new SqlCommand("Update dalykas set destytojo_ID=null Where destytojo_ID=@destytojo_ID", con);
                cmd.Parameters.AddWithValue("@destytojo_ID", ID);
                cmd.ExecuteNonQuery();
                //MessageBox.Show(dalykasa);
                cmd = new SqlCommand("delete dalykas where dalyko_ID=@dalyko_ID  ", con);
                cmd.Parameters.AddWithValue("@dalyko_ID", dalykasa);
                cmd.ExecuteNonQuery();
                /*cmd = new SqlCommand("Update dalykas set destytojo_ID=null Where destytojo_ID=@destytojo_ID", con);
                cmd.Parameters.AddWithValue("@destytojo_ID", ID);
                cmd.ExecuteNonQuery();*/

                cmd = new SqlCommand("delete destytojas where destytojo_ID=@destytojo_ID", con);
                cmd.Parameters.AddWithValue("@destytojo_ID", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sekmingai istrinta!");
                dataGridView2.DataSource = null;
                showTutor();
                showdalykas();
                showdestomadalyka();
                //DisplayData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
}
