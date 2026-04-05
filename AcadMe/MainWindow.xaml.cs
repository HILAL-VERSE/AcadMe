using AcadMe.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AcadMe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new TextBlock { Text = "Dashboard Screen Coming Soon", FontSize = 24 };
        }

        public void Subject_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new SubjectsView();
        }

        public void Attendance_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new TextBlock { Text = "Attendance Screen Coming Soon", FontSize = 24 };
        }

        public void Practicals_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new TextBlock { Text = "Practicals Screen Coming Soon", FontSize = 24 };
        }

        public void Tasks_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new TextBlock { Text = "Tasks Screen Coming Soon", FontSize = 24 };
        }

        public void Results_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new TextBlock { Text = "Result Screen Coming Soon", FontSize = 24 };
        }

        public void Settings_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new TextBlock { Text = "Settings Screen Coming Soon", FontSize = 24 };
        }
    }

}