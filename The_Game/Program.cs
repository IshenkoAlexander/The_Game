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
        public static string GetResult(string player, string computer)
        {
            if(player == "Камень" && computer == "Ножницы")
            {
                return "Победил игрок";
            }
            else if (player == "Камень" && computer == "Бумага")
            {
                return "Победил компьютер";
            }
            else if (player == "Ножницы" && computer == "Бумага")
            {
                return "Победил игрок";
            }
            else if (player == "Ножницы" && computer == "Камень")
            {
                return "Победил компьютер";
            }
            else if (player == "Бумага" && computer == "Камень")
            {
                return "Победил игрок";
            }
            else if (player == "Бумага" && computer == "Ножницы")
            {
                return "Победил компьютер";
            }
            else
            {
                return "Ничья";
            }
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
                            string computer_run = ComputerMove(rand);
                            Console.WriteLine($"\tВыбор компьютера: {computer_run}");
                            Console.WriteLine($"{GetResult("Камень", computer_run)}");
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Ваш выбор: Ножницы\t-");
                            string computer_run = ComputerMove(rand);
                            Console.WriteLine($"\tВыбор компьютера: {computer_run}");
                            Console.WriteLine($"{GetResult("Ножницы", computer_run)}");
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Ваш выбор: Бумага\t-");
                            string computer_run = ComputerMove(rand);
                            Console.WriteLine($"\tВыбор компьютера: {computer_run}");
                            Console.WriteLine($"{GetResult("Бумага", computer_run)}");
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
                            Console.WriteLine();
                            break;
                        }
                }
            } while (choice != "0");
        }
    }
}

