using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HousePaintingEnriquez
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to House Painting Caculator!");

            // Initialize variables for total square footage and gallons required
            double totalSquareFootage = 0;
            double totalPaintGallons = 0;
            double totalPrimerGallons = 0;

            //Ask the user for the number of rooms in house
            Console.Write("Enter the number of rooms in the house: ");
            int numberOfRooms = int.Parse(Console.ReadLine());

            // This is the process for each rooms
            for (int i = 1; i <= numberOfRooms; i++)
            {
                Console.WriteLine($"\nRoom {i}:");

                //Get dimensions from the user
                Console.Write("Enter the length of the room (in feet): ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("Enter the width of the room (in feet): ");
                double width = double.Parse(Console.ReadLine());


                Console.Write("Enter the height of the room (in feet): ");
                double height = double.Parse(Console.ReadLine());

                //This will calculate the square footage
                double roomSquareFootage = 2 * (length * height + width * height) + length * width;

                //Asks if the user wants to use primer
                Console.Write("Do you want to use primer in this room? (yes/no): ");
                string usePrimerInput = Console.ReadLine().ToLower();
                bool usePrimer = (usePrimerInput == "yes");

                //This asks the user if they want to paint the cieling
                Console.Write("Do you want to paint the ceiling for this room? (yes/no): ");
                string paintCeilingInput = Console.ReadLine().ToLower();
                bool paintCeiling = (paintCeilingInput == "yes");

                //Update the total square footage
                totalSquareFootage += roomSquareFootage;

                //This updates the toal gallons of paint and primer required
                totalPaintGallons += usePrimer ? (roomSquareFootage / 400) : (roomSquareFootage / 400);
                totalPrimerGallons += usePrimer ? (roomSquareFootage / 250) : 0;



                //This section displays all of the results
                Console.WriteLine($"\nThe total square footage is: {totalSquareFootage} square feet");
                Console.WriteLine($"The total paint gallons required would be: {totalPaintGallons} gallons");
                Console.WriteLine($"The total primer gallons needed is: {totalPrimerGallons} gallons");


            }
            // Add this line to keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();


        }
    }
  
}

