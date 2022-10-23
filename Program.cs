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
            // taking input from user
            Console.WriteLine("Enter tthe value of a1: ");
            //converting string to int
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter tthe value of a2: ");
            //converting string to int
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter tthe value of b1: ");
            //converting string to int
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter tthe value of b2: ");
            //converting string to int
            int b2 = int.Parse(Console.ReadLine());
            //calculation for length of line
            double Length_Of_Line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double Length_Of_Line2 = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            Console.WriteLine("length of line1: " + Length_Of_Line1);
            Console.WriteLine("length of line2: " + Length_Of_Line2);
            if (Length_Of_Line1 == Length_Of_Line2)
            {
                Console.WriteLine("length of lines are eqaul");
            }
            else if(Length_Of_Line1 > Length_Of_Line2)
            {
                Console.WriteLine("length of line1 : "+ Length_Of_Line1+" is grater than "+ "length of line2 : " + Length_Of_Line2);
            }
            else if (Length_Of_Line1 < Length_Of_Line2)
            {
                Console.WriteLine("length of line1 : " + Length_Of_Line1 + " is less than " + "length of line2 : " + Length_Of_Line2);
            }
        }
    }
}
