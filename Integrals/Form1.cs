using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using org.matheval.Functions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Drawing;
using System.Linq;

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

        double function(double X)
        {
            org.matheval.Expression expression = new org.matheval.Expression(formBox.Text.ToLower());
            expression.Bind("x", X);

            double value = expression.Eval<double>();
            return value;
        }
        private void AddVerticalLine(ChartArea chartArea, double position, Color color)
        {
            VerticalLineAnnotation verticalLine = new VerticalLineAnnotation();
            verticalLine.AxisX = chartArea.AxisX;
            verticalLine.AxisY = chartArea.AxisY;
            verticalLine.LineColor = color;
            verticalLine.LineWidth = 2; // Adjust the line width as needed
            verticalLine.IsInfinitive = true;
            verticalLine.ClipToChartArea = chartArea.Name;
            verticalLine.AnchorX = position;

            chart1.Annotations.Add(verticalLine);
        }
      

        private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a, b, exp;
            int n;

            if (!double.TryParse(aBox.Text, out a) || !double.TryParse(bBox.Text, out b))
            {
                throw new ArgumentException("Некорректные значения входных данных");
            }

            if (!double.TryParse(eBox.Text, out exp) && !int.TryParse(nBox.Text, out n))
            {
                throw new ArgumentException("Введите корректное значение для точности (e) или числа шагов (n)");
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
            AddVerticalLine(chart1.ChartAreas[0], a, Color.Red); // Change Color as needed
            AddVerticalLine(chart1.ChartAreas[0], b, Color.Red);

            //Метод Прямоугольников
            if (eBox.Focused && rectangleBox.Checked)
            {
                //ЧЕРЕЗ Е
                double rectangleResult = CalculationExp.RectangleMethod(function, a, b, exp, out int Opt);
                decimal resultAsDecimal = Convert.ToDecimal(rectangleResult);

                resrecBox.Text = $"{Math.Abs(resultAsDecimal):F5}";
                nrecBox.Text = $"{Opt}";
            } else
            {
                //ЧЕРЕЗ Н
                int numSteps = int.Parse(nBox.Text);
                double rectangleResult = CalculationThroughN.RectangleMethod(function, a, b, numSteps);
                decimal resultAsDecimal = Convert.ToDecimal(rectangleResult);
                resrecBox.Text = $"{Math.Abs(resultAsDecimal):F5}";
            }

            //Метод Трапеций
            if (eBox.Focused && simpsonBox.Checked)
            {
                //ЧЕРЕЗ Е
                double trapezoidaResult = CalculationExp.TrapezoidalMethod(function, a, b, exp, out int Opt);
                decimal resultAsDecimal = Convert.ToDecimal(trapezoidaResult);

                restraBox.Text = $"{Math.Abs(resultAsDecimal):F5}";
                ntraBox.Text = $"{Opt}";
            } else
            {
                //ЧЕРЕЗ Н
                int numSteps = int.Parse(nBox.Text);
                double trapezoidaResult = CalculationThroughN.TrapezoidalMethod(function, a, b, numSteps);
                decimal resultAsDecimal = Convert.ToDecimal(trapezoidaResult);
                restraBox.Text = $"{Math.Abs(resultAsDecimal):F5}";
            }

            //Метод Симпсона
            if (eBox.Focused && trapezoidaBox.Checked)
            {
                //ЧЕРЕЗ Е
                double simpsonResult = CalculationExp.SimpsonMethod(function, a, b, exp, out int Opt);
                decimal resultAsDecimal = Convert.ToDecimal(simpsonResult);

                ressimBox.Text = $"{Math.Abs(resultAsDecimal):F5}";
                nsimBox.Text = $"{Opt}";
            } else
            {
                //ЧЕРЕЗ Н
                int numSteps = int.Parse(nBox.Text);
                double simpsonResult = CalculationThroughN.SimpsonMethod(function, a, b, numSteps);
                decimal resultAsDecimal = Convert.ToDecimal(simpsonResult);
                ressimBox.Text = $"{Math.Abs(resultAsDecimal):F5}";
            }
        }       
    }
}
