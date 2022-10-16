using System;

namespace EKozlov.FinalTestWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int quantityOfElements = random.Next(3, 4);

            string[] inputArray = new string[quantityOfElements];

            Console.WriteLine($"Необходимо ввести {quantityOfElements} значений для формирования массива.");

            for (int i = 0; i < quantityOfElements; i++)
            {
                Console.Write($"Введите {i + 1} значение: ");
                inputArray[i] = Console.ReadLine();
            }

        }
    }
}
