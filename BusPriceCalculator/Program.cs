namespace BusPriceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    //public static class BusPriceCalculator
    //{
    //    public static int CalculatePrice(int distance)
    //    {
    //        const int initialFee = 2500;
    //        int totalPrice = initialFee;

    //        if (distance <= 100)
    //        {
    //            totalPrice += distance * 10;
    //        }
    //        else if (distance <= 500)
    //        {
    //            totalPrice += 100 * 10; // First 100 km
    //            totalPrice += (distance - 100) * 8; // Remaining km
    //        }
    //        else
    //        {
    //            totalPrice += 100 * 10; // First 100 km
    //            totalPrice += 400 * 8; // Next 400 km
    //            totalPrice += (distance - 500) * 6; // Remaining km
    //        }

    //        return totalPrice;
    //    }
    //}
}
