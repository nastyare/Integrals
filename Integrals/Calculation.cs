using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                MessageBox.Show("Количество подотрезков (n) для метода Симпсона должно быть четным.");
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
        public static double SafeFunction(Func<double, double> func, double x)
        {
            try
            {
                return func(x);
            }
            catch (DivideByZeroException)
            {
                // Возвращаем 0 или другое значение, которое считается подходящим
                // В этом случае, если функция вызывает исключение, мы просто игнорируем этот шаг
                return 0;
            }
        }

        public static double RectangleMethod(Func<double, double> func, double a, double b, double exp, out int Opt)
        {
            int n = 1; // Начальное количество разбиений
            double h = (b - a) / n; // Шаг разбиения
            double integral = h * SafeFunction(func, a + h / 2.0); // Начальное приближение интеграла

            // Проверка начальной точности
            if (Math.Abs(integral - SafeFunction(func, a) * (b - a)) <= exp)
            {
                Opt = n;
                return integral;
            }

            double previousIntegral;

            // Основной цикл
            do
            {
                previousIntegral = integral;
                integral = 0.0;
                n *= 2;
                h = (b - a) / n;

                for (int i = 0; i < n; i++)
                {
                    double x_i = a + i * h + h / 2.0;
                    integral += h * SafeFunction(func, x_i);
                }
            } while (Math.Abs(previousIntegral - integral) > exp);

            Opt = n;
            return integral;
        }




        public static double SimpsonMethod(Func<double, double> func, double a, double b, double exp, out int Opt)
        {
            int n = 2; // Начальное количество разбиений, должно быть четным для метода Симпсона
            double h = (b - a) / n;
            double integral = 0.0;
            double previousIntegral = double.MaxValue;

            while (Math.Abs(previousIntegral - integral) > exp)
            {
                previousIntegral = integral;
                integral = 0.0;

                for (int i = 0; i < n; i += 2)
                {
                    double x_i = a + i * h;
                    double x_mid = a + (i + 1) * h;
                    double x_next = a + (i + 2) * h;

                    integral += h / 3.0 * (SafeFunction(func, x_i) + 4 * SafeFunction(func, x_mid) + SafeFunction(func, x_next));
                }

                n *= 2;
                h = (b - a) / n;
            }

            Opt = n / 2;
            return integral;
        }
        public static double TrapezoidalMethod(Func<double, double> func, double a, double b, double exp, out int Opt)
        {
            int n = 1;
            double h = (b - a) / n;
            double integral = h * (SafeFunction(func, a) + SafeFunction(func, b)) / 2.0;

            double previousIntegral = double.MaxValue;

            while (Math.Abs(previousIntegral - integral) > exp)
            {
                previousIntegral = integral;
                integral = 0.0;
                n *= 2;
                h = (b - a) / n;

                for (int i = 0; i < n; i++)
                {
                    double x_i = a + i * h;
                    double x_next = a + (i + 1) * h;

                    integral += h * (SafeFunction(func, x_i) + SafeFunction(func, x_next)) / 2.0;
                }
            }

            Opt = n;
            return integral;
        }
    }
}
