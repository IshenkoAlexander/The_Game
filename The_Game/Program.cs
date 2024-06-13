using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_rock_paper_scissors_project
{
    internal class Program
    {
        public static string ComputerMove(Random rnd)
        {
            string str = rnd.Next(1, 4).ToString();
            if (str == "1")
            {
                return "Камень";
            }
            else if (str == "2")
            {
                return "Ножницы";
            }
            else if (str == "3")
            {
                return "Бумага";
            }
            return "";
        }
        static void Main(string[] args)
        {
            Random rand = new Random();

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
                            Console.Write("Ваш выбор: Камень\t-");
                            Console.WriteLine($"\tВыбор компьютера: {ComputerMove(rand)}");
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Ваш выбор: Ножницы\t-");
                            Console.WriteLine($"\tВыбор компьютера: {ComputerMove(rand)}");
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Ваш выбор: Бумага\t-");
                            Console.WriteLine($"\tВыбор компьютера: {ComputerMove(rand)}");
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

