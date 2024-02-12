using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rublesInWallet;
            float dollarsInWallet;
            float exchageCurrencyCount;
            string convertOperator;
            float usdToRub = 90;
            float rubToUsd = 0.011002f;

            Console.WriteLine("Введите баланс рублей: ");
            rublesInWallet = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите баланс долларов: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите необходимую операцию: ");
            Console.WriteLine("1 - Обмен рублей на доллары");
            Console.WriteLine("2 - Обмен долларов на рубли");
            Console.WriteLine("Ваш выбор: ");
            convertOperator = Console.ReadLine();
            switch (convertOperator)
            {
                case "1":
                    Console.WriteLine("Сколько вы хотите обменять рублей ?");
                    exchageCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rublesInWallet >= exchageCurrencyCount)
                    {
                        rublesInWallet -= exchageCurrencyCount;
                        dollarsInWallet += exchageCurrencyCount * rubToUsd;
                        

                    }
                    else
                    {
                        Console.WriteLine("На балансе нет столько средств");
                        Console.WriteLine("На балансе : " + rublesInWallet);

                    }
                    break;
                case "2":
                    Console.WriteLine("Сколько вы хотите обменять долларов ?");
                    exchageCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollarsInWallet >= exchageCurrencyCount)
                    {
                        dollarsInWallet -= exchageCurrencyCount;
                        rublesInWallet += exchageCurrencyCount / usdToRub;
               

                    }
                    else
                    {
                        Console.WriteLine("На балансе нет столько средств");
                        Console.WriteLine("На балансе : " + dollarsInWallet);

                    }
                    break;
                default:
                    Console.WriteLine("Нет такой операции!");
                    break;
            }

            Console.WriteLine("Ваш баланс: " + "$: " + dollarsInWallet + " , " + "r: " + rublesInWallet);
            Console.ReadKey();
        }
    }
}
