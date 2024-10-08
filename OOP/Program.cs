using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;
using Controller;
using Model;
using View;

List<Product> products = new List<Product>();
products.Add(new Product("Coke", 45));
products.Add(new Product("Mogu Mogu", 60));
products.Add(new Product("Yakult", 15));

int opt;
do
{
    opt = UI.ShowMenu(products);
    if (opt < 0 || opt > products.Count())
    {
        Console.WriteLine("Invalid Input");
    }
    else if (opt != 0)
    {
          Product p = products[opt - 1];
        if (p.quantity > 0)
        {
          
            int bal = 0;
            Console.WriteLine($"You are tring to buy {p.name} that costs {p.price}.");
            while (bal <= p.price)
            {
                Console.Write($"Insert money: (balance: {bal}) ");
                bal += UI.InputInt();
            }
            VendingController.GetChange(Convert.ToInt32(bal - p.price));
            p.DecreaseQuantity();
        }
        else{
            Console.WriteLine($"{p.name} is out of stock");
        }
    }
} while (opt != 0);
