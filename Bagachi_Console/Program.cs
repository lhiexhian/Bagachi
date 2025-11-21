using System;
using static System.Console;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Bagachi_Console
{
    
    class Program
    {
        public static Random rseed = new Random();
        static void LogIn()
        {
            for (int attmp = 3; attmp > 0; attmp--)
            {
                Clear();
                string username, password;
                WriteLine("==LOG IN==");
                Write(">> Username: ");
                username = ReadLine();
                Write(">> Password: ");
                password = ReadLine();

                if (string.IsNullOrWhiteSpace(username) && string.IsNullOrEmpty(password))
                {
                    WriteLine("Login failed. Please try again.");
                }
                else
                {
                    //Check credentials from database
                    WriteLine("Login successful. Welcome back, " + username + "!");
                    ReadLine(); // Pause before clearing
                    MainMenu();
                    break;
                }
            }

        }
        static string FirstBagachiGen(int seed)
        {
            int bag = ((seed /= 100) + (seed % 100)) % 4;
            if (bag == 4) bag = 2; //to avoid bagachi type 4 for now
            if (bag == 3) bag = 1; //to avoid bagachi type 3 for now
            string BagID = bag.ToString() /*determines the type*/ + ((char)('A' + (seed % 25))) /*determines the ID*/  + (seed % 2).ToString("D2") /*determines the LVL*/ ; //Format: 0A00
            return BagID;
        }
        static string BagachiGen(int seed)
        {
            for (int i = 0; i < (seed/=100); i++) //randomize seed using accSeed first 2 indexes
            {
                seed = rseed.Next(1000, 9999);
            }
            int bag = ((seed /= 100) + (seed % 100)) % 4;
            string BagID = bag.ToString() /*determines the type*/ + ((char)('A' + (seed % 25))) /*determines the ID*/  + (seed % 2).ToString("D2") /*determines the LVL*/ ; //Format: 0A00
            //enter logic (just incase yk) to avoid duplicate bagachi ID from database here
            return BagID;
        }
        static string BagachiType(string petID)
        {
            string temp = petID[0].ToString();
            string type;

            switch (temp)
            {
                case "0":
                    type = "FIGHTER";
                    break;
                case "1":
                    type = "WIZARD";
                    break;
                case "2":
                    type = "THIEF";
                    break;
                case "3":
                    type = "GUARDIAN";
                    break;
                case "4":
                    type = "HEALER";
                    break;
                default:
                    type = "INVALID BAGACHI";
                    break;
            }

            return type;
        }



        static void Register()
        {
            Clear();
            string username, password, email;
            WriteLine("==REGISTER==");
            Write(">> Username: ");
            username = ReadLine();
            Write(">> Password: ");
            password = ReadLine();
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrEmpty(password))
            {
                //Push data to database to create new user
                WriteLine("Registration successful. You can now log in, " + username + "!\n");
                int accSeed = rseed.Next(1000, 9999);
                string bagachiID = FirstBagachiGen(accSeed);

                string bagaType = BagachiType(bagachiID);
                WriteLine(">> Click anywhere to continue...");
                ReadLine(); // Pause before clearing
                Clear();
                WriteLine("Congratsss! Your First Bagachi is: " + bagaType);//replace this line with pushing seed to database, format: 0A00, first number represent bagachi type, second number is for ID last 2 represent level
                string Bcard = Sprites.ShowBagachi(bagachiID); 
                WriteLine(Bcard);
                WriteLine(">> Click anywhere to enter Main Menu...");
                ReadLine(); // Pause before clearing
                Clear();
            }
            else
            {
                WriteLine("Registration failed. Please try again.");
            }
        }

        static void MainMenu()
        {
            Clear();
            //WriteLine("==MAIN MENU==");
            //WriteLine("[1] Option 1");
            //WriteLine("[2] Option 2");
            //WriteLine("[0] Log Out");
            //WriteLine(">> Enter: ");
            //try
            //{
            //    int value = Convert.ToInt32(ReadLine());
            //    switch (value)
            //    {
            //        case 1:
            //            WriteLine("You selected Option 1.");
            //            break;
            //        case 2:
            //            WriteLine("You selected Option 2.");
            //            break;
            //        case 0:
            //            Main(null);
            //            break;
            //        default:
            //            WriteLine("Invalid option. Please try again.");
            //            break;
            //    }
            //}
            //catch
            //{
            //    WriteLine("Invalid input. Please enter a number.");
            //}
        }

        static void Main(string[] args)
        {

            while (true)
            {
                WriteLine("==BAGACHI==");
                WriteLine("[1] Log In");
                WriteLine("[2] Register");
                WriteLine("[0] Exit");
                WriteLine(">> Enter: ");
                int value = Convert.ToInt32(ReadLine());
                switch (value)
                {
                    case 1:
                        LogIn();
                        break;
                    case 2:
                        Register();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine("Invalid option. Please try again.");
                        break;
                }
            }




            //TO DO: attack system, mining, click events
        }
    }
}