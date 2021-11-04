using System;

namespace homework_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание № 9");

            Console.WriteLine("Введите сумму вклада: ");
            double sum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество месяцев: ");
            int month = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            while (count < month) {
                sum += sum * 0.07;
                count++;
            }

            Console.WriteLine($"Итоговая сумма вклада: {sum}");

        }
    }
}
