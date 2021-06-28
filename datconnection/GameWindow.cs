using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datconnection
{
    public partial class GameWindow : Form
    {
        dataAccess DataAccess = new dataAccess();

        private PictureBox currentTile;
        private PictureBox nTile;
        private PictureBox sTile;
        private PictureBox eTile;
        private PictureBox wTile;
        int coordx;
        int coordy;
        private PictureBox lastTile;
        string status = "status";

        public GameWindow()
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
        public Player GetStats(int userid)
        {
            //creates a new player object called matchinguser
            Player matchingUser = new Player();
            //finding a matching coloumn in account where username matches @user
            string sql = "Select * from stats where userid=@userid";
            //new mysql command featuring the statement above and the db connection
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //adds the parameter and its values
            cmd.Parameters.AddWithValue("@userid", Player.CurrentPlayer.ID);
            //open connection
            conn.Open();
            //creates the datareader and excecutes the command
            MySqlDataReader dReader = cmd.ExecuteReader();
            //if it finds a matching username record then put it into the new player matchinguser
            if (dReader.Read())
            {
                matchingUser.ID = Int32.Parse(dReader["userid"].ToString());
                matchingUser.Str = Int32.Parse(dReader["str"].ToString());
                matchingUser.Hp = Int32.Parse(dReader["hp"].ToString());
                matchingUser.Stam = Int32.Parse(dReader["stam"].ToString());
            }
            //closes the connection
            conn.Close();

            return matchingUser;
        }

        void checkPos()
        {
            //godddd im going to have to do this for every single tile
            if (currentTile == box11)
            {
                coordx = 1;
                coordy = 1;
                nTile = null;
                sTile = box12;
                eTile = box21;
                wTile = null;
            }
            else if (currentTile == box12)
            {
                coordx = 1;
                coordy = 2;
                nTile = box11;
                sTile = box13;
                eTile = box22;
                wTile = null;
            }
            else if (currentTile == box13)
            {
                coordx = 1;
                coordy = 3;
                nTile = box12;
                sTile = box14;
                eTile = box23;
                wTile = null;
            }
            else if (currentTile == box14)
            {
                coordx = 1;
                coordy = 4;
                nTile = box13;
                sTile = null;
                eTile = box24;
                wTile = null;
            }
            else if (currentTile == box21)
            {
                coordx = 2;
                coordy = 1;
                nTile = null;
                sTile = box22;
                eTile = box31;
                wTile = box11;
            }
            else if (currentTile == box22)
            {
                coordx = 2;
                coordy = 2;
                nTile = box21;
                sTile = box23;
                eTile = box32;
                wTile = box12;
            }
            else if (currentTile == box23)
            {
                coordx = 2;
                coordy = 3;
                nTile = box22;
                sTile = box24;
                eTile = box33;
                wTile = box13;
            }
            else if (currentTile == box24)
            {
                coordx = 2;
                coordy = 4;
                nTile = box23;
                sTile = null;
                eTile = box34;
                wTile = box14;
            }
            else if (currentTile == box31)
            {
                coordx = 3;
                coordy = 1;
                nTile = null;
                sTile = box32;
                eTile = box41;
                wTile = box21;
            }
            else if (currentTile == box32)
            {
                coordx = 3;
                coordy = 2;
                nTile = box31;
                sTile = box33;
                eTile = box42;
                wTile = box22;
            }
            else if (currentTile == box33)
            {
                coordx = 3;
                coordy = 3;
                nTile = box32;
                sTile = box34;
                eTile = box43;
                wTile = box23;
            }
            else if (currentTile == box34)
            {
                coordx = 3;
                coordy = 4;
                nTile = box33;
                sTile = null;
                eTile = box44;
                wTile = box24;
            }
            else if (currentTile == box41)
            {
                coordx = 4;
                coordy = 1;
                nTile = null;
                sTile = box42;
                eTile = box51;
                wTile = box31;
            }
            else if (currentTile == box42)
            {
                coordx = 4;
                coordy = 2;
                nTile = box41;
                sTile = box43;
                eTile = box52;
                wTile = box32;
            }
            else if (currentTile == box43)
            {
                coordx = 4;
                coordy = 3;
                nTile = box42;
                sTile = box44;
                eTile = box53;
                wTile = box33;
            }
            else if (currentTile == box44)
            {
                coordx = 4;
                coordy = 4;
                nTile = box43;
                sTile = null;
                eTile = box54;
                wTile = box34;
            }
            else if (currentTile == box51)
            {
                coordx = 5;
                coordy = 1;
                nTile = null;
                sTile = box52;
                eTile = box61;
                wTile = box41;
            }
            else if (currentTile == box52)
            {
                coordx = 5;
                coordy = 2;
                nTile = box51;
                sTile = box53;
                eTile = box62;
                wTile = box42;
            }
            else if (currentTile == box53)
            {
                coordx = 5;
                coordy = 3;
                nTile = box52;
                sTile = box54;
                eTile = box63;
                wTile = box43;
            }

            else if (currentTile == box54)
            {
                coordx = 5;
                coordy = 4;
                nTile = box53;
                sTile = null;
                eTile = box64;
                wTile = box44;
            }
            else if (currentTile == box61)
            {
                coordx = 6;
                coordy = 1;
                nTile = null;
                sTile = box62;
                eTile = null;
                wTile = box51;
            }
            else if (currentTile == box62)
            {
                coordx = 6;
                coordy = 2;
                nTile = box61;
                sTile = box63;
                eTile = null;
                wTile = box52;
            }
            else if (currentTile == box63)
            {
                coordx = 6;
                coordy = 3;
                nTile = box62;
                sTile = box64;
                eTile = null;
                wTile = box53;
            }
            else if (currentTile == box64)
            {
                coordx = 6;
                coordy = 4;
                nTile = box63;
                sTile = null;
                eTile = null;
                wTile = box54;
            }
        }

        private void southBtn_Click(object sender, EventArgs e)
        {
            //clears current tiles bg image
            currentTile.BackgroundImage = null;
            //check position
            checkPos();
            //puts bg image on new current
            sTile.BackgroundImage = global::datconnection.Properties.Resources.playerpic;
            //assign south tile to current
            currentTile = sTile;
            //outputs to chatbox
            chatBox.Text = "Location: " + currentTile.Name;
            //checks once more for updated coords for db writing
            checkPos();
            //calls move to write coords in db
            DataAccess.Move(Player.CurrentPlayer.ID, coordx, coordy);
            //adds a new last known tile after the db write so it can load next time
            lastTile = currentTile;
            Player.CurrentPlayer.LastLoc = lastTile.Name;
        }

        private void eastBtn_Click(object sender, EventArgs e)
        {
            //clears current tiles bg image
            currentTile.BackgroundImage = null;
            //check position
            checkPos();
            //puts bg image on new current
            eTile.BackgroundImage = global::datconnection.Properties.Resources.playerpic;
            //assign east tile to current
            currentTile = eTile;
            //outputs to chatbox
            chatBox.Text = "Location: " + currentTile.Name;
            //checks once more for updated coords for db writing
            checkPos();
            //calls move to write coords in db
            DataAccess.Move(Player.CurrentPlayer.ID, coordx, coordy);
            //adds a new last known tile after the db write so it can load next time
            lastTile = currentTile;
            Player.CurrentPlayer.LastLoc = lastTile.Name;
        }

        private void westBtn_Click(object sender, EventArgs e)
        {
            //clears current tiles bg image
            currentTile.BackgroundImage = null;
            //check position
            checkPos();
            //puts bg image on new current
            wTile.BackgroundImage = global::datconnection.Properties.Resources.playerpic;
            //assign west tile to current
            currentTile = wTile;
            //outputs to chatbox
            chatBox.Text = "Location: " + currentTile.Name;
            //checks once more for updated coords for db writing
            checkPos();
            //calls move to write coords in db
            DataAccess.Move(Player.CurrentPlayer.ID, coordx, coordy);
            //adds a new last known tile after the db write so it can load next time
            lastTile = currentTile;
            Player.CurrentPlayer.LastLoc = lastTile.Name;
        }

        private void northBtn_Click(object sender, EventArgs e)
        {
            //clears current tiles bg image
            currentTile.BackgroundImage = null;
            //check position
            checkPos();
            //puts bg image on new current
            nTile.BackgroundImage = global::datconnection.Properties.Resources.playerpic;
            //assign north tile to current
            currentTile = nTile;
            //outputs to chatbox
            chatBox.Text = "Location: " + currentTile.Name;
            //checks once more for updated coords for db writing
            checkPos();
            //calls move to write coords in db
            DataAccess.Move(Player.CurrentPlayer.ID, coordx, coordy);
            //adds a new last known tile after the db write so it can load next time
            lastTile = currentTile;
            Player.CurrentPlayer.LastLoc = lastTile.Name;
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            userLabel.Text = Player.CurrentPlayer.Username;
            //checks if the user has been moving here before ie they have a stored last tile
            if (Player.CurrentPlayer.LastLoc == null)
            {
                currentTile = box11;
            }
            else
            {
                //doesnt save position unless you dont stop game window rip
                currentTile = lastTile;
            }
            //gets stats in stat table associated with current player id
            Player x = GetStats(Player.CurrentPlayer.ID);
            //if current id matches pulled id
            if (x.ID == Player.CurrentPlayer.ID)
            {   //pulls stats from x into current player
                Player.CurrentPlayer.Str = x.Str;
                Player.CurrentPlayer.Hp = x.Hp;
                Player.CurrentPlayer.Stam = x.Stam;
                strText.Text = Player.CurrentPlayer.Str.ToString();
                hpText.Text = Player.CurrentPlayer.Hp.ToString();
                stamText.Text = Player.CurrentPlayer.Stam.ToString();
            }
            else { }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            StringBuilder chat = new StringBuilder(chatBox.Text);
            if (e.KeyChar == (char)Keys.Return)
            {
                chat.AppendLine();
                chat.Append(Player.CurrentPlayer.Username + ": " + textBox1.Text);
                chatBox.Text = chat.ToString();
                textBox1.Clear();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Player.CurrentPlayer.Status = "Offline";
            DataAccess.EditAcc(Player.CurrentPlayer.ID, status, Player.CurrentPlayer.Status);
            this.Owner.Show();
            this.Hide();
        }
    }
}
