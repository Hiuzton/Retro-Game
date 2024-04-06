using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace finalGame
{
    internal class User
    {
        private static User instance;

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool isLogIn { get; set; }

        private User() { }

        public static User Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new User();
                }
                return instance;
            }
        }
    }
}
