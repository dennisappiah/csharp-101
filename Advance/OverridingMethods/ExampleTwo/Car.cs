using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.OverridingMethods.ExampleTwo
{
    public abstract class Car
    {
        public virtual void StartCar()
        {
            Console.WriteLine("Start the key on and start");
        }

       public abstract void SetClock();

       // internal abstract void StopCar();
    }
}
