using System;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Collections.Generic;

namespace OpenDataProject
{
    public partial class Map : Form
    {
        string Keyword;
        public Map(string Keyword)
        {
            this.Keyword = Keyword;
            InitializeComponent();
            try
            {
                System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.com");
            }
            catch
            {
                MainMap.Manager.Mode = AccessMode.CacheOnly;
                MessageBox.Show(
                    "No internet connection avaible, going to CacheOnly mode.",
                    "GMap.NET - Demo.WindowsForms",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            // config map
            MainMap.MapProvider = GMapProviders.OpenStreetMap;
            MainMap.Position = new PointLatLng(44.735027899515465, 20.533447265625);
            MainMap.MinZoom = 0;
            MainMap.MaxZoom = 24;
            MainMap.Zoom = 9;
            MainMap.OnMarkerClick += new MarkerClick(MainMap_OnMarkerClick);
        }


        private void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            Skola res = Core.Skole.Find(skola => skola.Lat == item.Position.Lat && skola.Lon == item.Position.Lng);
            // TO DO: Visuelization
            MessageBox.Show(res.ToString());
        }

        private void OpenDataProject_Map_Load(object sender, EventArgs e)
        {

        }

        private void MainMap_Load(object sender, EventArgs e)
        {
            GMapOverlay overlay = new GMapOverlay("overlay");
            foreach (Skola skola in Core.GetFilter(Keyword))
                overlay.Markers.Add(new GMarkerGoogle(new PointLatLng(skola.Lat, skola.Lon),GMarkerGoogleType.red));
            MainMap.Overlays.Add(overlay);
        }

    }
}
