using System;

namespace Weatherwatch.Core.Objects
{
    public class Settings
    {
        private static Settings _instance;
        private readonly SaveTimer _saveTimer;

        private int _saveInterval;

        public int SaveInterval
        {
            get { return _saveInterval; }
            set
            {
                _saveInterval = value;
                _saveTimer.SetInterval(_saveInterval);
            }
        }


        private Settings()
        {
            SaveInterval = 60;
            _saveTimer = new SaveTimer();
        }

        public void StarTimer()
        {
            _saveTimer.StartTimer(new DateTime(),new DateTime());
        }

        public void StopTimer()
        {
            _saveTimer.StopTimer();
        }

        public static Settings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Settings();
            }

            return _instance;
        }
    }
}
