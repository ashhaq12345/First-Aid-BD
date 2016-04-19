using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Device.Location;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using GART.BaseControls;
using GART.Data;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MosqueFinder.Resources;

namespace MosqueFinder
{
    public partial class MainPage : PhoneApplicationPage
    {
        private readonly GeoCoordinateWatcher _GeoWatcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
        private ObservableCollection<ARItem> locations;
        private GeoPosition<GeoCoordinate> CurrentPosition { get; set; }

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            _GeoWatcher.PositionChanged += (o, args) => Dispatcher.BeginInvoke(() =>
            {
                CurrentPosition = _GeoWatcher.Position;

                locations = new ObservableCollection<ARItem>
                {
                    new Destination()
                    {
                        GeoLocation = new GeoCoordinate(23.741597, 90.383537), 
                        Content = "Lab Aid Cardiac Hospital",
                        Description = GetLocationText(23.741597, 90.383537)
                    },
                    new Destination()
                    {
                        GeoLocation = new GeoCoordinate(23.725037, 90.399114), 
                        Content = "Dhaka medical college",
                        Description = GetLocationText(23.725037, 90.399114)
                    },
                    new Destination()
                    {
                        GeoLocation = new GeoCoordinate(23.752571, 90.385065), 
                        Content = "Samarita Hospital",
                        Description = GetLocationText(23.752571, 90.385065)
                    },
                    new Destination()
                    {
                        GeoLocation = new GeoCoordinate(23.811162, 90.43057), 
                        Content = "Apollo Hospital",
                        Description = GetLocationText(23.811162, 90.43057)
                    },
                    new Destination()
                    {
                        GeoLocation = new GeoCoordinate(23.745397, 90.372281), 
                        Content = "Ibn Sina Hospital",
                        Description = GetLocationText(23.745397, 90.372281)
                    },
                    new Destination()
                    {
                        GeoLocation = new GeoCoordinate(23.752988 , 90.381503), 
                        Content = "Square Hospital",
                        Description = GetLocationText(23.752988 , 90.381503)
                    }
                };

                ardisplay.ARItems = locations;
            });

            _GeoWatcher.Start();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private string GetLocationText(double lat, double lon)
        {
            if (CurrentPosition != null && CurrentPosition.Location != null)
            {
                var start = new GeoCoordinate(CurrentPosition.Location.Latitude, CurrentPosition.Location.Longitude);
                var end = new GeoCoordinate(lat, lon);
                var distance = start.GetDistanceTo(end);

                return distance < 1000
                    ? string.Format("{0}m away.", Math.Round((double)distance, 0))
                    : string.Format("{0}km away.", Math.Round((double)distance / 1000, 2));
            }

            return string.Empty;
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            // Stop AR services
            ardisplay.StopServices();

            base.OnNavigatedFrom(e);
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            // Start AR services
            ardisplay.StartServices();

            base.OnNavigatedTo(e);
        }

        protected override void OnOrientationChanged(OrientationChangedEventArgs e)
        {
            base.OnOrientationChanged(e);

            if (ardisplay != null)
            {
                var orientation = ControlOrientation.Default;

                switch (e.Orientation)
                {
                    case PageOrientation.LandscapeLeft:
                        orientation = ControlOrientation.Clockwise270Degrees;
                        ardisplay.Visibility = Visibility.Visible;
                        break;
                    case PageOrientation.LandscapeRight:
                        orientation = ControlOrientation.Clockwise90Degrees;
                        ardisplay.Visibility = Visibility.Visible;
                        break;

                }

                ardisplay.Orientation = orientation;
            }
        }

        private void worldView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}