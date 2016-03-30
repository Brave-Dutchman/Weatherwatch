using System;

namespace Weatherwatch.Core.Objects
{
    public class Warning
    {
        public string Location { get; private set; }
        public string WarningType { get; private set; }
        public string WarningLevel { get; private set; }
        public string StartTime { get; private set; }
        public string EndTime { get; private set; }
        private string apiUrl;

        public Warning(string location, string warningType, 
            string warningLevel, string startTime, string endTime, string apiUrl)
        {
            this.apiUrl = apiUrl;
            Location = location;
            WarningType = warningType;
            WarningLevel = warningLevel;
            StartTime = startTime;
            EndTime = endTime;
        }

        public bool SaveWarning()
        {
            //TODO save warning
            return false;
        }
    }
}
