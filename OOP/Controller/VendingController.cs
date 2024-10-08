using Model; 

namespace Controller;
public class VendingController{
    public static void GetChange(int balance){
        int[] denominations = { 1000, 500 ,200 ,100 ,50 , 20 , 10 , 5 ,1};
        foreach(int denomination in denominations){
            if(balance / denomination > 0){
                if(denomination < 50){
                Console.WriteLine($"{denomination} peso coin - {balance / denomination}");
                }else{
                    Console.WriteLine($"{denomination} peso bill - {balance / denomination}");
                }
                balance %= denomination;
            }
        }
    }
}