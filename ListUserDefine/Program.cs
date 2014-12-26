using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListUserDefine
{
    class Program
    {
        static void Main(string[] args)
        {
            Item anItem1 = new Item();
            anItem1.name = "Cake";
            anItem1.unitPrice = 15;
            anItem1.category = "Fast Food";

            Item anItem2 = new Item();
            anItem2.name = "Laptop";
            anItem2.unitPrice = 150000;
            anItem2.category = "Electronics";

            List<Item> items = new List<Item>();
            items.Add(anItem1);
            items.Add(anItem2);

            foreach (Item anItem in items)
            {
                Console.WriteLine(anItem.name);
                Console.WriteLine(anItem.unitPrice);
                Console.WriteLine(anItem.category);
            }
            Console.ReadKey();
        }
    }
}
