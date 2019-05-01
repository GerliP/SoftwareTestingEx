using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyConverter
{
    public class Menu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Please select conversion option: ");
            Console.WriteLine("1. USD to EUR");
            Console.WriteLine("2. EUR to USD");
            Console.WriteLine("3. USD to DKK");
            Console.WriteLine("4. DKK to USD");
        }

        public int GetMenuSelection()
        {
            int menuSelection = (int)(Console.ReadKey().KeyChar);
            return menuSelection;
        }

        public int EnterAmount()
        {
            Console.WriteLine("\nEnter the amount you would like to convert: ");
            int enteredAmount = Convert.ToInt32(Console.ReadLine());
            return enteredAmount;
        }

        public double Converter(int selection, int amountToBeConverted)
        {

            switch (selection)
            {
                case 1:
                    double rate = 0.89;
                    double result = amountToBeConverted * rate;
                    Console.WriteLine(amountToBeConverted + " USD is " + result + " EUR");
                    return result; 
                case 2:
                    rate = 1.12;
                    result = amountToBeConverted * rate;
                    Console.WriteLine(amountToBeConverted + " EUR is " + result + " USD");
                    return result;
                case 3:
                    rate = 6.65;
                    result = amountToBeConverted * rate;
                    Console.WriteLine(amountToBeConverted + " USD is " + result + " DKK");
                    return result;
                default:
                    rate = 0.15;
                    result = amountToBeConverted * rate;
                    Console.WriteLine(amountToBeConverted + " DKK is " + result + " USD");
                    return result;
            }
        }
    }
}
