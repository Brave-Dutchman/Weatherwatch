namespace Weatherwatch.Core.Objects
{
    public class Settings
    {
        private static Settings _instance;

        private SaveTimer saveTimer;

        public static Settings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Settings();
            }

            return _instance;
        }

        //TODO implement settings
    }
}
