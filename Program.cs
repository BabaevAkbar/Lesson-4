using System;

namespace Lesson4
{
    class Lesson4
    {
        static void Main(string[] args)
        {
            //Задание1
            Console.WriteLine("Введите первое число: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int secondNum = int.Parse(Console.ReadLine());
            int result = 0;
            for(int i = firstNum; i <= secondNum; i++)
            {
                result = result + i;
            }
                Console.WriteLine(result);
        }
    }
}