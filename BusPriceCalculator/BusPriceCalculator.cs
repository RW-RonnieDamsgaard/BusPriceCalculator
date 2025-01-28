namespace BusPriceCalculator
{
    public static class BusPriceCalculator
    {
        public static int CalculatePrice(int distance)
        {
            int initialFee = 2500;
            int price = initialFee;

            if (distance <= 100)
            {
                price += distance * 10;
            }
            else if (distance <= 500)
            {
                price += 100 * 10 + (distance - 100) * 8;
            }
            else
            {
                price += 100 * 10 + 400 * 8 + (distance - 500) * 6;
            }

            return price;
        }
    }
}
