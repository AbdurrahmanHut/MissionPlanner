using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class FormBorderPoints : Form
    {
        public FormBorderPoints()
        {
            InitializeComponent();
        }
        public GMapOverlay returnAreaBorders { get; set; }
        public double returnAreaPoint1Lat { get; set; }
        public double returnAreaPoint1Long { get; set; }
        public double returnAreaPoint2Lat { get; set; }
        public double returnAreaPoint2Long { get; set; }
        public double returnAreaPoint3Lat { get; set; }
        public double returnAreaPoint3Long { get; set; }
        public double returnAreaPoint4Lat { get; set; }
        public double returnAreaPoin4Long { get; set; }

        private void btnSaveBorders_Click(object sender, EventArgs e)
        {
            List<PointLatLng> borderPoints = new List<PointLatLng>();
            PointLatLng point1 = new PointLatLng(double.Parse(tBBorderLat1.Text), double.Parse(tBBorderLong1.Text));
            PointLatLng point2 = new PointLatLng(double.Parse(tBBorderLat2.Text), double.Parse(tBBorderLong2.Text));
            PointLatLng point3 = new PointLatLng(double.Parse(tBBorderLat3.Text), double.Parse(tBBorderLong3.Text));
            PointLatLng point4 = new PointLatLng(double.Parse(tBBorderLat4.Text), double.Parse(tBBorderLong4.Text));
            borderPoints.Add(point1);
            borderPoints.Add(point2);
            borderPoints.Add(point4);
            borderPoints.Add(point3);
            GMapPolygon borderPolygon = new GMapPolygon(borderPoints, "BorderPolygon");
            // Set isCompetitionArea true to change polygon color
            borderPolygon.isCompetitionArea = true;
            GMapOverlay competitionAreaBorders = new GMapOverlay("BorderOverlay");
            competitionAreaBorders.Polygons.Add(borderPolygon);
            this.returnAreaBorders = competitionAreaBorders;
            //Return points
            this.returnAreaPoint1Lat = double.Parse(tBBorderLat1.Text);
            this.returnAreaPoint1Long = double.Parse(tBBorderLong1.Text);
            this.returnAreaPoint2Lat = double.Parse(tBBorderLat2.Text);
            this.returnAreaPoint2Long = double.Parse(tBBorderLong2.Text);
            this.returnAreaPoint3Lat = double.Parse(tBBorderLat3.Text);
            this.returnAreaPoint3Long = double.Parse(tBBorderLong3.Text);
            this.returnAreaPoint4Lat = double.Parse(tBBorderLat4.Text);
            this.returnAreaPoin4Long = double.Parse(tBBorderLong4.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
