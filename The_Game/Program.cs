using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш выбор:");
            Console.WriteLine("1. Камень");
            Console.WriteLine("2. Ножницы");
            Console.WriteLine("3. Бумага");
            Console.WriteLine("0. Выход");
            string choice = "";
            do
            {
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("Ваш выбор: Камень\t-");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Ваш выбор: Ножницы\t-");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Ваш выбор: Бумага\t-");
                            break;
                        }
                    case "0":
                        {
                            Console.WriteLine("До свидания =)");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Некорректный ввод данных");
                            break;
                        }
                }
            } while (choice != "0");
        }
    }
}
