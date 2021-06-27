using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datconnection
{
    public class Player
    {   //using strings here so we can display the info in things like the playerlist
        //these all must be strings cause pulling the data doesnt like if i try with ints
        private int userid;
        private string username;
        private string password;
        private string email;
        private string admin;
        private string locked;
        private string attempts;
        private string status;
        private string x;
        private string y;

        //a list to store all new player objects that get created as new users
        private static List<Player> _playerList = new List<Player>();
        public static List<Player> PlayerList { get => _playerList; }
        
        //the value to be returned in the playerlist
        public override string ToString()
        {
            return username;
        }

        //initializing fields
        public static Player CurrentPlayer { get; set; }
        public int ID { get { return userid; } set { userid = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Admin { get { return admin; } set { admin = value; } }
        public string Locked { get { return locked; } set { locked = value; } }
        public string Attempts { get { return attempts; } set { attempts = value; } }
        public string Status { get { return status; } set { status = value; } }
        public string X { get { return x; } set { x = value; } }
        public string Y { get { return y; } set { y = value; } }

        public Player()
        {
            ID = userid + 1;
        }
    }
}
