using System.Windows;
using Weatherwatch.Core;
using Weatherwatch.Screens;

namespace Weatherwatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly Screen[] screens;

        private Screen Currentscreen
        {
            set
            {
                value.Set();
                MainGrid.Children.Clear();
                MainGrid.Children.Add(value);
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            screens = new Screen[]
            {
                new ActualWeatherScreen(),
                new SettingsScreen(),
                new ArchivedWeatherScreen()
            };

            Currentscreen = screens[0];
        }

        private void Btn_Actueel_Click(object sender, RoutedEventArgs e)
        {
            Currentscreen = screens[0];
        }

        private void Btn_Settings_Click(object sender, RoutedEventArgs e)
        {
            Currentscreen = screens[1];
        }

        private void Btn_Arhief_Click(object sender, RoutedEventArgs e)
        {
            Currentscreen = screens[2];
        }
    }
}
