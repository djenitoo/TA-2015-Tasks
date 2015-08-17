using System;

namespace _18.Garden
{
    class Garden
    {
        static void Main()
        {
            decimal tomatoSeed = decimal.Parse(Console.ReadLine());
            decimal tomatoArea = decimal.Parse(Console.ReadLine());
            
            decimal cucumberSeed = decimal.Parse(Console.ReadLine());
            decimal cucumberArea = decimal.Parse(Console.ReadLine());

            decimal potatoSeed = decimal.Parse(Console.ReadLine());
            decimal potatoArea = decimal.Parse(Console.ReadLine());

            decimal carrotSeed = decimal.Parse(Console.ReadLine());
            decimal carrotArea = decimal.Parse(Console.ReadLine());
            
            decimal cabbageSeed = decimal.Parse(Console.ReadLine());
            decimal cabbageArea = decimal.Parse(Console.ReadLine());
            
            decimal beanSeed = decimal.Parse(Console.ReadLine());

            decimal tomatoCost = 0.5M * tomatoSeed;
            decimal cucumerCost = 0.4M * cucumberSeed;
            decimal potatoCost = 0.25M * potatoSeed;
            decimal carrotCost = 0.6M * carrotSeed;
            decimal cabbageCost = 0.3M * cabbageSeed;
            decimal beanCost = 0.4M * beanSeed;

            decimal totalCost = tomatoCost + cucumerCost + potatoCost + carrotCost + cabbageCost + beanCost;
            Console.WriteLine("Total costs: "+ totalCost);

            decimal beansArea = 250 - (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);

            if (beansArea < 0)
            {
                Console.WriteLine("Insufficient area");
            }

            else if (beansArea == 0)
            {
                Console.WriteLine("No area for beans");
            }

            else
            {
                Console.WriteLine("Beans area: "+beansArea);
            }
        }
    }
}
