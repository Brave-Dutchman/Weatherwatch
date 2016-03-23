using System;

namespace Weatherwatch.Core.Objects
{
    public class Warning
    {
        public string Location { get; private set; }

        private DateTime _startTime;
        private DateTime _endTime;
        private string _type;
        private string _level;

        public Warning(DateTime startTime, DateTime endTime, string location, string type, string level)
        {
            _startTime = startTime;
            _endTime = endTime;
            Location = location;
            _type = type;
            _level = level;
        }

        public bool SaveWarning()
        {
            //TODO save warning
            return false;
        }
    }
}
