using System;

namespace HeadFirstGetOriented
{
    class Program
    {


        private static bool MainMenu(Guy Bob, Guy Joe)
        {
          
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Bob GIVE 10 dollars to Joe");
            Console.WriteLine("2) Joe Receive 5 dollares from bob");
            Console.WriteLine("3) Show Cash");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Bob.ReceiveCash(Joe.GiveCash(10));
                    return true;
                case "2":
                    Joe.ReceiveCash(Bob.GiveCash(5));
                    return true;
                case "3":
                    Console.WriteLine(Bob.ShowCash()); 
                    return true;
                case "4":
                    Console.WriteLine("EXIT");
                    return false;
                default:
                    return true;
            }
        }


        static void Main(string[] args)
        {
            Guy Bob = new Guy("Bob",10,50)   ;
            Guy Joe = new Guy("Joe", 10, 50);
            int bank = 100;

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu(Bob,Joe);
            }

            Console.WriteLine("Hello World!");
          
        }
    }
}
