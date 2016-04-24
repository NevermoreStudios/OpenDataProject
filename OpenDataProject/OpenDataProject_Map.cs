using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap;
using GMap.NET;
using GMap.NET.Internals;
using GMap.NET.MapProviders;
using GMap.NET.ObjectModel;
using GMap.NET.Projections;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.CacheProviders;

namespace OpenDataProject
{
    public partial class OpenDataProject_Map : Form
    {
        public OpenDataProject_Map()
        {
            InitializeComponent();
            try
            {
                System.Net.IPHostEntry e =
                     System.Net.Dns.GetHostEntry("www.google.com");
            }
            catch
            {
                MainMap.Manager.Mode = AccessMode.CacheOnly;
                MessageBox.Show("No internet connection avaible, going to CacheOnly mode.",
                      "GMap.NET - Demo.WindowsForms", MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
            }

            // config map
            MainMap.MapProvider = GMapProviders.OpenStreetMap;
            MainMap.Position = new PointLatLng(44.735027899515465, 20.533447265625);
            MainMap.MinZoom = 0;
            MainMap.MaxZoom = 24;
            MainMap.Zoom = 9;

            {
                //MainMap.OnPositionChanged += new PositionChanged(MainMap_OnPositionChanged);

                //MainMap.OnTileLoadStart += new TileLoadStart(MainMap_OnTileLoadStart);
                //MainMap.OnTileLoadComplete += new TileLoadComplete(MainMap_OnTileLoadComplete);

                //MainMap.OnMapZoomChanged += new MapZoomChanged(MainMap_OnMapZoomChanged);
                //MainMap.OnMapTypeChanged += new MapTypeChanged(MainMap_OnMapTypeChanged);

                MainMap.OnMarkerClick += new MarkerClick(MainMap_OnMarkerClick);
                //MainMap.OnMarkerEnter += new MarkerEnter(MainMap_OnMarkerEnter);
                //MainMap.OnMarkerLeave += new MarkerLeave(MainMap_OnMarkerLeave);

                //MainMap.OnPolygonEnter += new PolygonEnter(MainMap_OnPolygonEnter);
                //MainMap.OnPolygonLeave += new PolygonLeave(MainMap_OnPolygonLeave);

                //MainMap.OnRouteEnter += new RouteEnter(MainMap_OnRouteEnter);
                //MainMap.OnRouteLeave += new RouteLeave(MainMap_OnRouteLeave);

                //MainMap.Manager.OnTileCacheComplete += new TileCacheComplete(OnTileCacheComplete);
                //MainMap.Manager.OnTileCacheStart += new TileCacheStart(OnTileCacheStart);
                //MainMap.Manager.OnTileCacheProgress += new TileCacheProgress(OnTileCacheProgress);
            }
        }



        private void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
           skola res= OpenDataProjectCore.Skole.Find(skola => skola.Lat == item.Position.Lat && skola.Lon == item.Position.Lng);
            MessageBox.Show(res.ToString());
        }

        private void OpenDataProject_Map_Load(object sender, EventArgs e)
        {

        }

        private void MainMap_Load(object sender, EventArgs e)
        {
            GMapOverlay overlay = new GMapOverlay("overlay");
            foreach (skola skola in OpenDataProjectCore.GetFilter("All"))
            {
                overlay.Markers.Add(new GMarkerGoogle(new PointLatLng(skola.Lat, skola.Lon),GMarkerGoogleType.red));
            }
            MainMap.Overlays.Add(overlay);
        }

    }
}
