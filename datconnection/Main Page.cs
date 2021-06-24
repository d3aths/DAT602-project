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
    public partial class Main_Page : Form
    {
        private UserInput loginpage = new UserInput();
        public Main_Page()
        {
            InitializeComponent();
        }
        //opens the loginpage and hides main frame
        private void enterBtn_Click(object sender, EventArgs e)
        {
            loginpage.Show();
            this.Hide();
        }

        //changes colour when mouseover
        private void enterBtn_MouseEnter(object sender, EventArgs e)
        {
            enterBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            enterBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
        }
        //changes colour back
        private void enterBtn_MouseLeave(object sender, EventArgs e)
        {
            enterBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            enterBtn.ForeColor = System.Drawing.Color.White;
        }
    }
}
