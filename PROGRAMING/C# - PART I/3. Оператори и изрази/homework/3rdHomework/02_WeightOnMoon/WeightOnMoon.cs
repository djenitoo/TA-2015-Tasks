using System;

namespace _02_WeightOnMoon
{
    class WeightOnMoon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the weight of the person on the Earth: ");
            double weightOnEarth = double.Parse(Console.ReadLine());

            double weightOnMoon = (weightOnEarth / 100) * 17;       // Divide by 100, to get how much is 1%, then multiply by 17 to get 17% for the Moon

            Console.WriteLine("The weight on the Moon will be: " + weightOnMoon);
        }
    }
}
