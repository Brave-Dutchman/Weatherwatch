using Weatherwatch.Core;
using Weatherwatch.Screens;

namespace Weatherwatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private Screen _currentscreen;

        private Screen Currentscreen
        {
            get { return _currentscreen; }
            set
            {
                MainGrid.Children.Clear();

                _currentscreen = value;

                MainGrid.Children.Add(_currentscreen);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            Currentscreen = new ActualWeatherScreen();
        }
    }
}
