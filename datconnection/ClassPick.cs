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
    public partial class ClassPick : Form
    {
        dataAccess DataAccess = new dataAccess();
        public Player player;
        public ClassPick()
        {
            InitializeComponent();
        }
        public DialogResult ShowDialog(Player slctdPlayer)
        {
            player = slctdPlayer;
            return ShowDialog();
        }
        private void zerkBtn_Click(object sender, EventArgs e)
        {
            var build = "berserker";
            Player.CurrentPlayer.Str = 50;
            Player.CurrentPlayer.Hp = 20;
            Player.CurrentPlayer.Stam = 20;
            DataAccess.PickClass(Player.CurrentPlayer.ID, build);
            DialogResult = DialogResult.OK;
        }

        private void ninBtn_Click(object sender, EventArgs e)
        {
            var build = "ninja";
            Player.CurrentPlayer.Str = 20;
            Player.CurrentPlayer.Hp = 20;
            Player.CurrentPlayer.Stam = 50;
            DataAccess.PickClass(Player.CurrentPlayer.ID, build);
            DialogResult = DialogResult.OK;
        }

        private void tankBtn_Click(object sender, EventArgs e)
        {
            var build = "tank";
            Player.CurrentPlayer.Str = 20;
            Player.CurrentPlayer.Hp = 100;
            Player.CurrentPlayer.Stam = 20;
            DataAccess.PickClass(Player.CurrentPlayer.ID, build);
            DialogResult = DialogResult.OK;
        }
    }
}
