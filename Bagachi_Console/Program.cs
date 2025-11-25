using System;
using static System.Console;
using static System.Math;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Threading;

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
                    InitialMenu();
                    break;
                }
            }
        }
        static void InitialMenu()
        {
            Clear();
            string[] menu = new string[3];
            menu[0] = "LOG IN";
            menu[1] = "REGISTER";
            menu[2] = "EXIT";

            int focus = 0;

            while (true)
            {
                //Clear();
                SetCursorPosition(0, 0);
                WriteLine("==BAGACHI==");
                for (int i = 0; i < menu.Length; i++)
                {
                    if (i == focus)
                    {
                        WriteLine($"> {menu[i]} <");
                    }
                    else
                    {
                        WriteLine($"  {menu[i]}  ");
                    }
                }
                WriteLine("\n>>Use UP and DOWN arrow keys to navigate, ENTER for selection.<<");
                var key = ReadKey(true).Key;
                if (key == ConsoleKey.UpArrow)
                {
                    focus = (focus - 1 + menu.Length) % menu.Length;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    focus = (focus + 1) % menu.Length;
                }
                else if (key == ConsoleKey.Enter)
                {
                    switch (focus)
                    {
                        case 0:
                            LogIn();
                            return;
                        case 1:
                            Register();
                            return;
                        case 2:
                            Environment.Exit(0);
                            break;
                    }
                }
                Thread.Sleep(10);
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
        



        static void Register()
        {
            Clear();
            string username, password;
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
                WriteLine(">> Click anywhere to continue...");
                ReadLine(); // Pause before clearing
                Clear();//replace this line with pushing seed to database, format: 0A00, first number represent bagachi type, second number is for ID last 2 represent level
                Bagachi myPet = new Bagachi(bagachiID);
                string display = Sprites.ShowBagachi(myPet);
                WriteLine(display);
                WriteLine(">> Click anywhere to enter Main Menu...");
                ReadLine(); // Pause before clearing
                Clear();
            }
            else
            {
                WriteLine("Registration failed. Please try again.");
            }
        }


        static void Main(string[] args)
        {

            while (true)
            {
                InitialMenu();
            }




            //TO DO: attack system, mining, click events
        }
    }
}