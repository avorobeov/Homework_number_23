using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_23
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CommandSumArray = "sum";
            const string CommandExit = "exit";

            bool isExit = false;
            int[] numbers = new int[1];
            string userInput;
            int sumArray = 0;

            Console.WriteLine("Ведите любое число для его добавление в архив\n" +
                              "для подсчёта всех элементов массива ведите команду sum\n" +
                              "для выхода ведите команду exit");

            while (isExit == false)
            {
                Console.Write("Ведите команду: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSumArray:
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            sumArray += numbers[i];
                        }

                        Console.WriteLine($"Сумма всех чисел: {sumArray}");
                        break;

                    case CommandExit:
                        isExit = true;
                        break;

                    default:
                        int[] tempNumbers = new int[numbers.Length + 1];

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            tempNumbers[i] = numbers[i];
                        }

                        tempNumbers[numbers.Length - 1] = Convert.ToInt32(userInput);
                        numbers = tempNumbers;

                        Console.WriteLine($"Мы добавили число {userInput} в массив");
                        break;
                }
            }
        }
    }
}
