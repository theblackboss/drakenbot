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

namespace Drakenbot.Forms
{
    public partial class frmMapView : Form
    {
        Client Client;
        Player Player;
        public frmMapView()
        {
            InitializeComponent();
        }

        private void frmMapView_Load(object sender, EventArgs e)
        {
            Client = Client.GetClients()[0];
            Player = Client.GetPlayer();
        }

        private void t_map_view_Tick(object sender, EventArgs e)
        {
            uxMapView.LoadMap();
            System.Threading.Thread.Sleep(350);
            uxMapView.SetLevel((Player.Location.Z));
            uxMapView.SetMapCenter(Player.Location);
        }

        private void uxZoomIn_Click(object sender, EventArgs e)
        {
            uxMapView.Zoom(2.00);
        }

        private void uxZoomOut_Click(object sender, EventArgs e)
        {
            uxMapView.Zoom(0.50);
        }

        private void uxEnableMapView_CheckedChanged(object sender, EventArgs e)
        {
            if (uxEnableMapView.Checked == true)
            {
                t_map_view.Start();
                uxMapView.Markers.Add(new MapViewer.MapMarker(Player));
            }
            else
            {
                t_map_view.Stop();
            }
        }
    }
}
