namespace Restaurant
{
   public class Coffee : HotBeverage
    {
        public double Caffeine { get; set; }
        private const double DefaultCoffeeMilliliters = 50;
        private const decimal DefaultCoffeePrice = 3.50m;

        public Coffee(string name, double caffeine)
            : base(name, DefaultCoffeePrice, DefaultCoffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }
    }
}
