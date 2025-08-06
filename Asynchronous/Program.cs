using System;
using System.Threading.Tasks;

class Program
{
    // Simulate cooking food
    static async Task<string> CookFood(string order)
    {
        Console.WriteLine($"Start cooking: {order}...");
        await Task.Delay(3000); // 3 seconds
        return $"Order {order} ready!!";
    }

    // Simulate delivering food
    static async Task<string> DeliverFood(string order)
    {
        Console.WriteLine($"Deliver {order} to customer...");
        await Task.Delay(1000); // 1 second
        return $"Order {order} has been delivered to customer!!";
    }

    // Main process
    static async Task RestaurantFlowOrder(string order)
    {
        try
        {
            Console.WriteLine("Receive Order From Customer...");

            string cookedFood = await CookFood(order);
            Console.WriteLine(cookedFood);

            string deliveredFood = await DeliverFood(order);
            Console.WriteLine(deliveredFood);

            Console.WriteLine("Process finished");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"There is a mistake: {ex.Message}");
        }
    }

    // Entry point
    static async Task Main(string[] args)
    {
        await RestaurantFlowOrder("Pizza");
    }
}
