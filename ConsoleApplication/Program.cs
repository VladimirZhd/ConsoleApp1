using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Vova";
            string location = "Rexburg, ID";

            Console.WriteLine($"My name is: {name}");
            Console.WriteLine($"My location is: {location}");

            /* Date */
            var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is: {currentDate.ToShortDateString()}");

            /* Christmas */
            var christmasDay = new DateTime(currentDate.Year, 12, 25);
            if (currentDate.Month == 12 && currentDate.Day >= 25)
            {
                christmasDay.AddYears(1);
            }
            var timeSpan = christmasDay - currentDate;
            var numberOfDaysUntilChristmas = timeSpan.Days;
            Console.WriteLine($"Days until Christmas: {numberOfDaysUntilChristmas}");


            /* Code from Textbook */
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter a width (in meters): ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter height (in meters): ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");

            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}