using System;
using System.Windows.Threading;
using Weatherwatch.Core.Commands;

namespace Weatherwatch.Core.Objects
{
    public class SaveTimer
    {
        private DateTime _endTime;

        private readonly DispatcherTimer _startTimer;
        private readonly DispatcherTimer _saveTimer;
        private readonly Command _command;

        public SaveTimer()
        {
            _command = new SaveAllCommand(new Command[] {new SaveWarningsCommand(), new SaveRadarsCommand()});

            _startTimer = new DispatcherTimer();
            _saveTimer = new DispatcherTimer();

            _startTimer.Tick += StartTimerOnTick;
            _saveTimer.Tick += SaveTimerOnTick;
        }
        
        public bool StartTimer(DateTime startTime, DateTime endTime, int interval)
        {
            if (DateTime.Now > endTime) return false;
            _endTime = endTime;

            if (startTime > DateTime.Now)
            {
                _startTimer.Interval = endTime - DateTime.Now;
                _startTimer.Start();
            }
            else
            {
                _saveTimer.Interval = TimeSpan.FromMinutes(interval);
                _saveTimer.Start();
            }

            return true;
        }

        public void StopTimer()
        {
            _startTimer.Stop();
            _saveTimer.Stop();
        }

        public void SetInterval(int interval)
        {
            _saveTimer.Interval = TimeSpan.FromMinutes(interval);
        }

        private void SaveTimerOnTick(object sender, EventArgs eventArgs)
        {
            if (DateTime.Now > _endTime)
            {
                _saveTimer.Stop();
                return;
            }

            _command.Execute();
        }

        private void StartTimerOnTick(object sender, EventArgs eventArgs)
        {
            _saveTimer.Start();
            _command.Execute();
        }
    }
}