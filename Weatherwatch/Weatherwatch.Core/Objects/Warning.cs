using System;

namespace Weatherwatch.Core.Objects
{
    public class Warning
    {
        public string Location { get; private set; }
        private string apiUrl;

        public Warning(string location, string apiUrl)
        {
            this.apiUrl = apiUrl;
            Location = location;
        }

        public bool SaveWarning()
        {
            //TODO save warning
            return false;
        }
    }
}
