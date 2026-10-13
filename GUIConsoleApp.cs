using System;

namespace homework
{
    public class GUIConsoleApp
    {
        public void Start()
        {
            ClsMath math = new ClsMath();

            while (true) /* бесконечный цикл, прерываем программу через break */
            {
                Console.WriteLine("\nМЕНЮ");
                Console.WriteLine("1 - Операции (Sum, Max, Min, Count)");
                Console.WriteLine("2 - +, -, *, /, %");
                Console.WriteLine("3 - Факториал");
                Console.WriteLine("4 - Найти процент от числа");
                Console.WriteLine("5 - Процент от целого");
                Console.WriteLine("exit - Выйти из программы");
                Console.Write("Введите номер действия или 'exit': ");

                string mode = Console.ReadLine(); /* разбил на разные режимы (mode), до этого был просто выбор из sum, max, min... Но учитывая, что у выборов есть ещё выборы,
                добавл mode (выбор  режимов для счёта) */

                if (mode == "exit")
                {
                    break;
                }

                if (mode == "1") /* наш код с прошлого занятия */
                {
                    Console.Write("Введите количество элементов: ");
                    int lenArray = int.Parse(Console.ReadLine());
                    int[] myNumbers = new int[lenArray];

                    for (int i = 0; i < myNumbers.Length; i++)
                    {
                        Console.Write($"Введите значение элемента {i + 1}: ");
                        myNumbers[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("1 - Показать сумму");
                    Console.WriteLine("2 - Показать максимум");
                    Console.WriteLine("3 - Показать минимум");
                    Console.WriteLine("4 - Показать количество элементов");
                    Console.Write("Введите действие для массива: ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.WriteLine($"Сумма: {math.sum(myNumbers)}");
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine($"Максимум: {math.max(myNumbers)}");
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine($"Минимум: {math.min(myNumbers)}");
                    }
                    else if (choice == "4")
                    {
                        Console.WriteLine($"Количество: {math.count(myNumbers)}");
                    }
                }
                else if (mode == "2") /* новый код для простых оппераций */
                {
                    Console.Write("Введите первое число: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.WriteLine("1 - Сложение");
                    Console.WriteLine("2 - Вычитание");
                    Console.WriteLine("3 - Умножение");
                    Console.WriteLine("4 - Деление");
                    Console.WriteLine("5 - Остаток от деления");
                    Console.Write("Введите номер действия: ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.WriteLine($"Результат: {math.plus(a, b)}");
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine($"Результат: {math.minus(a, b)}");
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine($"Результат: {math.multiply(a, b)}");
                    }
                    else if (choice == "4")
                    {
                        Console.WriteLine($"Результат: {math.divide(a, b)}");
                    }
                    else if (choice == "5")
                    {
                        Console.WriteLine($"Результат: {math.ostatok(a, b)}");
                    }
                }
                else if (mode == "3") /* код факториала */
                {
                    Console.Write("Введите число для вычисления факториала: ");
                    double n = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Факториал: {math.factorial(n)}");
                }
                else if (mode == "4") /* код для процента */
                {
                    Console.Write("Введите число: ");
                    double number = double.Parse(Console.ReadLine());
                    Console.Write("Введите процент: ");
                    double percent = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Результат: {math.percent(number, percent)}");
                }
                else if (mode == "5") /* код для поиска процента от числа */
                {
                    Console.Write("Введите целое число (всего): ");
                    double total = double.Parse(Console.ReadLine());
                    Console.Write("Введите часть от числа: ");
                    double part = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Результат: {math.deprecent(total, part)}%");
                }
            }
        }
    }
}
