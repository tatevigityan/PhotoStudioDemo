
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
            var colors = new SolidColorBrush[]
            {
                new SolidColorBrush(Color.FromRgb(113, 99, 186)),
                new SolidColorBrush(Color.FromRgb(90, 80, 128))
            };

            var buttons = new[] { homeButton, reservationButton, serviceButton, reportButton };
            var names = new[] { "Menu", "Reservation", "Service", "Report" };

            for (int i = 0; i < buttons.Length; i++)
                buttons[i].Background = colors[ListViewItem == names[i] ? 1 : 0];
        }
    }
}
 