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
            MainMap.Position = new PointLatLng(54.6961334816182, 25.2985095977783);
            MainMap.MinZoom = 0;
            MainMap.MaxZoom = 24;
            MainMap.Zoom = 9;

            // add your custom map db provider
            //GMap.NET.CacheProviders.MySQLPureImageCache ch = new GMap.NET.CacheProviders.MySQLPureImageCache();
            //ch.ConnectionString = @"server=sql2008;User Id=trolis;Persist Security Info=True;database=gmapnetcache;password=trolis;";
            //MainMap.Manager.SecondaryCache = ch;

            // set your proxy here if need
            //GMapProvider.WebProxy = new WebProxy("10.2.0.100", 8080);
            //GMapProvider.WebProxy.Credentials = new NetworkCredential("ogrenci@bilgeadam.com", "bilgeada");

            // map events
            {
                //MainMap.OnPositionChanged += new PositionChanged(MainMap_OnPositionChanged);

                //MainMap.OnTileLoadStart += new TileLoadStart(MainMap_OnTileLoadStart);
                //MainMap.OnTileLoadComplete += new TileLoadComplete(MainMap_OnTileLoadComplete);

                //MainMap.OnMapZoomChanged += new MapZoomChanged(MainMap_OnMapZoomChanged);
                //MainMap.OnMapTypeChanged += new MapTypeChanged(MainMap_OnMapTypeChanged);

                //MainMap.OnMarkerClick += new MarkerClick(MainMap_OnMarkerClick);
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
        
        private void OpenDataProject_Map_Load(object sender, EventArgs e)
        {

        }
    }
}
