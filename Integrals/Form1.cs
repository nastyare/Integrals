using System;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;


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

        

        double function(double x)
        {
            org.matheval.Expression expression = new org.matheval.Expression(formBox.Text.ToLower());
            expression.Bind("x", x);

            decimal value = expression.Eval<decimal>();
            return (double)value;
        }

        public double RectangleMethod(Func<double, double> inputFunction, double a, double b, double n)
        {           
            //Func<double, double> funInt = x => function(x);
            double h = (b - a) / n;
            double xi = a + h / 2;
            double fun = function(xi);
            double result = fun;

            for (int i = 0; i < n; i++)
            {
                double nextxi = xi + h;
                result += function(nextxi);
            }

            result *= h;
            return result;
        }

        public double SimpsonMethod(Func<double, double> function, double a, double b, int n)
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

        public double TrapezoidalMethod(Func<double, double> function, double a, double b, int n)
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

        private void методПрямоугольниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
                double a, b, exp;
                if (!double.TryParse(aBox.Text, out a) || !double.TryParse(bBox.Text, out b) || !double.TryParse(eBox.Text, out exp))
                {
                    throw new ArgumentException("Некорректные значения входных данных");
                }
                if (a >= b)
                {
                    throw new ArgumentException("Некорректные границы интервала");
                }
                int n = 100;
                double result = RectangleMethod(function, a, b, n);

            //проверка на точность
            int k = 10; int i = 0;
            double diiff; 
            do
            {
                ++i;
                diiff = Math.Abs(RectangleMethod(function, a, b, k * i) - RectangleMethod(function, a, b, k * (i + 1)));
            } while (diiff > exp);

                // Выводим результат
                resBox.Text = $"{result}";

            /*} catch
            {
                MessageBox.Show("Некорректная работа программы");
            }*/
        }
    }
}
