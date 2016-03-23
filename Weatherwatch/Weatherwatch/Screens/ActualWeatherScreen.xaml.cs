using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
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

            ComboBox.ItemsSource = Controller.GetRadarNames();
            ComboBox.SelectedItem = ComboBox.Items[0];
        }

        private void ComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string radarName = (string) e.AddedItems[0];
            BitmapImage image = Controller.GetRadar(radarName).GetRadarImage();
            ImageBehavior.SetAnimatedSource(RadarDisplay, image);
        }
    }
}
