
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Photo_Studio
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            menuItemColor("Menu");
        }
        
        private void Border_MouseDown(object sender,MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
         
        private void closeWindow(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void homeButtonClick(object sender, RoutedEventArgs e)
        {
            menuItemColor("Menu");
        }
        private void reservationButtonClick(object sender, RoutedEventArgs e)
        {
            menuItemColor("Reservation");
        }
        private void serviceButtonClick(object sender, RoutedEventArgs e)
        {
            menuItemColor("Service");
        }
        private void reportButtonClick(object sender, RoutedEventArgs e)
        {
            menuItemColor("Report");
        }

        private void menuItemColor(string ListViewItem)
        {
            switch (ListViewItem)
            {
                case "Menu":
                    homeButton.Background = new SolidColorBrush(Color.FromRgb(90, 80, 128));
                    reservationButton.Background = null;
                    serviceButton.Background = null;
                    //reportButton.Background = new SolidColorBrush(Color.FromRgb(113, 99, 186));
                    break;

                case "Reservation":
                    homeButton.Background = new SolidColorBrush(Color.FromRgb(113, 99, 186));
                    reservationButton.Background = new SolidColorBrush(Color.FromRgb(90, 80, 128));
                    serviceButton.Background = new SolidColorBrush(Color.FromRgb(113, 99, 186));
                    //reportButton.Background = new SolidColorBrush(Color.FromRgb(113, 99, 186));
                    break;

                case "Service":
                    homeButton.Background = new SolidColorBrush(Color.FromRgb(113, 99, 186));
                    reservationButton.Background = new SolidColorBrush(Color.FromRgb(113, 99, 186));
                    serviceButton.Background = new SolidColorBrush(Color.FromRgb(90, 80, 128));
                   // reportButton.Background = new SolidColorBrush(Color.FromRgb(113, 99, 186));
                    break;

                case "Report":
                    homeButton.Background = new SolidColorBrush(Color.FromRgb(113, 99, 186));
                    reservationButton.Background = new SolidColorBrush(Color.FromRgb(113, 99, 186));
                    serviceButton.Background = new SolidColorBrush(Color.FromRgb(113, 99, 186));
                    //reportButton.Background = new SolidColorBrush(Color.FromRgb(90, 80, 128));
                    break;
            }
        }
    }
}
 