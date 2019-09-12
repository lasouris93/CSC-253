using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 12SEP2019
* CSC 253
* Grace Ross & Nick Zwan
* This program *TODO: ADD PROGRAM DESCRIPTION*
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            // The four arrays
            string[] rooms = { "courtyard", "foyer", "hall", "library", "ballroom" };
            string[] weapons = { "knife", "lead pipe", "wrench", "candlestick" };
            string[] potions = { "health tonic", "strength elixir" };
            string[] treasures = { "ruby red slippers", "Excalibur", "tons of gold" };

            // The two lists
            List<string> items = new List<string>();
            List<string> mobs = new List<string>();

            do
            {
                DisplayMenu();
                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        Console.WriteLine($"Welcome! Here's your map:");
                        // Display the rooms array
                        Array.ForEach(rooms, Console.WriteLine);
                        Console.WriteLine("Enter n to go north or s to go south > ");
                        input = Console.ReadLine();

                        // TODO: FIGURE OUT HOW TO DISPLAY ONLY 1 ROOM FROM THE ROOM ARRAY AFTER THE USER CHOOSES TO GO 'N'
                            // EVENTUALLY MOVE TO ANOTHER METHOD ONCE ^ THAT PART ^ IS FIGURED OUT
                                // WITHOUT USING A LOT OF IF-ELSE STATEMENTS
                        if (input == "n")
                        {
                            // THIS DISPLAYS ALL OF THE ROOMS BUT WE WANT ONE ROOM AFTER INPUT IS RECEIVED FROM USER - NOT ALL OF THE ROOMS
                            for (int index = 0; index < rooms.Length; index++)
                            {
                                Console.WriteLine($"You are now in the {rooms[index]}");
                            }
                        }
                        // TODO: ADD THE 'S' OPTION AND GO BACKWARDS THROUGH THE ROOMS ARRAY
                            // IDEALLY ADD THE 'E' AND 'W' OPTIONS AS WELL
                        break;
                    case "2":
                        // Display the weapons in alphabetical order
                        Array.Sort(weapons);
                        foreach (string weapon in weapons)
                        {
                            Console.WriteLine(weapon);
                        }
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Enter 1, 2 or 3.");
                        break;
                }

            } while (exit == false);

            Console.ReadLine();
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("1. Run game\n2. Display weapons\n3. Exit\nEnter 1, 2 or 3 > ");
        }

    }
}
