using System;
namespace LC4
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
            //calculating status using compareTo method
            int status = Length_Of_Line1.CompareTo(Length_Of_Line2);
            if(status > 0)
            {
                Console.WriteLine("Length of line1: " + Length_Of_Line1 + " is greater than " + " Length of line2: " + Length_Of_Line2);
            }
            else if (status < 0)
            {
                Console.WriteLine("Length of line1: "+Length_Of_Line1 + " is less than " + "Length of line2: " + Length_Of_Line2);
            }
            else 
            {
                Console.WriteLine("Length of line1: " + Length_Of_Line1 + " is eaual to " + "Length of line2: " + Length_Of_Line2);
            }
        }
    }
}
