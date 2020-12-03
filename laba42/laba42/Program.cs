using System;

namespace laba42
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = '1';
            while (again == '1')
            {

                Console.WriteLine("Число А");
                double A = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Число B");
                double B = Convert.ToDouble(Console.ReadLine());

                double otv1 = A + B;
                Console.WriteLine("Результат сложения" + Convert.ToString(otv1));
                double otv2 = A - B;
                Console.WriteLine("Результат вычитания" + Convert.ToString(otv2));

                double otv3 = A * B;
                Console.WriteLine("Результат умножение" + Convert.ToString(otv3));

                double otv4 = A / B;
                Console.WriteLine("Результат деления" + Convert.ToString(otv4));




















            }

        }
    }
}
