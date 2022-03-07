using System;

namespace Line_Comparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC3 Comparisions of two lines
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
            Console.WriteLine("Line two length: " + Math.Round(line2, 3));
            Console.WriteLine();

            // using CompareTo method
            int lineStatus = line1.CompareTo(line2);          

            if (lineStatus > 0)
            {
                Console.WriteLine("Line one is greater than line two");
            }
            else if (lineStatus < 0)
            {
                Console.WriteLine("Line two is greater than line one");
            }
            else
            {
                Console.WriteLine("Line one is equal to line two");

            }




        }
    }
}
