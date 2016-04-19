using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace MosqueFinder
{
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String hospital = ((ComboBoxItem)ComboBoxMenu.SelectedItem).Content.ToString();
            if (hospital.Equals("LabAid Cardiac Hospital") == true)
            {
                TextBlock1.Text = "Address:	House- 06, Road-04, Dhanmondi Dhaka-1205";
                TextBlock2.Text = "Mobile:  01713333337";


            }
            if (hospital.Equals("Square Hospital") == true)
            {
                TextBlock1.Text = "Address:	18F, Bir Uttam Qazi Nuruzzaman Sarak, West Panthapath, Dhaka 1205";
                TextBlock2.Text = "Mobile:  01713141447";

            }
            if (hospital.Equals("Dhaka Medical College") == true)
            {
                TextBlock1.Text = "Address:	100 Secretariate Rd, Dhaka 1000";
                TextBlock2.Text = "Mobile:  028626812-16";

            }
            if (hospital.Equals("Samarita Hospital") == true)
            {
                TextBlock1.Text = "Address: 89/1, Panthapath, Dhaka-1215 Bangladesh";
                TextBlock2.Text = "Mobile:  029131901";

            }
            if (hospital.Equals("Ibn Sina Hospital") == true)
            {
                TextBlock1.Text = "Address:	House #64, Road #15/A,Dhanmondi, Dhaka 1209  email: info@ibnsinatrust.com";
                TextBlock2.Text = "Mobile: Reception: 01823039800 ";

            }
            if (hospital.Equals("Apollo Hospital") == true)
            {
                TextBlock1.Text = "Address:	Plot: 81, Block: E, Bashundhara R/A, Dhaka 1229, Bangladesh, Dhaka 1229";
                TextBlock2.Text = "Mobile:  01714-090000";

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String hospital = ((ComboBoxItem)ComboBoxMenu.SelectedItem).Content.ToString();
            if (hospital.Equals("LabAid Cardiac Hospital") == true)
            {
                TextBlock1.Text = "Address:	House- 06, Road-04, Dhanmondi Dhaka-1205";
                TextBlock2.Text = "Mobile:  01713333337";
                PhoneCallTask phoneCallTask = new PhoneCallTask();

                phoneCallTask.PhoneNumber = "+8801624948447";
                phoneCallTask.DisplayName = "LabAid Cardiac Hospital";

                phoneCallTask.Show();


            }
            if (hospital.Equals("Square Hospital") == true)
            {
                TextBlock1.Text = "Address:	18F, Bir Uttam Qazi Nuruzzaman Sarak, West Panthapath, Dhaka 1205";
                TextBlock2.Text = "Mobile:  01713141447";
                PhoneCallTask phoneCallTask = new PhoneCallTask();

                phoneCallTask.PhoneNumber = "+8801624948447";
                phoneCallTask.DisplayName = "Square Hospital";

                phoneCallTask.Show();

            }
            if (hospital.Equals("Dhaka Medical College") == true)
            {
                TextBlock1.Text = "Address:	100 Secretariate Rd, Dhaka 1000";
                TextBlock2.Text = "Mobile:  028626812-16";
                PhoneCallTask phoneCallTask = new PhoneCallTask();

                phoneCallTask.PhoneNumber = "+8801624948447";
                phoneCallTask.DisplayName = "Dhaka Medical College";

                phoneCallTask.Show();

            }
            if (hospital.Equals("Samarita Hospital") == true)
            {
                TextBlock1.Text = "Address: 89/1, Panthapath, Dhaka-1215 Bangladesh";
                TextBlock2.Text = "Mobile:  029131901";
                PhoneCallTask phoneCallTask = new PhoneCallTask();

                phoneCallTask.PhoneNumber = "+8801624948447";
                phoneCallTask.DisplayName = "Samarita Hospital";

                phoneCallTask.Show();

            }
            if (hospital.Equals("Ibn Sina Hospital") == true)
            {
                TextBlock1.Text = "Address:	House #64, Road #15/A,Dhanmondi, Dhaka 1209  email: info@ibnsinatrust.com";
                TextBlock2.Text = "Mobile: Reception: 01823039800 ";
                PhoneCallTask phoneCallTask = new PhoneCallTask();

                phoneCallTask.PhoneNumber = "+8801624948447";
                phoneCallTask.DisplayName = "Ibn Sina Hospital";

                phoneCallTask.Show();

            }
            if (hospital.Equals("Apollo Hospital") == true)
            {
                TextBlock1.Text = "Address:	Plot: 81, Block: E, Bashundhara R/A, Dhaka 1229, Bangladesh, Dhaka 1229";
                TextBlock2.Text = "Mobile:  01714-090000";
                PhoneCallTask phoneCallTask = new PhoneCallTask();

                phoneCallTask.PhoneNumber = "+8801624948447";
                phoneCallTask.DisplayName = "Apollo Hospital";

                phoneCallTask.Show();

            }
        }
    }
}