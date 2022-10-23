using System;
namespace LC1
{
    class program
    {
        static void Main(string[] args)
        {
            // taking input from user
            Console.WriteLine("Enter tthe value of x1: ");
            //converting string to int
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter tthe value of x2: ");
            //converting string to int
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter tthe value of y1: ");
            //converting string to int
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter tthe value of y2: ");
            //converting string to int
            int y2 = int.Parse(Console.ReadLine());
            //calculation for length of line
            double Length_Of_Line = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("length of line: "+Length_Of_Line);
        }
    }
}
