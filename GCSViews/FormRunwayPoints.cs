using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class FormRunwayPoints : Form
    {
        public FormRunwayPoints()
        {
            InitializeComponent();
        }
        public GMapOverlay returnBorders { get; set; }
        public double returnRunwayPointLong { get; set; }
        public double returnRunwayPointLat { get; set; }
        
        private void btnSaveRunway_Click(object sender, EventArgs e)
        {
            List<PointLatLng> runwayPoints = new List<PointLatLng>();
           
            PointLatLng point1 = new PointLatLng(double.Parse(tBLat1.Text), double.Parse(tBLong1.Text));
            PointLatLng point2 = new PointLatLng(double.Parse(tBLat2.Text), double.Parse(tBLong2.Text));
            PointLatLng point3 = new PointLatLng(double.Parse(tBLat3.Text), double.Parse(tBLong3.Text));
            PointLatLng point4 = new PointLatLng(double.Parse(tBLat4.Text), double.Parse(tBLong4.Text));
            runwayPoints.Add(point1);
            runwayPoints.Add(point2);
            runwayPoints.Add(point3);
            runwayPoints.Add(point4);
            GMapPolygon runwayPolygon = new GMapPolygon(runwayPoints, "RunwayPolygon");
            // Set isRunway true to change polygon color
            runwayPolygon.isRunway = true;
            GMapOverlay competitionBorders = new GMapOverlay("RunwayOverlay");
            competitionBorders.Polygons.Add(runwayPolygon);
            this.returnBorders = competitionBorders;
            // Return runway points
            this.returnRunwayPointLong = double.Parse(tBLong1.Text);
            this.returnRunwayPointLat = double.Parse(tBLat1.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
