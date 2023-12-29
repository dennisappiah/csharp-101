using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.Interfaces
{
    public class GameController : IComputerController, IDisposable
    {
        public int BatteryLevel { get; set; }
        public void Connect()
        {
           
        }

        public void CurrentKeyPressed() { }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
