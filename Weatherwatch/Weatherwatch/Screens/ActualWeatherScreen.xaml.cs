using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Weatherwatch.Core.Controller;
using Weatherwatch.Core.Objects;
using WpfAnimatedGif;

namespace Weatherwatch.Screens
{
    /// <summary>
    /// Interaction logic for ActualWeatherScreen.xaml
    /// </summary>
    public partial class ActualWeatherScreen
    {
        public ActualWeatherScreen()
        {
            InitializeComponent();

            CbxWarningLocation.ItemsSource = Controller.GetWarningLocations();
            CbxWarningLocation.SelectedItem = CbxWarningLocation.Items[0];

            ComboBox.ItemsSource = Controller.GetRadarNames();
            ComboBox.SelectedItem = ComboBox.Items[0];
        }

        private void ComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string radarName = (string) e.AddedItems[0];
            BitmapImage image = Controller.GetRadar(radarName).GetRadarImage();
            ImageBehavior.SetAnimatedSource(RadarDisplay, image);
        }

        private void CbxWarningLocation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string warningLocation = (string) e.AddedItems[0];
            Controller.SetSelectedWarning(warningLocation);

            Warning[] warningList = Controller.GetWarnings(warningLocation);
            string allWarnings = "";
            foreach (Warning warning in warningList)
            {
                allWarnings += warning + "\r\n";
            }
            TbxTempWarn.Text = allWarnings;
        }

        private void SaveAll_Click(object sender, RoutedEventArgs e)
        {
            Controller.ExecuteCommand(CommandsEnum.SaveAll);
        }

        private void SaveRadars_Click(object sender, RoutedEventArgs e)
        {
            Controller.ExecuteCommand(CommandsEnum.SaveRadars);
        }

        private void SaveWarnings_Click(object sender, RoutedEventArgs e)
        {
            Controller.ExecuteCommand(CommandsEnum.SaveWarnings);
        }

        private void ReloadAll_Click(object sender, RoutedEventArgs e)
        {
            Controller.ExecuteCommand(CommandsEnum.ReloadAll);
        }

        private void ReloadRadars_Click(object sender, RoutedEventArgs e)
        {
            Controller.ExecuteCommand(CommandsEnum.ReloadRadars);

            BitmapImage image = Controller.GetRadar(ComboBox.SelectedItem.ToString()).GetRadarImage();
            ImageBehavior.SetAnimatedSource(RadarDisplay, image);
        }

        private void ReloadWarnings_Click(object sender, RoutedEventArgs e)
        {
            Controller.ExecuteCommand(CommandsEnum.ReloadWarnings);
        }
    }
}
