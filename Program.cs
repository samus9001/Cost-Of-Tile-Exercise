using System;

namespace CostOfTile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal LABOUR_SF = 20;
            const decimal LABOUR_PH = 86;
            decimal area = 0;
            decimal flooringCost = 0;
            decimal labourCost = 0;
            decimal totalCost = 0;
            decimal totalCostRounded = 0;

            while (true)
            {
                Console.WriteLine("What is the shape of the room? Please input one of the following: r - rectangle, c - circle, t - triangle");
                string userInput = Console.ReadLine();

                if (userInput != "r" && userInput != "c" && userInput != "t")
                {
                    Console.WriteLine("\nThat is not a valid option\n");
                    continue;
                }

                Console.WriteLine("\nEnter the cost of flooring per square foot");
                decimal cost = Convert.ToDecimal(Console.ReadLine());

                if (userInput == "r")
                {
                    //user is prompted to enter a value for width and length
                    Console.WriteLine("\nEnter the width of the room flooring");
                    decimal width = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("\nEnter the length of the room flooring");
                    decimal length = Convert.ToDecimal(Console.ReadLine());

                    //formula to calculate the square foot area of a rectangle
                    area = (length * width);
                }

                if (userInput == "c")
                {
                    //user is prompted to enter a value for the radius of the circle
                    Console.WriteLine("\nEnter the radius of the room flooring");
                    decimal radius = Convert.ToDecimal(Console.ReadLine());

                    //calculate the radius squared
                    decimal radiusSquared = radius * radius;

                    //formula to calculate the square foot area of a circle
                    area = (decimal)Math.PI * radiusSquared;
                }

                if (userInput == "t")
                {
                    //user is prompted to enter a value for base length and height
                    Console.WriteLine("\nEnter the base length of the room flooring");
                    decimal length = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("\nEnter the height of the room flooring");
                    decimal height = Convert.ToDecimal(Console.ReadLine());

                    //formula to calculate the square foot area of a triangle
                    area = (0.5m * length * height);
                }

                //formula to calculate the cost of flooring
                flooringCost = (area * cost);

                //formula to calculate the total labourCost
                labourCost = (area / LABOUR_SF) * LABOUR_PH;
                totalCost = flooringCost + labourCost;

                //outputs the total cost to the user
                totalCostRounded = Math.Round(totalCost, 2);
                Console.WriteLine($"\nThe total cost to cover the flooring for the room is £{totalCostRounded}");
                break;
            }
        }
    }
}