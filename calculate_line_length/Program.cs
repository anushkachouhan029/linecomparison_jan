namespace LineComparisonProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line Comparison Problems");


            int x1, y1, x2, y2;
            Console.Write("Enter x1 co-ordinate of First Line : ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y1 co-ordinate of First Line : ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter x2 co-ordinate First Line : ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y2 co-ordinate of First Line : ");
            y2 = Convert.ToInt32(Console.ReadLine());
            double firstlinelength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"\nLength of First Line is {firstlinelength}");


            int a1, b1, a2, b2;
            Console.Write("Enter a1 co-ordinate of Second Line : ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b1 co-ordinate of Second Line : ");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a2 co-ordinate of Second Line : ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b2 co-ordinate of Second Line : ");
            b2 = Convert.ToInt32(Console.ReadLine());
            double secondlinelength = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            Console.WriteLine($"\nLength of Second Line is {secondlinelength}");

            if (firstlinelength == secondlinelength)
            {
                Console.WriteLine("The two lines are Equal");
            }
            else
            {
                Console.WriteLine("The two lines are Not Equal");
            }
        }
    }
}