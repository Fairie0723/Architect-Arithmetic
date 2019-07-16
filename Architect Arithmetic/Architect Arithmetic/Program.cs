using System;


namespace Architect_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalArea = Rect(2500, 1500) + 0.5 * Circle(375) + Triangle(750, 500);
            double totalAreaCost = totalArea * 180;

            Console.WriteLine($"The total cost of the area space {totalArea} is {totalAreaCost} pesos.");
            Console.WriteLine(Math.Round(totalAreaCost, 2));
            Console.ReadLine();

        }
        static double Rect(double length, double width)
        {
            return length * width;

        }
        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
   



        }
    }
    

