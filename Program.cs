using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjModelFirst
{
    class Program
    {
        static Model1Container mfb = new Model1Container();
        static void Main(string[] args)
        {
            Console.WriteLine("MODEL FIRST APPROACH ");


            int ch = 0;
            do
            {
                Console.WriteLine("1.insert 2.display 3.exit ");
                Console.WriteLine("enter your choice");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        InsertCategory();
                        InsertProduct();

                        break;
                    case 2:
                        ShowCategory();
                        ShowProduct();
                        break;
                    case 3:
                        return;

                }
            } while (ch <= 2);




        }
        private static void ShowProduct()
        {
            Console.WriteLine("product details with category");

            var product = mfb.Product1;
            Console.WriteLine("{0,-8} {1,-14} {2,-14} {3,-8} {4,14} ", "Pid", "pname", "price", "cid", "Cname");
            foreach (var p in product)
            {
                Console.WriteLine("{0,-8} {1,-14} RS {2,-14} {3,-8} {4,14} ", p.Pid, p.Ptitle, p.Price, p.id, p.Category.CarTitle);
            }
        }

        private static void ShowCategory()
        {
            Console.WriteLine("category details");
            var category = mfb.Category1;
            foreach (var c in category)
            {
                Console.WriteLine("{0} {1} ", c.Id, c.CarTitle);
            }
        }
        private static void InsertCategory()
        {
            Console.WriteLine("enter cetogry detials");
            Console.WriteLine("enter name");
            string cname = Console.ReadLine();
            var category = new Category1
            {
                CarTitle = cname
            };
            mfb.Category1.Add(category);
            mfb.SaveChanges();
            Console.WriteLine("insert success");

        }
        private static void InsertProduct()
        {

            Console.WriteLine("enter product detials");
            Console.WriteLine("enter pname");
            string pname = Console.ReadLine();
            Console.WriteLine("enter price");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("eneter cateogry id");
            int id = int.Parse(Console.ReadLine());
            var products = new Product1
            {
                Ptitle = pname,
                Price = price,
                id = id

            };
            mfb.Product1.Add(products);
            mfb.SaveChanges();
            Console.WriteLine("insert success");
        }
    }
}
