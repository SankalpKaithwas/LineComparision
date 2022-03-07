using System;

namespace Line_Comparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC2 Equality check for two lines
            Console.WriteLine("Welcome to Line Comparision Computation Program");
            Console.WriteLine();
            Console.WriteLine("Enter the coordinates for first line: ");

            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            double line1 = Math.Sqrt((Math.Pow((x2 - x1), 2)) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Line one length: " + Math.Round(line1, 3));

            Console.WriteLine();
            Console.WriteLine("Enter the coordinates for second line: ");

            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());

            double line2 = Math.Sqrt((Math.Pow((x4 - x3), 2)) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Line second length: " + Math.Round(line2, 3));
            Console.WriteLine("Are both lines equal: " + line1.Equals(line2));


        }
    }
}
