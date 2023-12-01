using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using org.matheval.Functions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Drawing;

namespace Integrals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        static double RectangleMethod(Func<double, double> func, double a, double b, double exp, out int Opt)
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
                    double x_i = a + i * h + h / 2.0; // Середина текущего прямоугольника
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

        double function(double X)
        {
            org.matheval.Expression expression = new org.matheval.Expression(formBox.Text.ToLower());
            expression.Bind("x", X);

            double value = expression.Eval<double>();
            return value;
        }

        private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a, b, exp;
            if (!double.TryParse(aBox.Text, out a) || !double.TryParse(bBox.Text, out b) || !double.TryParse(eBox.Text, out exp))
            {
                throw new ArgumentException("Некорректные значения входных данных");
            }
            if (a >= b)
            {
                throw new ArgumentException("Некорректные границы интервала");
            }
            if (!rectangleBox.Checked && !simpsonBox.Checked && !trapezoidaBox.Checked)
            {
                MessageBox.Show("Не выбран ни один из методов расчёта.");
            }
            this.chart1.Series[0].Points.Clear();
            double x = a;
            double y;
            while (x <= b)
            {
                y = function(x);
                this.chart1.Series[0].Points.AddXY(x, y);
                x += 0.1;
            }
            if (rectangleBox.Checked)
            {
                double rectangleResult = RectangleMethod(function, a, b, exp, out int Opt);//RectangleMethod(function, a, b, n);
                decimal resultAsDecimal = Convert.ToDecimal(rectangleResult);

                // Выводим результат
                resrecBox.Text = $"{resultAsDecimal:F5}";
                nrecBox.Text = $"{Opt}";
            }
            if (simpsonBox.Checked)
            {
                double trapezoidaResult = TrapezoidalMethod(function, a, b, exp, out int Opt);//RectangleMethod(function, a, b, n);
                decimal resultAsDecimal = Convert.ToDecimal(trapezoidaResult);

                // Выводим результат
                ressimBox.Text = $"{resultAsDecimal:F5}";
                nsimBox.Text = $"{Opt}";
            }
            if (trapezoidaBox.Checked)
            {
                double simpsonResult = SimpsonMethod(function, a, b, exp, out int Opt);//RectangleMethod(function, a, b, n);
                decimal resultAsDecimal = Convert.ToDecimal(simpsonResult);

                // Выводим результат
                restraBox.Text = $"{resultAsDecimal:F5}";
                ntraBox.Text = $"{Opt}";
            }
        }       
    }
}
