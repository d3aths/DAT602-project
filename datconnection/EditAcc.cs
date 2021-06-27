using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datconnection
{
    public partial class EditAcc : Form
    {
        public Player player;
        dataAccess DataAccess = new dataAccess();

        public EditAcc()
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

        public DialogResult ShowDialog(Player slctdPlayer)
        {
            player = slctdPlayer;
            return ShowDialog();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditAcc_Shown(object sender, EventArgs e)
        {        
            usernameText.Text = player.Username;
            passwordText.Text = player.Password;
            emailText.Text = player.Email;
            statusText.Text = player.Status;
            xText.Text = player.X;
            yText.Text = player.Y;

            if (player.Admin == "N")
            {
                adminCheck.Checked = false;
            }
            else if (player.Admin == "Y")
            {
                adminCheck.Checked = true;
            }

            if (player.Locked == "N")
            {
                lockedCheck.Checked = false;
            }
            else if (player.Locked == "Y")
            {
                lockedCheck.Checked = true;
            }

            //fills textboxes with values
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //passing all this into variables for debugging
            var id = player.ID;
            var newuser = usernameText.Text;
            var newemail = emailText.Text;
            var newpass = passwordText.Text;
            var newstatus = statusText.Text;
            string username = "username";
            string password = "password";
            string email = "email";
            string status = "status";
            string admin = "admin";
            string locked = "locked";
            DataAccess.EditAcc(id, username, newuser);
            player.Username = usernameText.Text;
            DataAccess.EditAcc(id, password, newpass);
            player.Password = passwordText.Text;
            DataAccess.EditAcc(id, email, newemail);
            player.Email = emailText.Text;
            DataAccess.EditAcc(id, status, newstatus);
            player.Status = statusText.Text;
            
            if (adminCheck.Checked == true)
            {
                DataAccess.EditAcc(id, admin, "Y");
                player.Admin = "Y";
            }
            else if (adminCheck.Checked == false)
            {
                DataAccess.EditAcc(id, admin, "N");
                player.Admin = "N";
            }

            if (lockedCheck.Checked == true)
            {
                DataAccess.EditAcc(id, locked, "Y");
                player.Locked = "Y";
            }
            else if (lockedCheck.Checked == false)
            {
                DataAccess.EditAcc(id, locked, "N");
                player.Locked = "N";
            }
            DialogResult = DialogResult.OK;
        }
    }
}
