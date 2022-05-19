using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.BL
{
    internal class Crediational
    {
        private string firstName;
        private string lastName;
        private string username;
        private string password;
        private string role;

        public Crediational()
        {
            firstName = "ali";
            lastName = "hassan";
            username = "admin";
            password = "admin";
            role = "Admin";
        }
        public Crediational(string firstName,string lastName,string username, string password,string role)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public bool checkUser(string role,string username,string password,List<Crediational> crediationalsList)
        {
            foreach(Crediational c in crediationalsList)
            {
                if(c.username == username && c.password == password )
                {
                    return true;
                }
            }
            return false;
        }

    }
}
