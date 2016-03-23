using System.Windows;
using System.Windows.Controls;
using Weatherwatch.Core;
using Weatherwatch.Screens;

namespace Weatherwatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private Screen Currentscreen
        {
            set
            {
                MainGrid.Children.Clear();
                MainGrid.Children.Add(value);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            Currentscreen = new ActualWeatherScreen();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (((FrameworkElement)sender).Name)
            {
                case "Btn1":
                    Currentscreen = new ActualWeatherScreen();
                    break;
                case "Btn2":
                    Currentscreen = new SettingsScreen();
                    break;
                case "Btn3":
                    Currentscreen = new ArchivedWeatherScreen();
                    break;

            }
        }
    }
}
