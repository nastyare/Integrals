using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrals
{
    internal class CalculationThroughN
    {

        public static double RectangleMethod(Func<double, double> function, double a, double b, double n)
        {
            double h = (b - a) / n;
            double Recresult = 0;

            for (int i = 0; i < n; i++)
            {
                double xi = a + i * h;
                double f_x = function(xi);
                Recresult += f_x;
            }

            Recresult *= h; // Перемножение на h происходит только один раз после цикла
            return Recresult;
        }
        public static double SimpsonMethod(Func<double, double> function, double a, double b, int n)
        {
            if (n % 2 != 0)
            {
                throw new ArgumentException("Количество подотрезков (n) должно быть четным.");
            }

            double h = (b - a) / n;
            double result = function(a) + function(b);

            for (int i = 1; i < n; i++)
            {
                double xi = a + i * h;

                if (i % 2 == 0)
                {
                    result += 2 * function(xi);
                }
                else
                {
                    result += 4 * function(xi);
                }
            }

            result *= h / 3;
            return result;
        }

        public static double TrapezoidalMethod(Func<double, double> function, double a, double b, int n)
        {
            double h = (b - a) / n;
            double result = (function(a) + function(b)) / 2;

            for (int i = 1; i < n; i++)
            {
                double xi = a + i * h;
                result += function(xi);
            }

            result *= h;
            return result;
        }
    }

    internal class CalculationExp
    {
        public static double RectangleMethod(Func<double, double> func, double a, double b, double exp, out int Opt)
        {
            int n = 1; // Начальное количество разбиений
            double h = (b - a) / n; // Шаг разбиения
            double integral = 0.0;
            double previousIntegral = double.MaxValue;

            while (Math.Abs(previousIntegral - integral) > exp)
            {
                previousIntegral = integral;
                integral = 0.0;

                for (int i = 0; i < n; i++)
                {
                    double x_i = a + i * h; //double x_i = a + i * h + h / 2.0; 
                    integral += h * func(x_i); // Площадь текущего прямоугольника
                }

                n *= 2; // Удвоение числа разбиений
                h = (b - a) / n; // Пересчет шага
            }
            Opt = n / 2;

            return integral;
        }
        public static double SimpsonMethod(Func<double, double> func, double a, double b, double exp, out int Opt)
        {
            int n = 1; // Начальное количество разбиений
            double h = (b - a) / n; // Шаг разбиения
            double integral = 0.0;
            double previousIntegral = double.MaxValue;

            while (Math.Abs(previousIntegral - integral) > exp)
            {
                previousIntegral = integral;
                integral = 0.0;

                for (int i = 0; i < n; i++)
                {
                    double x_i = a + i * h; // Левая граница текущего интервала
                    double x_next = a + (i + 1) * h; // Правая граница текущего интервала
                    double x_mid = (x_i + x_next) / 2.0; // Середина текущего интервала

                    integral += h / 6.0 * (func(x_i) + 4 * func(x_mid) + func(x_next)); // Площадь интервала по методу Симпсона
                }

                n *= 2; // Удвоение числа разбиений
                h = (b - a) / n; // Пересчет шага
            }

            Opt = n / 2;

            return integral;
        }


        public static double TrapezoidalMethod(Func<double, double> func, double a, double b, double exp, out int Opt)
        {
            int n = 1; // Начальное количество разбиений
            double h = (b - a) / n; // Шаг разбиения
            double integral = 0.0;
            double previousIntegral = double.MaxValue;

            while (Math.Abs(previousIntegral - integral) > exp)
            {
                previousIntegral = integral;
                integral = 0.0;

                for (int i = 0; i < n; i++)
                {
                    double x_i = a + i * h; // Левая граница текущей трапеции
                    double x_next = a + (i + 1) * h; // Правая граница текущей трапеции

                    integral += h * (func(x_i) + func(x_next)) / 2.0; // Площадь текущей трапеции
                }

                n *= 2; // Удвоение числа разбиений
                h = (b - a) / n; // Пересчет шага
            }
            Opt = n / 2;

            return integral;
        }
    }
}
