using System;

namespace TopicLinq
{
    public static class PracticeLinq
    {
        public static void Main(string[] args)
        {
            string[] categories = {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = Products.ProductList;

            var q = from c in categories
                    join p in products on c equals p.Category
                    select (Category: c, p.ProductName);

            Console.WriteLine(q.Count());
            //foreach (var v in q)
            //{
            //    Console.WriteLine(v.ProductName + ": " + v.Category);
            //}

            var q2 = from c in categories
                     join p in products on c equals p.Category into ps
                     select (Category: c, Products: ps);

            Console.WriteLine(q2.Count());
            foreach (var v in q2)
            {
                Console.WriteLine(v.Category + ":");
                foreach (var p in v.Products)
                {
                    Console.WriteLine("   " + p.ProductName);
                }
            }
        }

        public static void temp()
        {
            Console.WriteLine("empty");
        }
    }
}