using System;

namespace EKozlov.FinalTestWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // Случайно задаём размер массива (4 или 5 элементов для удобства).

            int quantityOfElements = random.Next(4, 6);

            string[] inputArray = GetInputArray(quantityOfElements);

            string[] resultArray = ModifyArray(inputArray);

            ShowArray(resultArray);
        }

        /// <summary>
        /// Заполняет результирующий массив при соответствии условию.
        /// </summary>
        /// <param name="array">Массив для обработки.</param>
        /// <returns>Итоговый массив после модификации.</returns>
        static string[] ModifyArray(string[] array)
        {
            string[] resultArray = new string[array.Length];
            int indexResult = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    resultArray[indexResult] = array[i];
                    indexResult++;
                }
            }
            return resultArray;
        }

        /// <summary>
        /// Заполнение массива элементами через ввод пользователя.
        /// </summary>
        /// <param name="quantityOfElements">Количество элементов для заполнения.</param>
        /// <returns>Массив, заполненный данными через ввод пользователя.</returns>
        static string[] GetInputArray(int quantityOfElements)
        {
            string[] inputArray = new string[quantityOfElements];

            Console.WriteLine($"Необходимо ввести {quantityOfElements} значений для формирования массива.");

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write($"Введите {i + 1} элемент: ");
                inputArray[i] = Console.ReadLine();
            }
            return inputArray;
        }

        /// <summary>
        /// Вывод элементов массива в консоль.
        /// </summary>
        /// <param name="array">Массив для вывода элементов в консоль.</param>
        static void ShowArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                    Console.Write("Массив элементов, длина которых <= 3 символам:\n");

                Console.Write(array[i] + " ");
            }
        }
    }
}

