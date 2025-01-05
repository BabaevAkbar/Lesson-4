using System;
using System.Runtime.InteropServices.JavaScript;

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

            // //Все четные числа между двумя числами
            // Console.WriteLine("Введите первое число: ");
            // int firstNum = int.Parse(Console.ReadLine());
            // Console.WriteLine("Введите второе число: ");
            // int secondNum = int.Parse(Console.ReadLine());
            // Console.WriteLine($"Все четные числа меджу {firstNum} - {secondNum}");
            // for(int i = firstNum; i <= secondNum; i++)
            // {
            //     if(i % 2 == 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            //Задание 3
            Console.WriteLine("Выберите фигуру: \n(1)Приямоугольник\n(2)Прямоугольный треугольник\n(3)Равносторонний треугольник\n(4)Ромб");
            int message = int.Parse(Console.ReadLine());
            switch (message)
            {
                case 1:
                {
                    //Прямоугольник
                    int width = 30;
                    int height = 9;
                    for(int i = 1; i <= height; i++)
                    {
                        for(int j = 1; j <= width; j++)
                        {
                            if(i == 1 || i == height)
                            {
                                Console.Write("*");
                            }
                            else if(j != 1)
                            {
                                Console.Write(" ");
                            }
                            if(i != 1 && j == 1 || i != height && j == width)
                            {
                                Console.Write("*");
                            }
                        }
                        Console.Write("\n");
                    }
                    break;
                }
                case 2:
                {
                    //Прямоугольный треугольник
                    int a = 13;
                    for(int i = 1; i <= a; ++i)
                    {
                        for(int j = 1; j <= i; j++)
                        {
                            if(i != a)
                            {
                                if(j == 1 || j == i)
                                {
                                    Console.Write("*");
                                }
                                else if(j > 1 && j < i)
                                {
                                    Console.Write(" ");
                                }
                            }
                            if(i == a)
                            { 
                                Console.Write("*");
                            }
                        }
                        Console.Write("\n");
                    }
                    break;
                }
                case 3:
                {
                    // Равносторонний треугольник
                    int a2 = 15;
                    int b = 29;
                    int center = b/2;
                    for(int i = 1; i <= a2; i++)
                    {
                        for(int j = 1; j <= b; j++)
                        {
                            if(center + i == j || center - i + 2 == j && i != 1 )
                            {
                                Console.Write("*");
                            }
                            else if(center + 1 == j && i == 1)
                            {
                                Console.Write("*");
                            }
                            else if(i == a2)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.Write("\n");
                    }
                    break;
                }
                case 4:
                {
                    // Ромб
                    int a1 = 9;
                    int b1 = 41;
                    int center1 = b1/2;
                    int center2 = a1 / 2;
                    for(int i = 1; i <= a1; i++)
                    {
                        for(int j = 1; j <= b1; j++)
                        {
                            if(i != 1 && i <= center2 && (j == center1 - i * 3 + 3 || j == center1 + i * 3 - 2))
                            {
                                Console.Write("*");
                            }
                            if(i == 1 && j == center1 + 1)
                            {
                                Console.Write("*");
                            }
                            if(i == a1 && j == center1 + 1)
                            {
                                Console.Write("*");
                            }
                            if(i != a1 && i > center2 && (j == center1 + i * 3 - 27 || j == center1 - i * 3 + 29))
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.Write("\n");
                    }
                    break;
                }
                default:
                {
                    Console.WriteLine("Некорректные данные! Пожалуйста введите корректные данные!");
                    break;
                }
            }  
        }
    }
}