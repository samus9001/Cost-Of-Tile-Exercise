namespace CostOfTile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constant decimal value for the average cost of labour rate per 20 square foot
            const decimal labourSF = 20;
            //constant decimal value for the average cost of labour rate per hour
            const decimal labourPH = 86;
            //value of pi
            double pi = 3.14159;


            Console.WriteLine("What is the shape of the room? Please input one of the following: rectangle, circle, triangle");
            string UserInput = Console.ReadLine();

            if (UserInput == "rectangle")
            {
                //user is prompted to enter a decimal value for width, length, and flooring cost per square foot
                Console.WriteLine("Enter the width of the room flooring");
                decimal width = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter the length of the room flooring");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter the cost of flooring per square foot");
                decimal cost = Convert.ToDecimal(Console.ReadLine());

                //formula to calculate the square foot area of a rectangle
                decimal rectangleAreaSF = (length * width);

                //formula to calculate the cost of flooring
                decimal flooringCost = (rectangleAreaSF * cost);

                //formula to calculate the total labour cost
                decimal labourCost = (rectangleAreaSF / labourSF) * labourPH;

                //outputs the total cost to the user
                Console.WriteLine($"The total cost to cover the flooring for the room is £{flooringCost + labourCost}");
            }

            if (UserInput == "circle")
            {
                //user is prompted to enter a decimal value for the radius of the circle and flooring cost per square foot
                Console.WriteLine("Enter the radius of the room flooring");
                decimal radius = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter the cost of flooring per square foot");
                decimal cost = Convert.ToDecimal(Console.ReadLine());

                //calculate the square of the radius
                decimal radiusSquared = radius * radius;

                //convert the double value of pi to a decimal value
                decimal piDecimal = Convert.ToDecimal(pi);

                //formula to calculate the square foot area of a circle
                decimal circleAreaSF = (piDecimal * radiusSquared);

                //formula to calculate the cost of flooring
                decimal flooringCost = (circleAreaSF * cost);

                //formula to calculate the total labourCost
                decimal labourCost = (circleAreaSF / labourSF) * labourPH;

                //outputs the total cost to the user
                Console.WriteLine($"The total cost to cover the flooring for the room is £{flooringCost + labourCost}");
            }

            if (UserInput == "triangle")
            {
                //user is prompted to enter a decimal value for base length, height, and flooring cost per square foot
                Console.WriteLine("Enter the base length of the room flooring");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter the height of the room flooring");
                decimal height = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter the cost of flooring per square foot");
                decimal cost = Convert.ToDecimal(Console.ReadLine());

                //formula to calculate the square foot area of a triangle
                decimal triangleAreaSF = ((1.0m / 2.0m) * length * height);

                //formula to calculate the cost of flooring
                decimal flooringCost = (triangleAreaSF * cost);

                //formula to calculate the total labourCost
                decimal labourCost = (triangleAreaSF / labourSF) * labourPH;

                //outputs the total cost to the user
                Console.WriteLine($"The total cost to cover the flooring for the room is £{flooringCost + labourCost}");
            }
        }
    }
}