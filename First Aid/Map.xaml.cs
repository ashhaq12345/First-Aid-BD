using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Maps.Controls;
using System.Device.Location;
using System.Windows.Media;
using System.Windows.Shapes;

namespace MosqueFinder
{
    public partial class Map : PhoneApplicationPage
    {
        public Map()
        {
            InitializeComponent();
        }


        
        
        
    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String hospital = ((ComboBoxItem)ComboBoxMenu.SelectedItem).Content.ToString();
            if (hospital.Equals("LabAid Cardiac Hospital") == true)
            {

                
                GeoCoordinate myGeoCoordinate = new GeoCoordinate(23.741597, 90.383537);
                MyMap.Center = myGeoCoordinate;
                showbuilding();
                zoom();
                mark(23.741597, 90.383537);
               

            }
            if (hospital.Equals("Ibn Sina Hospital") == true)
            {


                GeoCoordinate myGeoCoordinate = new GeoCoordinate(23.745397, 90.372281);
                MyMap.Center = myGeoCoordinate;
                showbuilding();
                zoom();
                mark(23.745397, 90.372281);


            }
            if (hospital.Equals("Samarita Hospital") == true)
            {


                GeoCoordinate myGeoCoordinate = new GeoCoordinate(23.752571, 90.385065);
                MyMap.Center = myGeoCoordinate;
                showbuilding();
                zoom();
                mark(23.752571, 90.385065);


            }
            if (hospital.Equals("Square Hospital") == true)
            {


                GeoCoordinate myGeoCoordinate = new GeoCoordinate(23.752988, 90.381503);
                MyMap.Center = myGeoCoordinate;
                showbuilding();
                zoom();
                mark(23.752988, 90.381503);


            }
            if (hospital.Equals("Dhaka Medical College") == true)
            {


                GeoCoordinate myGeoCoordinate = new GeoCoordinate(23.725037, 90.399114);
                MyMap.Center = myGeoCoordinate;
                showbuilding();
                zoom();
                mark(23.725037, 90.399114);


            }
            if (hospital.Equals("Apollo Hospital") == true)
            {


                GeoCoordinate myGeoCoordinate = new GeoCoordinate(23.811162, 90.43057);
                MyMap.Center = myGeoCoordinate;
                showbuilding();
                zoom();
                mark(23.811162, 90.43057);


            }

        }
        private void showbuilding() {
            MyMap.LandmarksEnabled = true;
        }
        private void zoom()
        {
            MyMap.ZoomLevel = 16;
        }
        private void mark(double a,double b)
        {
            GeoCoordinate myGeoCoordinate = new GeoCoordinate(a, b);
            Ellipse myCircle = new Ellipse();
            myCircle.Fill = new SolidColorBrush(Colors.Blue);
            myCircle.Height = 20;
            myCircle.Width = 20;
            myCircle.Opacity = 100;
            MapOverlay myLocationOverlay = new MapOverlay();
            myLocationOverlay.Content = myCircle;
            myLocationOverlay.PositionOrigin = new Point(0.5, 0.5);
            myLocationOverlay.GeoCoordinate = myGeoCoordinate;
            MapLayer myLocationLayer = new MapLayer();
            myLocationLayer.Add(myLocationOverlay);
            MyMap.Layers.Add(myLocationLayer);
        }
    }

}