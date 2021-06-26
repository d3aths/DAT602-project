using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace datconnection
{
    public partial class UserInput : Form
    {
        //assigns dataaccess to be able to use the relevant procedures
        dataAccess DataAccess = new dataAccess();

        public Player player;
        private GameWindow gamewindow = new GameWindow();

        public UserInput()
        {
            InitializeComponent();
        }

        private static string connectionString
        {
            get { return "Server=localhost;Port=3306;Database=game;Uid=root;password=nightfall;"; }

        }

        private static MySqlConnection _conn = null;
        public static MySqlConnection conn
        {
            get
            {
                if (_conn == null)
                {
                    _conn = new MySqlConnection(connectionString);
                }
                return _conn;
            }
        }

        public Player FindUser(string username)
        {
            //creates a new player object called matchinguser
            Player matchingUser = new Player();
            //finding a matching coloumn in account where username matches @user
            string sql = "Select * from account where username=@user";
            //new mysql command featuring the statement above and the db connection
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //adds the parameter and its values
            cmd.Parameters.AddWithValue("@user", player.Username);
            //open connection
            conn.Open();
            //creates the datareader and excecutes the command
            MySqlDataReader dReader = cmd.ExecuteReader();
            //if it finds a matching username record then put it into the new player matchinguser
            if (dReader.Read())
            {
                matchingUser.Username = dReader["username"].ToString();
            }
            //closes the connection
            conn.Close();

            return matchingUser;
        }

        public Player PullData(string username)
        {
            //creates a new player object called matchinguser
            Player matchingUser = new Player();
            //finding a matching coloumn in account where username matches @user
            string sql = "Select * from account where username=@user";
            //new mysql command featuring the statement above and the db connection
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //adds the parameter and its values
            cmd.Parameters.AddWithValue("@user", player.Username);
            //open connection
            conn.Open();
            //creates the datareader and excecutes the command
            MySqlDataReader dReader = cmd.ExecuteReader();
            //if it finds a matching username record then pull data into the new player matchinguser
            if (dReader.Read())
            {
                matchingUser.Username = dReader["username"].ToString();
                matchingUser.Password = dReader["password"].ToString();
                matchingUser.Email = dReader["email"].ToString();
                matchingUser.Admin = dReader["admin"].ToString();
                matchingUser.Locked = dReader["locked"].ToString();
                matchingUser.Attempts = dReader["attempts"].ToString();
                matchingUser.Status = dReader["status"].ToString();
                matchingUser.X = (int)dReader["x"]; //doesnt want to pull in these ints for some ass reason
                matchingUser.Y = Convert.ToInt32(dReader["y"]);

            }
            //closes the connection
            conn.Close();

            return matchingUser;
        }

        private void newuserBtn_Click(object sender, EventArgs e)
        {
            //creates a new player object
            var newplayer = new Player();
            player = newplayer;
            //sets input field data to variables
            var username = usernameInput.Text;
            var password = passInput.Text;
            Player.CurrentPlayer = player;
            player.Username = username;
            player.Password = password;
            //checks against username list
            Player x = FindUser(username);
            if (x.Username == player.Username)
            {
                MessageBox.Show("Username already taken, please choose another");
                usernameInput.Clear();
                passInput.Clear();
            }
            else
            {
                //if username is accepted then carry on with adding new user
                DataAccess.addCheckedUser(username, password);
                //confirms creation with popup
                MessageBox.Show("User created, you may now login.");         
                //clears the fields
                usernameInput.Clear();
                passInput.Clear();
                //clears the focus from the button
                ActiveControl = title;
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {   
            //creates a new player object here
            var newplayer = new Player();
            player = newplayer;
            var username = usernameInput.Text;
            var password = passInput.Text;
            player.Username = username;
            //checks for the entered username in the database
            Player x = FindUser(username);
            //if not found, then prompt to re enter details
            if (x.Username != player.Username)
            {
                MessageBox.Show("Username not found, please recheck input.");
            }
            else
            {
                //if username exists then check the correct password
                DataAccess.CheckLogin(username, password);
                textBox2.Text = DataAccess.Output;
                //if password entered correctly then pull data on that user into the current player object here
                if (DataAccess.Output == "Successful LOGIN")
                {
                    Player y = PullData(username);
                    Player.CurrentPlayer = player;
                    newplayer.Username = player.Username;
                    newplayer.Password = player.Password;
                    y.Email = player.Email;
                    y.Admin = player.Admin;
                    y.Locked = player.Locked;
                    y.Attempts = player.Attempts;
                    y.Status = player.Status;
                    y.X = player.X;
                    y.Y = player.Y;
                }
            }
            
            
        }

        private void newuserBtn_MouseEnter(object sender, EventArgs e)
        {
            newuserBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            newuserBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
        }

        private void newuserBtn_MouseLeave(object sender, EventArgs e)
        {
            newuserBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            newuserBtn.ForeColor = System.Drawing.Color.White;
        }

        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            loginBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            loginBtn.ForeColor = System.Drawing.Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gamewindow.Show();
            this.Hide();
        }
    }
}
