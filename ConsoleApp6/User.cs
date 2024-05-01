using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{ public class User
        {

        public string Login { get; set; } = "";
        public string Password { get; set; } = "";
        public string? Email { get; set; }
    public User (string login, string password)
    {
        Login = login;
        Password = password;
        

    } }
}
