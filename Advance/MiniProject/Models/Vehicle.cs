using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.MiniProject
{
    // we can purchase and rent vehicles
    public class Vehicle : InventoryItem, IRentable, IPurchasable
    {
        public decimal DealerFee { get; set; }
        public string Manufacturer { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been purchased");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("This vehicle has been rented");
        }

        public override string ToString()
        {
            return $"{ProductName} {DealerFee}";
        }
    }
}
