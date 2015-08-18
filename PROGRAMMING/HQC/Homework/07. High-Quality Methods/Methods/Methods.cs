namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
            
            return area;
        }

        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Invalid number!");
            }
        }

        public static int FindMaxElement(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("No elements to compare!");
            }

            int maxElement = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        public static void PrintNumberWithFormating(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            } 
            else if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            } 
            else if (format == "r")
            {
              Console.WriteLine("{0,8}", number);
            }
            else
            {
                throw new ArgumentException("Invalid format type!");
            }
        }

        public static double CalculateDistance(
                                        double firstPointX, 
                                        double firstPointY, 
                                        double secondPointX, 
                                        double secondPointY, 
                                        out bool isHorizontal, 
                                        out bool isVertical)
        {
            isHorizontal = firstPointY == secondPointY;
            isVertical = firstPointX == secondPointX;
            
            double horizontalDistance = (secondPointY - firstPointY) * (secondPointY - firstPointY);
            double verticalDistance = (secondPointX - firstPointX) * (secondPointX - firstPointX);
            
            double distance = Math.Sqrt(verticalDistance + horizontalDistance);
            
            return distance;
        }

        public static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToDigit(5));
            
            Console.WriteLine(FindMaxElement(5, -1, 3, 2, 14, 2, 3));
            
            PrintNumberWithFormating(1.3, "f");
            PrintNumberWithFormating(0.75, "%");
            PrintNumberWithFormating(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia";
            peter.DateOfBirth = new DateTime(1992, 3, 17);

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results";
            stella.DateOfBirth = new DateTime(1993, 11, 3);

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
