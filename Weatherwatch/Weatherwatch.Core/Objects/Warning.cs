using System;
using System.Windows.Media;

namespace Weatherwatch.Core.Objects
{
    public class Warning
    {
        public string Location { get; private set; }
        public string WarningType { get; private set; }
        public string WarningLevel { get; private set; }
        public string StartTime { get; private set; }
        public string EndTime { get; private set; }

        public Warning(string location, string warningType, string warningLevel, string startTime, string endTime)
        {
            Location = location;
            WarningType = warningType;
            WarningLevel = warningLevel;
            StartTime = startTime;
            EndTime = endTime;
        }

        public SolidColorBrush Color
        {
            get
            {
                return new SolidColorBrush(Colors.Yellow);
            }
        }
    }
}
