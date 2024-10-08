using Model;

namespace View;
public class UI{
    public static int ShowMenu(List<Product> products){
        Console.WriteLine("-------Menu-------");

        int i = 0;

        products.ForEach(product => {
            if(product.quantity > 0){
            Console.WriteLine($"[{++i}] - {product.name} {product.price} Pesos(quantity {product.quantity})");
            }
        }); 
        Console.WriteLine("[0] - Exit");
        return InputInt();
    }

    public static int InputInt(){
        int input;
        while(true){
            try{
                input = Convert.ToInt32(Console.ReadLine());
                if(input >= 0){
                return input;
                }else{
                    Console.WriteLine("Try Again");
                }
            }
            catch(Exception e){
                Console.Write("Try Again:");
            }
        }
    }
}