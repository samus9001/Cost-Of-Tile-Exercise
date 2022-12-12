using System;

namespace CostOfTile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal labourSF = 20;
            const decimal labourPH = 86;
            decimal totalCostRounded = 0;
     
            Console.WriteLine("What is the shape of the room? Please input one of the following: rectangle, circle, triangle");
            string UserInput = Console.ReadLine();

            Console.WriteLine("Enter the cost of flooring per square foot");
            decimal cost = Convert.ToDecimal(Console.ReadLine());

            if (UserInput == "rectangle")
            {
                //user is prompted to enter a value for width and length
                Console.WriteLine("Enter the width of the room flooring");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the length of the room flooring");
                double length = Convert.ToDouble(Console.ReadLine());

                //formula to calculate the square foot area of a rectangle
                double rectangleAreaSF = (length * width);
                decimal rectangleAreaSFDecimal = Convert.ToDecimal(rectangleAreaSF);

                //formula to calculate the cost of flooring
                decimal flooringCost = (rectangleAreaSFDecimal * cost);

                //formula to calculate the total labour cost
                decimal labourCost = (rectangleAreaSFDecimal / labourSF) * labourPH;
                decimal totalCost = flooringCost + labourCost;
                totalCostRounded = Math.Round(totalCost, 2);
            }

            if (UserInput == "circle")
            {
                //user is prompted to enter a value for the radius of the circle
                Console.WriteLine("Enter the radius of the room flooring");
                double radius = Convert.ToDouble(Console.ReadLine());

                //calculate the square of the radius
                double radiusSquared = radius * radius;

                //formula to calculate the square foot area of a circle
                double circleAreaSF = (Math.PI * radiusSquared);
                decimal circleAreaSFDecimal = Convert.ToDecimal(circleAreaSF);

                //formula to calculate the cost of flooring
                decimal flooringCost = (circleAreaSFDecimal * cost);

                //formula to calculate the total labourCost
                decimal labourCost = (circleAreaSFDecimal / labourSF) * labourPH;
                decimal totalCost = flooringCost + labourCost;
                totalCostRounded = Math.Round(totalCost, 2);

            }

            if (UserInput == "triangle")
            {
                //user is prompted to enter a value for base length and height
                Console.WriteLine("Enter the base length of the room flooring");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height of the room flooring");
                double height = Convert.ToDouble(Console.ReadLine());

                //formula to calculate the square foot area of a triangle
                double triangleAreaSF = ((1 / 2) * length * height);
                decimal triangleAreaSFDecimal = Convert.ToDecimal(triangleAreaSF);

                //formula to calculate the cost of flooring
                decimal flooringCost = (triangleAreaSFDecimal * cost);

                //formula to calculate the total labourCost
                decimal labourCost = (triangleAreaSFDecimal / labourSF) * labourPH;
                decimal totalCost = flooringCost + labourCost;
                totalCostRounded = Math.Round(totalCost, 2);

            }

            //outputs the total cost to the user
            Console.WriteLine($"The total cost to cover the flooring for the room is £{totalCostRounded}");
        }
    }
}