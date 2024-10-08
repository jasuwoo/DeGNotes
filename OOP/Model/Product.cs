using System.Net.Http.Headers;

namespace Model;

public class Product
{
    public string name { get; set; }
    public double price { get; set; }
    public int quantity { get; set; }

    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
        this.quantity = 5;
    }
    public void DecreaseQuantity(){
        quantity--;
    }
    public void IncreaseQuantity(){
        quantity++;
    }
}
