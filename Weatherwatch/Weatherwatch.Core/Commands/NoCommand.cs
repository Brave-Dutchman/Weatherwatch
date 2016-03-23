using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherwatch.Core
{
    class NoCommand : Command
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
