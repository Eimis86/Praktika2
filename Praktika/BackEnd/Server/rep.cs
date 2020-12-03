using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Praktika.BackEnd.Model;
using System.Windows.Forms;

namespace Praktika.BackEnd.Server
{
    class rep
    {
        string con = "Data Source=LAPTOP-8L9JC76E\\OBJEKTINIS;Initial Catalog=Praktika;Integrated Security=True";
        //studentu login
        public Users Loginstud(string username, string password)
        {
            Users loginstud = new Users();
            try
            {
                SqlConnection sqlcon = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Studentas] WHERE Username=@Username AND Password=@Password", sqlcon);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                sqlcon.Open();
                /*if (sqlcon.State==System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("veikia");
                }
                else
                {
                    MessageBox.Show("nc");
                }*/
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    string Firstname = dr["Firstname"].ToString();
                    string Surname = dr["Surname"].ToString();
                    string Username = dr["Username"].ToString();
                    string Password = dr["Password"].ToString();
                    string Role = dr["Role"].ToString();
                   // string Grupe = dr["Grupes_ID"].ToString();

                    loginstud.Firstname = Firstname;
                    loginstud.Surname = Surname;
                    loginstud.Username = Username;
                    loginstud.Password = Password;
                    loginstud.Role = Role;
                    //MessageBox.Show(Username);
                   // loginstud.Grupe = Grupe;

                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            return loginstud;
        }
        //admin ir destytoooju login
        public DestytAdmin Logindes(string username, string password)
        {
            DestytAdmin logindesad = new DestytAdmin();
            try
            {
                SqlConnection sqlcon = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Destytojas] WHERE Username=@Username AND Password=@Password", sqlcon);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                sqlcon.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    string Firstname = dr["Firstname"].ToString();
                    string Surname = dr["Surname"].ToString();
                    string Username = dr["Username"].ToString();
                    string Password = dr["Password"].ToString();
                    string Role = dr["Role"].ToString();

                    logindesad.FirstnameDes = Firstname;
                    logindesad.SurnameDes = Surname;
                    logindesad.UsernameDes = Username;
                    logindesad.PasswordDes = Password;
                    logindesad.RoleDes = Role;

                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            return logindesad;
        }
        //prideda studenta
        public Users InsertDB (Users student)
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Studentas] WHERE username=@username", sqlCon);
            cmd.Parameters.AddWithValue("@username", student.Username);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                MessageBox.Show("The Username you chosen already exists, please select different username !");
                return null;
            }
            dr.Close();

            SqlCommand sql = new SqlCommand("INSERT INTO [Studentas] (Firstname,Surname,Username,Password,role)" +
                " VALUES (@Firstname,@Surname,@Username,@Password,@Role)", sqlCon);
            sql.Parameters.AddWithValue("@Firstname", student.Firstname);
            sql.Parameters.AddWithValue("@Surname", student.Surname);
            sql.Parameters.AddWithValue("@Username", student.Username);
            sql.Parameters.AddWithValue("@Password", student.Password);
            sql.Parameters.AddWithValue("@Role", student.Role);
           // sql.Parameters.AddWithValue("@Grupes_ID", student.Grupe);

            sql.ExecuteNonQuery();
            sqlCon.Close();
            return student;
        }
        //pridada destytytoja
        public DestytAdmin InsertDBdes(DestytAdmin dest)
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [destytojas] WHERE Username=@Username", sqlCon);
            cmd.Parameters.AddWithValue("@Username", dest.UsernameDes);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                MessageBox.Show("Toks usernamas jau yra");
                return null;
            }
            dr.Close();

            SqlCommand sql = new SqlCommand("INSERT INTO [destytojas] (Firstname,Surname,Username,Password,role)" +
                " VALUES (@Firstname,@Surname,@Username,@Password,@Role)", sqlCon);
            sql.Parameters.AddWithValue("@Firstname", dest.FirstnameDes);
            sql.Parameters.AddWithValue("@Surname", dest.SurnameDes);
            sql.Parameters.AddWithValue("@Username", dest.UsernameDes);
            sql.Parameters.AddWithValue("@Password", dest.PasswordDes);
            sql.Parameters.AddWithValue("@Role", dest.RoleDes);

            sql.ExecuteNonQuery();
            sqlCon.Close();
            return dest;
        }
        //pridet grupe
        public Grupes Insertgrupe(Grupes pavadinimas)
        {
            SqlConnection sqlcon = new SqlConnection(con);
            sqlcon.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Grupe] WHERE pavadinimas=@pavadinimas", sqlcon);
            cmd.Parameters.AddWithValue("@pavadinimas", pavadinimas.pavadinimas);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                MessageBox.Show("Tokia grupe jau yra");
                return null;
            }
            dr.Close();

            SqlCommand sql = new SqlCommand("INSERT INTO [Grupe] (pavadinimas)" +
                " VALUES (@pavadinimas)", sqlcon);
            sql.Parameters.AddWithValue("@pavadinimas", pavadinimas.pavadinimas);

            sql.ExecuteNonQuery();
            sqlcon.Close();
            return pavadinimas;
        }
        //prideda dalyka
        public dalykas Insertdalykas(dalykas dalykas)
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            /*SqlCommand cmd = new SqlCommand("SELECT * FROM [dalykas] WHERE username=@username", sqlCon);
            cmd.Parameters.AddWithValue("@username", student.Username);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                MessageBox.Show("The Username you chosen already exists, please select different username !");
                return null;
            }
            dr.Close();*/

            SqlCommand sql = new SqlCommand("INSERT INTO [dalykas] (pavadinimas,destytojo_ID)" +
                " VALUES (@pavadinimas,@destytojo_ID)", sqlCon);
            sql.Parameters.AddWithValue("@pavadinimas", dalykas.Dpavadinimas);
            sql.Parameters.AddWithValue("@destytojo_ID", dalykas.Did);

            sql.ExecuteNonQuery();
            sqlCon.Close();
            return dalykas;
        }
        //prideda studijuojama grupe 
        public studijuojamasdalykas Insertstuddalyk(studijuojamasdalykas studdalyk)
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            /*SqlCommand cmd = new SqlCommand("SELECT * FROM [dalykas] WHERE username=@username", sqlCon);
            cmd.Parameters.AddWithValue("@username", student.Username);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                MessageBox.Show("The Username you chosen already exists, please select different username !");
                return null;
            }
            dr.Close();*/

            SqlCommand sql = new SqlCommand("INSERT INTO [Studijuojamas_dalykas] (studento_ID,dalyko_ID)" +
                " VALUES (@studento_ID,@dalyko_ID)", sqlCon);
            sql.Parameters.AddWithValue("@studento_ID", studdalyk.SDstudentoID);
            sql.Parameters.AddWithValue("@dalyko_ID", studdalyk.SDdalykoID);

            sql.ExecuteNonQuery();
            sqlCon.Close();
            return studdalyk;
        }
        public Users Inserttogrupe (int Grupes_ID,int Studento_ID)
        {
            Users users = new Users();
            SqlConnection sqlcon = new SqlConnection(con);
            sqlcon.Open();
            //MessageBox.Show(Grupes_ID.ToString());
            //MessageBox.Show(Studento_ID.ToString());

            SqlCommand sql = new SqlCommand( "UPDATE [Studentas] SET Grupes_ID=@Grupes_ID " +
                "WHERE Studento_ID=@Studento_ID",sqlcon);
            sql.Parameters.AddWithValue("@Grupes_ID", Grupes_ID);
            sql.Parameters.AddWithValue("@Studento_ID", Studento_ID);
            sql.ExecuteNonQuery();
            sqlcon.Close();

            return users;
        }
        //ideti kontra
        public studijuojamasdalykas Insertkontras(studijuojamasdalykas ivertinimas)
        {
            studijuojamasdalykas ivertis = new studijuojamasdalykas();
            SqlConnection sqlcon = new SqlConnection(con);
            sqlcon.Open();
            SqlCommand sql = new SqlCommand("UPDATE Studijuojamas_dalykas SET Kontras = @kontras WHERE studento_ID= @studento_ID AND dalyko_ID= @dalyko_ID ", sqlcon);
            sql.Parameters.AddWithValue("@kontras",ivertinimas.SDkontras);
            sql.Parameters.AddWithValue("@studento_ID", ivertinimas.SDstudentoID);
            sql.Parameters.AddWithValue("@dalyko_ID", ivertinimas.SDdalykoID);
            sql.ExecuteNonQuery();
            sqlcon.Close();

            return ivertis;
        }
        //ideti savarankiskas
        public studijuojamasdalykas Insertsavarankiskas(studijuojamasdalykas ivertinimas)
        {
            studijuojamasdalykas ivertis = new studijuojamasdalykas();
            SqlConnection sqlcon = new SqlConnection(con);
            sqlcon.Open();
            SqlCommand sql = new SqlCommand("UPDATE Studijuojamas_dalykas SET Savarankiskas = @savarankiskas WHERE studento_ID= @studento_ID AND dalyko_ID= @dalyko_ID ", sqlcon);
            sql.Parameters.AddWithValue("@savarankiskas", ivertinimas.SDsavarankiskas);
            sql.Parameters.AddWithValue("@studento_ID", ivertinimas.SDstudentoID);
            sql.Parameters.AddWithValue("@dalyko_ID", ivertinimas.SDdalykoID);
            sql.ExecuteNonQuery();
            sqlcon.Close();

            return ivertis;
        }
        //ideti egza
        public studijuojamasdalykas Insertegzas(studijuojamasdalykas ivertinimas)
        {
            studijuojamasdalykas ivertis = new studijuojamasdalykas();
            SqlConnection sqlcon = new SqlConnection(con);
            sqlcon.Open();
            SqlCommand sql = new SqlCommand("UPDATE Studijuojamas_dalykas SET Egzas = @egzas WHERE studento_ID= @studento_ID AND dalyko_ID= @dalyko_ID ", sqlcon);
            sql.Parameters.AddWithValue("@egzas", ivertinimas.SDegzas);
            sql.Parameters.AddWithValue("@studento_ID", ivertinimas.SDstudentoID);
            sql.Parameters.AddWithValue("@dalyko_ID", ivertinimas.SDdalykoID);
            sql.ExecuteNonQuery();
            sqlcon.Close();

            return ivertis;
        }
    }

}
