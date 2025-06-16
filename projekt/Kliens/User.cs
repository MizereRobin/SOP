using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kliens
{
    internal class User
    {
        private string name;
        private string password;
        private string role = "user";
        private bool isAuth;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null || value == "")
                {
                    throw new Exception("Name cannot be empty");
                }
                name = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (value == null || value == "")
                {
                    throw new Exception("Password cannot be empty");
                }
                password = value;
            }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public bool IsAuth { get { return isAuth; } set { isAuth = value; } }

        public User(string name, string pass)
        {
            this.name = name;
            this.password = pass;
            this.role = "user";
            this.isAuth = false;
        }
    }
}
