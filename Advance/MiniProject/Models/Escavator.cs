using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.MiniProject
{
    // we can only rent an escavator 
    public class Escavator: InventoryItem, IRentable
    {
        public void Dig() {
            Console.WriteLine("I am digging");
        }

        public void Rent()
        {
            QuantityInStock =- 1;
            Console.WriteLine("This escavtor has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("This escavtor has been returned");
        }
    }
}
