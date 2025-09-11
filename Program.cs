using System;
using static System.Console;

namespace Bagachi
{
    public class Bagachi
    {
        public static string name, species;
        public static int age;
        public double sleep, eat, play;
        public Random rand = new Random();
        public Bagachi(string bagachiName, string bagachiSpecies, int BagAge)
        {
            name = bagachiName;
            species = bagachiSpecies;
            age = BagAge;
            sleep = rand.Next(75);
            eat = rand.Next(75);
            play = rand.Next(75);
        }
        public Bagachi()
        {

            List<string> names = new List<string> { "Luvey", "Forofor", "SinTex", "Dilavni", "John Bag" };
            List<string> speciesList = new List<string> { "Ladybug", "Cicada", "Cricket", "Termite", "Stinkbug" };
            string randomName = names[rand.Next(names.Count)];
            string randomSpecies = speciesList[rand.Next(speciesList.Count)];

            name = randomName;
            species = randomSpecies;
            age = 0;
            sleep = rand.Next(75);
            eat = rand.Next(75);
            play = rand.Next(75);
        }
        public void DisplayStatus()
        {
            WriteLine($"Status of {name}:");
            WriteLine($"Sleep: {sleep}/100");
            WriteLine($"Eat: {eat}/100");
            WriteLine($"Play: {play}/100");
        }
        void Grow()
        {
            age++;
        }
        void PerformAction(string action)
        {
            switch (action.ToLower())
            {
                case "sleep":
                    sleep += 0.5 * rand.Next(1, 10);
                    WriteLine($"{name} is sleeping for {sleep} hours.");
                    break;
                case "eat":
                    eat += 0.5 * rand.Next(1, 5);
                    WriteLine($"{name} is eating. Increases satiety to {eat}/100.");
                    break;
                case "play":
                    play += 0.5 * rand.Next(1, 5);
                    WriteLine($"{name} is playing for {play} hours.");
                    break;
                default:
                    WriteLine("Unknown action.");
                    break;
            }
        }
    }

    class Program
    {
        class WrongInput: FormatException
        {
            public WrongInput(string message) : base(message) { }
        }

        static void WriteBorderedMessage(string message)
        {
            int borderLength = message.Length + 4;
            string border = new string('=', borderLength);
            WriteLine(border);
            WriteLine($"* {message} *");
            WriteLine(border);
        }
        static void WriteBorder()
        {
            WriteLine(new string('=', 40));
        }
        static void Main(string[] args)
        {
            int input = 0;
            Bagachi bagachi = new Bagachi();
            do
            {
                WriteBorderedMessage("Bagachi - Command Line Draft Version");
                WriteLine("Select Action: (0-3)");
                WriteLine("0: Exit");
                WriteLine("1: Create New Bagachi");
                WriteLine("2: Load Existing Bagachi");
                WriteLine("3: Delete Existing Bagachi");
                WriteBorder();
                Write("Enter your choice: ");
                try
                {
                    input = int.Parse(ReadLine());
                    switch (input)
                    {
                        case 0:
                            WriteLine("Exiting Bagachi. Goodbye!");
                            break;
                        case 1:
                            WriteLine("Creating a new Bagachi...");
                            bagachi.DisplayStatus();
                            // Placeholder for creating a new Bagachi
                            break;
                        case 2:
                            WriteLine("Loading an existing Bagachi...");
                            // Placeholder for loading an existing Bagachi
                            break;
                        case 3:
                            WriteLine("Deleting an existing Bagachi...");
                            // Placeholder for deleting an existing Bagachi
                            break;
                        default:
                            WriteLine("Invalid input. Please enter a number between 0 and 3.");
                            break;
                    }
                }
                catch (WrongInput)
                {
                    WriteLine("Invalid input format. Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    WriteLine($"An error occurred: {ex.Message}");
                }
            } while (input != 0);
        }
    }
}