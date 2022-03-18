/*Создайте консольный мини-калькулятор, который будет подсчитывать сумму двух чисел.
 Определите интерфейс для функции сложения числа и реализуйте его.
 Дополнительно: добавьте конструкцию Try/Catch/Finally для проверки корректности введённого значения. */

using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculate calculate = new Calculate();
                Console.WriteLine("Введите два числа для подсчёта суммы _ _");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{x} + {y} = " + calculate.GetValues(x, y));

                Console.WriteLine("\tНажмите любую клавишу для выхода из программы ...");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат.");
            }
            catch (Exception)
            {
                Console.WriteLine("Что-то пошло не так ..");
            }
        
        }
    }

    public interface ISum
    {
        double GetValues(double x, double y);
        
    }


    class Calculate : ISum
    {
        public double GetValues(double x, double y)
        {
            return x + y;
        }
    }
   

}