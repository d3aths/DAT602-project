using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datconnection
{
    public class Player
    {
        public static Player CurrentPlayer { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Admin { get; set; }
        public string Locked { get; set; }
        public string Attempts { get; set; }
        public string Status { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
