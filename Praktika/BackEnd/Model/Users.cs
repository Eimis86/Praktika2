using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika.BackEnd.Model
{
    public class Users
    {
        public int StudentoID { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Grupe { get; set; }
        //public DateTime BDate { get; set; }
    }
}
