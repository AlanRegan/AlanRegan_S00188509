using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AlanRegan_S00188509
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from p in db.PhoneDetails
                        select p.Name;
            
            lbxPhones.ItemsSource = query.ToList();
           
            
        }

        private void lbxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Display phone info
            // Determine which phone was selected:
            Phone selectedPhone = lbxPhones.SelectedItem as Phone;

            // Check for null
            if (selectedPhone != null)
            {
                // Display car info
                string phoneCost = $"Blah: {selectedPhone.Price.ToString()}";
                tblkPrice.Text = phoneCost;

                // Display car image
                imgPhone.Source = new BitmapImage(new Uri($"/images/{selectedPhone.Phone_Image}", UriKind.Relative));
            }
        }
    }
}
