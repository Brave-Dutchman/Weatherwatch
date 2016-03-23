namespace Weatherwatch.Core.Objects
{
    public class Settings
    {
        private static Settings _instance;
        private SaveTimer _saveTimer;

        private int _saveInterval;

        public int SaveInterval
        {
            get { return _saveInterval; }
            set
            {
                _saveInterval = value; 
                
            }
        }


        private Settings()
        {
            SaveInterval = 60;
            _saveTimer = new SaveTimer();
        }

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
