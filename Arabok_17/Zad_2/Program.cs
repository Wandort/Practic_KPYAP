using MyShopLibrary;

namespace Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product apple = new Product("Яблоко", 1.99);
            Product banana = new Product("Банан", 0.99);

            ShoppingCart cart = new ShoppingCart();
            cart.AddProduct(apple);
            cart.AddProduct(banana);

            cart.DisplayCart();

            double total = cart.CalculateTotal();
            Console.WriteLine($"Итог: BYN {total}");
        }
    }
}
