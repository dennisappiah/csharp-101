using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.OverridingMethods.ExampleTwo
{
    public class Corolla : Car
    {
        // the abstract method in the abstract class forces an child class to implement SetClock method
        public override void SetClock()
        {
            Console.WriteLine("Set clock on corolla");
        }
    }
}
