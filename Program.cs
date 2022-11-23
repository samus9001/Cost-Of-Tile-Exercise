namespace CostOfTile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the area");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the length of the area");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the cost of per square foot");
            decimal cost = Convert.ToDecimal(Console.ReadLine());

            decimal areaSF = (length * width);
            decimal totalCost = (areaSF * cost);
            Console.WriteLine("The total cost to cover the area is £" + totalCost);
        }
    }
}