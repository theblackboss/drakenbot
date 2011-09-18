using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Tibia;
using Tibia.Constants;
using Tibia.Objects;
using Tibia.Packets;
using Tibia.Util;

namespace Drakenbot
{
    public partial class frmMain : Form
    {
        public Client Client;
        public Player Player;

        Forms.frmMapView frmMapView = new Forms.frmMapView();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Client = ClientChooser.ShowBox();
            if (Client == null || !Client.LoggedIn)

            {
                MessageBox.Show("You must have at least one client open and logged in.");
                Application.Exit();
            }
            else
            {
                Player = Client.GetPlayer();
            }
        }

        private void uxCustomTitle_Click(object sender, EventArgs e)
        {
            if (uxCustomTitle.Checked == true)
                Client.Window.Title = "Tibia - Draken Bot [" + (Player.Name).ToString() + "]";
            else
                Client.Window.Title = "Tibia";
        }

        private void uxMapView_Click(object sender, EventArgs e)
        {
            frmMapView.ShowDialog();
        }
    }
}
