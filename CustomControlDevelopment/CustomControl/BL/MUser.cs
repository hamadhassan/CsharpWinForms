using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControl.BL
{
    internal class MUser
    {
        private string username;
        private string password;
        private string role;
        public MUser()
        {
            username = "ali";
            password = "123";
            role = "admin";
        }
        public MUser(string username,string password,string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
