using System;
using System.Collections.Generic;

namespace baithicshap
{
    class Program
    {
        static List<Product> listProduct = new List<Product>();

        static void Main(string[] args)
        {
            Product pr1 = new Product("MN001", "Monitor", 38);
            Product pr2 = new Product("C01022", "CPU", 94);
            listProduct.Add(pr1);
            listProduct.Add(pr2);

            while (true)
            {
                Console.WriteLine("vui lòng chọn các mục sau: ");
                Console.WriteLine("======Menu======");
                Console.WriteLine("===========================");
                Console.WriteLine("1. Add product records.");
                Console.WriteLine("2. Display product records.");
                Console.WriteLine("3. Delete product by Id.");
                Console.WriteLine("4. Exit.");

                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        Display();
                        break;
                    case 3:
                        DeleteByID();
                        break;
                    case 4:
                        Environment.Exit(1);
                        Console.WriteLine("bye bye, see you again.");
                        break;
                }
            }
        }

        static void AddProduct()
        {
            Console.WriteLine("=======Add product=========");
            Console.WriteLine("vui lofnh nhập thông tin bên dưới:");
            Console.WriteLine("=====================================");
            Console.WriteLine("ProductID: ");
            string ProductID = Console.ReadLine();
            Console.WriteLine("ProductName: ");
            string ProdctName = Console.ReadLine();
            Console.WriteLine("Price: ");
            int Price = Int32.Parse(Console.ReadLine());
            Product pr = new Product(ProductID, ProdctName, Price);
            listProduct.Add(pr);
        }

        static void Display()
        {
            Console.WriteLine("==========Display============");
            for (int i = 0; i < listProduct.Count; i++)
            {
                Console.WriteLine(listProduct[i].ToString());
            }
        }

        static void DeleteByID()
        {
            Console.WriteLine("==========Delete Product by Id============");
            Console.WriteLine("==========================================");
            Console.WriteLine("nhập ProductID: ");
            string ProductID = Console.ReadLine();
            Product toDelete = listProduct.Find(a => a.ProdctId == ProductID);
            listProduct.Remove(toDelete);
        }
    }
}