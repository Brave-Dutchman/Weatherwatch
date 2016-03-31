using System;
using System.IO;

namespace Weatherwatch.Core
{
    public static class FileStorage
    {
        private static string _location;

        static FileStorage()
        {
            _location = AppDomain.CurrentDomain.BaseDirectory;
            _location += "Archief\\";
        }

        public static string CreateFile()
        {
            DateTime time = DateTime.Now;
            string loc = (time.ToLongDateString() + " " + time.ToShortTimeString() + "\\").Replace(':','-');

            string tempLoction = _location + loc;

            if (!Directory.Exists(tempLoction))
            {
                Directory.CreateDirectory(tempLoction);
            }

            return tempLoction;
        }
    }
}
