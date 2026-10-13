using System;

namespace homework
{
    public class ClsMath
    {
        public int sum(int[] numbers)
        {
            int result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }

        public int max(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            int result = numbers[0];
            foreach (var number in numbers)
            {
                if (number > result)
                {
                    result = number;
                }
            }
            return result;
        }

        public int min(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            int result = numbers[0];
            foreach (var number in numbers)
            {
                if (number < result)
                {
                    result = number;
                }
            }
            return result;
        }

        public int count(int[] numbers)
        {
            return numbers.Length;
        }

        public double plus(double a, double b) /* начинаю писать double, потому что int не подойдёт для дробных чисел */
        {
            return a + b;
        }

        public double minus(double a, double b)
        {
            return a - b;
        }

        public double multiply(double a, double b)
        {
            return a * b;
        }

        public double divide(double a, double b)
        {
            return a / b;
        }

        public double ostatok(double a, double b)
        {
            return a % b;
        }

        public double factorial(double n) /* Я не помню как считается факториал, пришлось взять готовый из сайта Stack Overflow :(   */
        {
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public double percent(double number, double percent)
        {
            return (number * percent) / 100;
        }

        public double deprecent(double total, double part)
        {
            return (total / part) * 100;
        }
    }
}
