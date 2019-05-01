using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.PrintMenu();
            menu.Converter(menu.GetMenuSelection(), menu.EnterAmount());
            Console.ReadKey();
        }
    }
}
