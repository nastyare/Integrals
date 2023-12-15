using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Globalization;

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
            string aText = aBox.Text.Replace("pi", Math.PI.ToString());
            string bText = bBox.Text.Replace("pi", Math.PI.ToString());
            string aaText = aBox.Text.Replace("/", Math.PI.ToString());
            string bbText = bBox.Text.Replace("/", Math.PI.ToString());

            if (!double.TryParse(aaText, out a) || !double.TryParse(bbText, out b))
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

            int decimalPlaces = 0;
            double epsCopy = exp;
            while (epsCopy < 1 && decimalPlaces <= 15)
            { // Ограничиваем максимальное количество знаков до 15
                decimalPlaces++;
                epsCopy *= 10;
            }
            string formatSpecifier = "F" + decimalPlaces.ToString();

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
                    resrecBox.Text = rectangleResult.ToString(formatSpecifier, CultureInfo.InvariantCulture); // Используйте динамический формат
                    nrecBox.Text = Opt.ToString();
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
                    restraBox.Text = trapezoidaResult.ToString(formatSpecifier, CultureInfo.InvariantCulture); // Используйте динамический формат
                    ntraBox.Text = Opt.ToString();
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
                    ressimBox.Text = simpsonResult.ToString(formatSpecifier, CultureInfo.InvariantCulture); // Используйте динамический формат
                    nsimBox.Text = Opt.ToString();
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
