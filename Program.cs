namespace CostOfTile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter size of the area in square feet!");
            int area = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width of 1 unit of flooring");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length of 1 unit of flooring");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter cost of 1 unit of flooring");
            int cost = Convert.ToInt32(Console.ReadLine());

            int areaSF = (length* width);
            int unit = (area / areaSF);
            int totalCost = (unit * cost);

            Console.WriteLine("The total cost to cover the area is £" + totalCost);
        }
    }
}