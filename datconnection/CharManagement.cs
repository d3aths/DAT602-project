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
    public partial class CharManagement : Form
    {
        private EditAcc editpage = new EditAcc();
        private GameWindow opengame = new GameWindow();
        public Player player;
        public CharManagement()
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

        private static List<string>[] PopulateList()
        {
            string query = "SELECT * from account";

            List<string>[] _playerList = new List<string>[1];
            _playerList[0] = new List<string>();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dReader = cmd.ExecuteReader();
            while (dReader.Read())
            {
                _playerList[0].Add(dReader["username"] + "");
            }
            dReader.Close();
            conn.Close();

            //this was supposed to be the datasource for the playerList here but for some reason it doesn't show the data properly
            //instead of a list of usernames it just says (Collection) and i cant figure out how tf to not.
            //_playerList.ForEach(username => Player.PlayerList.Add);

            //var players = from p in _playerList
            //              where p.<string> == Player.CurrentPlayer.Username
            //              select p.ToString();
            //foreach (var player in players)
            //    Player.PlayerList.Add(player);
            
            return _playerList;
        }

        private void UpdateDisplay()
        {
            playerList.DataSource = null;
            playerList.DataSource = Player.PlayerList;
        }
        private void logoutBtn_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Logout", logoutBtn);
            logoutBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
        }

        private void logoutBtn_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(logoutBtn);
            logoutBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
        }

        private void CharManagement_Shown(object sender, EventArgs e)
        {
            playernameLabel.Text = Player.CurrentPlayer.Username;
            UpdateDisplay();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            //clears status to offline
            Player.CurrentPlayer.Status = "Offline";
            //clears current player object
            Player.CurrentPlayer = null;
            //brings back login screen
            this.Owner.Show();
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (editBtn.Checked == true)
            {
                var slctdPlayer = (Player)playerList.SelectedItem;
                player = slctdPlayer;
                editpage.ShowDialog(slctdPlayer);
            }
            else if (playBtn.Checked == true)
            {
                opengame.Show();
                this.Hide();
            }
            else if (deleteBtn.Checked == true)
            {
                var slctdPlayer = (Player)playerList.SelectedItem;
                Player.PlayerList.Remove(slctdPlayer);
            }
            else if (killBtn.Checked == true)
            {
                var slctdPlayer = (Player)playerList.SelectedItem;
                slctdPlayer.Status = "Offline";
            }
        }
    }
}
