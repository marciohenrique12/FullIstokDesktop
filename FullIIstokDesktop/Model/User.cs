using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullIIstokDesktop.Model
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public string nmUser { get; set; }

        public User()
        {

        }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public User(string login, string password, string nmuser)
        {
            Login = login;
            Password = password;
            nmUser = nmuser;
        }
    }
}
