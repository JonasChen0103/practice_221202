using System;

namespace practice_221202
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter \"WebApp\" or \"MobileApp\".");
            string appType = Console.ReadLine();

            Console.WriteLine("Please enter \"ReadMail\" or \"WriteMail\".");
            string order = Console.ReadLine();

            if (appType == "WebApp")
            {
                App WebApp;
                WebApp = new App("WebApp", "WebApp's description");

                if (order == "ReadMail")
                {
                    Console.WriteLine(WebApp.ReadMail());
                }
                else if (order == "WriteMail")
                {
                    Console.WriteLine(WebApp.WriteMail());
                }
            }
            else if (appType == "MobileApp")
            {
                App MobileApp;
                MobileApp = new App("MobileApp", "MobileApp's description");

                if (order == "ReadMail")
                {
                    Console.WriteLine(MobileApp.ReadMail());
                }
                else if (order == "WriteMail")
                {
                    Console.WriteLine(MobileApp.WriteMail());
                }
            }
            else
            {
                Console.WriteLine("Error.");
            }
        }
    }
}
