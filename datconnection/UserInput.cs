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
        //assigns the relevant procedure to this page
        dataAccess gDataAccess = new dataAccess();
        dataAccess aDataAccess = new dataAccess();
        dataAccess hDataAccess = new dataAccess();
        public Player player;

        public UserInput()
        {
            InitializeComponent();
        }

        private static string connectionString
        {
            get { return "Server=localhost;Port=3306;Database=game;Uid=root;password=nightfall;"; }

        }

        //the problem with the finduser method is this "conn" is returning null, so will have to reformat this connection here
        private static MySqlConnection conn = null;
        public static MySqlConnection mySqlConnection
        {
            get
            {
                if (conn == null)
                {
                    conn = new MySqlConnection(connectionString);
                }
                return conn;
            }
        }

        public Player FindUser(string user)
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
            matchingUser.Username = dReader["username"].ToString();
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
            //adds the new user with details inputted
            //Player x = FindUser(username);
            gDataAccess.addCheckedUser(username, password);
            //confirms creation with popup
            MessageBox.Show("User created, you may now login.");
            //clears the fields
            usernameInput.Clear();
            passInput.Clear();
            //clears the focus from the button
            ActiveControl = title;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Player x = FindUser(player.Username);
            textBox1.Text = x.Username;
        }
    }
}
