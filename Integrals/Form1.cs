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
                throw new Exception("Некорректные значения входных данных");
            }

            if (!double.TryParse(eBox.Text, out exp) && !int.TryParse(nBox.Text, out n))
            {
                MessageBox.Show("Введите корректное значение для точности (e) или числа шагов (n)");
            }
            if (a >= b)
            {
                MessageBox.Show("Некорректные границы интервала");
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
            AddVerticalLine(chart1.ChartAreas[0], a, Color.Red);
            AddVerticalLine(chart1.ChartAreas[0], b, Color.Red);

            //Метод Прямоугольников
            if (rectangleBox.Checked)
            {
                if (!string.IsNullOrEmpty(eBox.Text) && !string.IsNullOrEmpty(nBox.Text))
                {
                    MessageBox.Show("Выберите только один метод (через e или через n)");
                    return;
                }

                if (!string.IsNullOrEmpty(eBox.Text))
                {
                    //ЧЕРЕЗ Е
                    double rectangleResult = CalculationExp.RectangleMethod(function, a, b, exp, out int Opt);
                    //decimal resultAsDecimal = Convert.ToDecimal(rectangleResult);
                    int decimalPlaces = BitConverter.GetBytes(decimal.GetBits((decimal)exp)[3])[2];
                    resrecBox.Text = string.Format($"{{0:F0}}", rectangleResult);

                    //resrecBox.Text = $"{resultAsDecimal:F5}";
                    nrecBox.Text = $"{Opt}";
                }
                else if (!string.IsNullOrEmpty(nBox.Text))
                {
                    //ЧЕРЕЗ Н
                    int numSteps = int.Parse(nBox.Text);
                    double rectangleResult = CalculationThroughN.RectangleMethod(function, a, b, numSteps);
                    decimal resultAsDecimal = Convert.ToDecimal(rectangleResult);
                    resrecBox.Text = $"{resultAsDecimal:F5}";
                }
            }


            //Метод Трапеций
            if (trapezoidaBox.Checked)
            {
                if (!string.IsNullOrEmpty(eBox.Text) && !string.IsNullOrEmpty(nBox.Text))
                {
                    MessageBox.Show("Выберите только один метод (через e или через n)");
                    return;
                }

                if (!string.IsNullOrEmpty(eBox.Text))
                {
                    //ЧЕРЕЗ Е
                    double trapezoidaResult = CalculationExp.TrapezoidalMethod(function, a, b, exp, out int Opt);
                    decimal resultAsDecimal = Convert.ToDecimal(trapezoidaResult);

                    restraBox.Text = $"{resultAsDecimal:F5}";
                    ntraBox.Text = $"{Opt}";
                }
                else if (!string.IsNullOrEmpty(nBox.Text))
                {
                    //ЧЕРЕЗ Н
                    int numSteps = int.Parse(nBox.Text);
                    double trapezoidaResult = CalculationThroughN.TrapezoidalMethod(function, a, b, numSteps);
                    decimal resultAsDecimal = Convert.ToDecimal(trapezoidaResult);
                    restraBox.Text = $"{resultAsDecimal:F5}";
                }
            }

            //Метод Симпсона
            if (simpsonBox.Checked)
            {
                if (!string.IsNullOrEmpty(eBox.Text) && !string.IsNullOrEmpty(nBox.Text))
                {
                    MessageBox.Show("Выберите только один метод (через e или через n)");
                    return;
                }

                if (!string.IsNullOrEmpty(eBox.Text))
                {
                    //ЧЕРЕЗ Е
                    double simpsonResult = CalculationExp.SimpsonMethod(function, a, b, exp, out int Opt);
                    decimal resultAsDecimal = Convert.ToDecimal(simpsonResult);

                    ressimBox.Text = $"{resultAsDecimal:F5}";
                    nsimBox.Text = $"{Opt}";
                }
                else if (!string.IsNullOrEmpty(nBox.Text))
                {
                    //ЧЕРЕЗ Н
                    int numSteps = int.Parse(nBox.Text);
                    double simpsonResult = CalculationThroughN.SimpsonMethod(function, a, b, numSteps);
                    decimal resultAsDecimal = Convert.ToDecimal(simpsonResult);
                    ressimBox.Text = $"{resultAsDecimal:F5}";
                }
            }
        }       
    }
}
