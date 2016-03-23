using System;
using System.Windows.Threading;

namespace Weatherwatch.Core
{
    public class SaveTimer
    {
        private bool _isRunning;
        private DateTime _startTime;
        private DateTime _endTime;

        private DispatcherTimer _timer;

        //TODO saveAll Commands


        public SaveTimer()
        {
            _isRunning = false;
            _startTime = default(DateTime);
            _endTime = default(DateTime);

            _timer = new DispatcherTimer();

            //TODO fix implementation
        }

        public void StartTimer(DateTime startTime, DateTime endTime)
        {
            
        }

        public void StopTimer()
        {

        }

        public void SetInterval()
        {

        }
    }
}