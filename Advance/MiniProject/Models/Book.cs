using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.MiniProject
{
    // we can only purchase books
    public class Book : InventoryItem, IPurchasable
    {
        public int NumberOfPages { get; set; }

        public void Purchase()
        {
            QuantityInStock = -1;
            Console.WriteLine("This book has been purchased");
        }
    }
}
