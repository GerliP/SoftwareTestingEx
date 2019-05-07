using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();
            Console.WriteLine(menu.Greeting());
            menu.PrintMenu();
            menu.Converter(menu.GetMenuSelection(), menu.EnterAmount());
            Console.ReadKey();
        }
    }
}
