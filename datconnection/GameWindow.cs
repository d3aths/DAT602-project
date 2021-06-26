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
    public partial class GameWindow : Form
    {
        dataAccess fDataAccess = new dataAccess();

        private PictureBox currentTile;
        private PictureBox nTile;
        private PictureBox sTile;
        private PictureBox eTile;
        private PictureBox wTile;
        //this is fucking stupid and doesnt work

        public GameWindow()
        {
            InitializeComponent();
            currentTile = box11;
        }

        void checkPos()
        {
            //godddd im going to have to do this for every single tile
            if (currentTile == box11)
            {
                nTile = null;
                sTile = box12;
                eTile = box21;
                wTile = null;
            }
            else if (currentTile == box12)
            {
                nTile = box11;
                sTile = box13;
                eTile = box22;
                wTile = null;
            }
            else if (currentTile == box13)
            {
                nTile = box12;
                sTile = box14;
                eTile = box23;
                wTile = null;
            }
            else if (currentTile == box14)
            {
                nTile = box13;
                sTile = null;
                eTile = box24;
                wTile = null;
            }
            else if (currentTile == box21)
            {
                nTile = null;
                sTile = box22;
                eTile = box31;
                wTile = box11;
            }
            else if (currentTile == box22)
            {
                nTile = box21;
                sTile = box23;
                eTile = box32;
                wTile = box12;
            }
            else if (currentTile == box23)
            {
                nTile = box22;
                sTile = box24;
                eTile = box33;
                wTile = box13;
            }
            else if (currentTile == box24)
            {
                nTile = box23;
                sTile = null;
                eTile = box34;
                wTile = box14;
            }
            else if (currentTile == box31)
            {
                nTile = null;
                sTile = box32;
                eTile = box41;
                wTile = box21;
            }
            else if (currentTile == box32)
            {
                nTile = box31;
                sTile = box33;
                eTile = box42;
                wTile = box22;
            }
            else if (currentTile == box33)
            {
                nTile = box32;
                sTile = box34;
                eTile = box43;
                wTile = box23;
            }
            else if (currentTile == box34)
            {
                nTile = box33;
                sTile = null;
                eTile = box44;
                wTile = box24;
            }
            else if (currentTile == box41)
            {
                nTile = null;
                sTile = box42;
                eTile = box51;
                wTile = box31;
            }
            else if (currentTile == box42)
            {
                nTile = box41;
                sTile = box43;
                eTile = box52;
                wTile = box32;
            }
            else if (currentTile == box43)
            {
                nTile = box42;
                sTile = box44;
                eTile = box53;
                wTile = box33;
            }
            else if (currentTile == box44)
            {
                nTile = box43;
                sTile = null;
                eTile = box54;
                wTile = box34;
            }
            else if (currentTile == box51)
            {
                nTile = null;
                sTile = box52;
                eTile = box61;
                wTile = box41;
            }
            else if (currentTile == box52)
            {
                nTile = box51;
                sTile = box53;
                eTile = box62;
                wTile = box42;
            }
            else if (currentTile == box53)
            {
                nTile = box52;
                sTile = box54;
                eTile = box63;
                wTile = box43;
            }

            else if (currentTile == box54)
            {
                nTile = box53;
                sTile = null;
                eTile = box64;
                wTile = box44;
            }
            else if (currentTile == box61)
            {
                nTile = null;
                sTile = box62;
                eTile = null;
                wTile = box51;
            }
            else if (currentTile == box62)
            {
                nTile = box61;
                sTile = box63;
                eTile = null;
                wTile = box52;
            }
            else if (currentTile == box63)
            {
                nTile = box62;
                sTile = box64;
                eTile = null;
                wTile = box53;
            }
            else if (currentTile == box64)
            {
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
            //assign south tile to current
            sTile = currentTile;
            //puts bg image on new current
            currentTile.BackgroundImage = global::datconnection.Properties.Resources.playerpic;

        }

        private void eastBtn_Click(object sender, EventArgs e)
        {

        }

        private void westBtn_Click(object sender, EventArgs e)
        {

        }

        private void northBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
