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
            _saveTimer = new SaveTimer();
            SaveInterval = 60;
        }

        public void StarTimer(DateTime start, DateTime end)
        {
            _saveTimer.StartTimer(start, end);
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
