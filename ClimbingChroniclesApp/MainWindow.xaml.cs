using System.Windows;

namespace ClimbingChroniclesApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Climbers_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.ClimberPage());
        }

        private void Mountains_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.MountainPage());
        }

        private void Groups_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.GroupPage());
        }

        private void Expeditions_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.ExpeditionPage());
        }
    }
}