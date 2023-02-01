using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter2._0
{
    public class User
    {
        public User(string login, string password, string email)
        {
            this.Login = login;
            this.Password = password;
            this.Email = email;
        }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
