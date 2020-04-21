using System;

namespace Lab_2_Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string reloop = "y";

            while (reloop == "y")
            {
               
                Console.WriteLine("What is the length of the room?");
                string input = Console.ReadLine();
                double length = double.Parse(input);

                Console.WriteLine("What is the width of the room?");
                string input2 = Console.ReadLine();
                double width = double.Parse(input2);

                Console.WriteLine("What is the height of the room?");
                string input3 = Console.ReadLine();
                double height = double.Parse(input3);


                double volume = length * width * height;
                double area = length * width;
                double perimeter = (length * 2) + (width * 2);

                Console.WriteLine("The perimeter is " + perimeter);
                Console.WriteLine("The area is " + area);
                Console.WriteLine("The Volume is " + volume);

                Console.WriteLine("Contonue? y/n");
                reloop = Console.ReadLine();

            }

        }
    }
}
