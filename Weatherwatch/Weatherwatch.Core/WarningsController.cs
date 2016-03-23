using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherwatch.Core
{
    public class WarningsController
    {
        private readonly Storage _storage;

        public WarningsController()
        {
            _storage = Storage.GetInstance();
        }

        public Warning GetWarning(string location)
        {
            return _storage.GetWarning(location);
        }

        public List<Warning> GetWarnings()
        {
            return _storage.GetWarnings();
        }
    }
}
