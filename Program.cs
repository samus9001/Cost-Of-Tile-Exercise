namespace CostOfTile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area = 0;
            int width = 0;
            int length = 0;
            int cost = 0;
            int areaSF = 0;
            int unit = 0;
            int totalCost = 0;

            Console.WriteLine("Hello, please enter size of the area in square feet!");
            area = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width of 1 unit of flooring");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length of 1 unit of flooring");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter cost of 1 unit of flooring");
            cost = Convert.ToInt32(Console.ReadLine());

            areaSF = (length* width);
            unit = (area / areaSF);
            totalCost = (unit * cost);

            Console.WriteLine("The total cost to cover the area is £" + totalCost);
        }
    }
}