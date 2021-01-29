using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //PascalCase        camelCase
            //case sensitive - büyük küçük harfe duyarlı - C# ve Java
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //bu "void" kullanarak yaptığın işlem, sen bunun sonucunda çıkan "9"u başka bir yerde kullanamıyorsun.
                //productManager.Topla2(3, 6);

            //bu "int" kullanarak yaptığın işlem, void yerine bunu kullanarak sonucu başka yerlerde de kullanabiliyorsun.
                //int toplamaSonucu = productManager.Topla(3, 6);
                //Console.WriteLine(toplamaSonucu * 2);

            //int, bool, double - değer tip
            //class, user interface, diziler - referans tip
            //ref - out

        }
    }
}
