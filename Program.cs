using System;

namespace Lesson4
{
    class Lesson4
    {
        static void Main(string[] args)
        {
            // //Задание 1 Сумма всех чисел между двумя числами
            // Console.WriteLine("Введите первое число: ");
            // int firstNum = int.Parse(Console.ReadLine());
            // Console.WriteLine("Введите второе число: ");
            // int secondNum = int.Parse(Console.ReadLine());
            // int result = 0;
            // for(int i = firstNum; i <= secondNum; i++)
            // {
            //     result = result + i;
            // }
            // Console.WriteLine(result);

            // //Задание 2 Все нечетные числа между двумя числами
            // Console.WriteLine("Введите первое число: ");
            // int firstNum = int.Parse(Console.ReadLine());
            // Console.WriteLine("Введите второе число: ");
            // int secondNum = int.Parse(Console.ReadLine());
            // Console.WriteLine($"Все нечетные числа меджу {firstNum} - {secondNum}");
            // for(int i = firstNum; i <= secondNum; i++)
            // {
            //     if(i % 2 != 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            //Все четные числа между двумя числами
            Console.WriteLine("Введите первое число: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"Все четные числа меджу {firstNum} - {secondNum}");
            for(int i = firstNum; i <= secondNum; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}