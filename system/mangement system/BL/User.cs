using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangement_system.BL
{
    class User
    {
        private string name;
        private string password;
        private string role;

        public User(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;


        }
        public User(string name, string password)
        {
            this.name = name;
            this.password = password;



        }
        public User(string name)
        {
            this.name = name;
        }
        public User()
        {

        }
        public string getName()
        {
            return name;
        }
        public string getPassword()
        {
            return password;
        }
        public string getRole()
        {
            return role;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setRole(string role)
        {
            this.role = role;
        }

    }
}
