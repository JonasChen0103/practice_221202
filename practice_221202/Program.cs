using System;

namespace practice_221202
{
    class Program
    {
        static void Main(string[] args)
        {
            var webApp = new WebApp 
            { 
                Name = "網頁程序", 
                Description = "瀏覽器端" 
            };

            var mobileApp = new MobileApp 
            { 
                Name = "行動程序", 
                Description = "行動端" 
            };
            
            Console.WriteLine(webApp.ReadMail());
            Console.WriteLine(webApp.WriteMail());
            Console.WriteLine(mobileApp.ReadMail());
            Console.WriteLine(mobileApp.WriteMail());
        }
    }
}
