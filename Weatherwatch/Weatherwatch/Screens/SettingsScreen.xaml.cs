using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
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
using Weatherwatch.Annotations;
using Weatherwatch.Core.Objects;

namespace Weatherwatch.Screens
{
    /// <summary>
    /// Interaction logic for SettingsScreen.xaml
    /// </summary>
    public partial class SettingsScreen : INotifyPropertyChanged
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        private Settings _settings;

        public SettingsScreen()
        {
            InitializeComponent();

            _settings = Settings.GetInstance();
        }

        public override void Set()
        {
            StartDate = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
            EndDate = DateTime.Now.ToString("dd-MM-yyyy HH:mm"); ;

            OnPropertyChanged(nameof(StartDate));
            OnPropertyChanged(nameof(EndDate));
        }

        private void BtnSetInterval_Click(object sender, RoutedEventArgs e)
        {
            DateTime start = DateTime.ParseExact(StartDate, "dd-MM-yyyy HH:mm", new DateTimeFormatInfo());
            DateTime end = DateTime.ParseExact(EndDate, "dd-MM-yyyy HH:mm", new DateTimeFormatInfo());

            _settings.SaveInterval = Convert.ToInt32(TxbInterval.Text);
            _settings.StarTimer(start, end);
        }

        private void BtnStopInterval_Click(object sender, RoutedEventArgs e)
        {
            _settings.StopTimer();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
