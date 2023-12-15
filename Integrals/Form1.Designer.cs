namespace Integrals
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.formBox = new System.Windows.Forms.TextBox();
            this.aBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.eBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nrecBox = new System.Windows.Forms.TextBox();
            this.resrecBox = new System.Windows.Forms.TextBox();
            this.rectangleBox = new System.Windows.Forms.CheckBox();
            this.simpsonBox = new System.Windows.Forms.CheckBox();
            this.trapezoidaBox = new System.Windows.Forms.CheckBox();
            this.nsimBox = new System.Windows.Forms.TextBox();
            this.ressimBox = new System.Windows.Forms.TextBox();
            this.ntraBox = new System.Windows.Forms.TextBox();
            this.restraBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // рассчитатьToolStripMenuItem
            // 
            this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
            this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
            this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "∫";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(318, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "e = ";
            // 
            // formBox
            // 
            this.formBox.Location = new System.Drawing.Point(91, 67);
            this.formBox.Name = "formBox";
            this.formBox.Size = new System.Drawing.Size(100, 22);
            this.formBox.TabIndex = 5;
            this.formBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(50, 90);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(23, 22);
            this.aBox.TabIndex = 6;
            this.aBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(50, 42);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(23, 22);
            this.bBox.TabIndex = 7;
            // 
            // eBox
            // 
            this.eBox.Location = new System.Drawing.Point(376, 67);
            this.eBox.Name = "eBox";
            this.eBox.Size = new System.Drawing.Size(100, 22);
            this.eBox.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(34, 278);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(928, 340);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кол-во разбиений:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Значение интеграла:";
            // 
            // nrecBox
            // 
            this.nrecBox.Location = new System.Drawing.Point(278, 169);
            this.nrecBox.Name = "nrecBox";
            this.nrecBox.ReadOnly = true;
            this.nrecBox.Size = new System.Drawing.Size(100, 22);
            this.nrecBox.TabIndex = 12;
            // 
            // resrecBox
            // 
            this.resrecBox.Location = new System.Drawing.Point(278, 219);
            this.resrecBox.Name = "resrecBox";
            this.resrecBox.ReadOnly = true;
            this.resrecBox.Size = new System.Drawing.Size(100, 22);
            this.resrecBox.TabIndex = 13;
            // 
            // rectangleBox
            // 
            this.rectangleBox.AutoSize = true;
            this.rectangleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rectangleBox.Location = new System.Drawing.Point(204, 130);
            this.rectangleBox.Name = "rectangleBox";
            this.rectangleBox.Size = new System.Drawing.Size(237, 24);
            this.rectangleBox.TabIndex = 14;
            this.rectangleBox.Text = "метод прямоугольников";
            this.rectangleBox.UseVisualStyleBackColor = true;
            // 
            // simpsonBox
            // 
            this.simpsonBox.AutoSize = true;
            this.simpsonBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpsonBox.Location = new System.Drawing.Point(482, 130);
            this.simpsonBox.Name = "simpsonBox";
            this.simpsonBox.Size = new System.Drawing.Size(173, 24);
            this.simpsonBox.TabIndex = 15;
            this.simpsonBox.Text = "метод Симпсона";
            this.simpsonBox.UseVisualStyleBackColor = true;
            // 
            // trapezoidaBox
            // 
            this.trapezoidaBox.AutoSize = true;
            this.trapezoidaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trapezoidaBox.Location = new System.Drawing.Point(792, 130);
            this.trapezoidaBox.Name = "trapezoidaBox";
            this.trapezoidaBox.Size = new System.Drawing.Size(170, 24);
            this.trapezoidaBox.TabIndex = 16;
            this.trapezoidaBox.Text = "метод трапеций";
            this.trapezoidaBox.UseVisualStyleBackColor = true;
            // 
            // nsimBox
            // 
            this.nsimBox.Location = new System.Drawing.Point(521, 169);
            this.nsimBox.Name = "nsimBox";
            this.nsimBox.ReadOnly = true;
            this.nsimBox.Size = new System.Drawing.Size(100, 22);
            this.nsimBox.TabIndex = 17;
            // 
            // ressimBox
            // 
            this.ressimBox.Location = new System.Drawing.Point(521, 219);
            this.ressimBox.Name = "ressimBox";
            this.ressimBox.ReadOnly = true;
            this.ressimBox.Size = new System.Drawing.Size(100, 22);
            this.ressimBox.TabIndex = 18;
            // 
            // ntraBox
            // 
            this.ntraBox.Location = new System.Drawing.Point(830, 169);
            this.ntraBox.Name = "ntraBox";
            this.ntraBox.ReadOnly = true;
            this.ntraBox.Size = new System.Drawing.Size(100, 22);
            this.ntraBox.TabIndex = 19;
            // 
            // restraBox
            // 
            this.restraBox.Location = new System.Drawing.Point(830, 221);
            this.restraBox.Name = "restraBox";
            this.restraBox.ReadOnly = true;
            this.restraBox.Size = new System.Drawing.Size(100, 22);
            this.restraBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(539, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "n = ";
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(590, 69);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(100, 22);
            this.nBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "dx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 614);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.restraBox);
            this.Controls.Add(this.ntraBox);
            this.Controls.Add(this.ressimBox);
            this.Controls.Add(this.nsimBox);
            this.Controls.Add(this.trapezoidaBox);
            this.Controls.Add(this.simpsonBox);
            this.Controls.Add(this.rectangleBox);
            this.Controls.Add(this.resrecBox);
            this.Controls.Add(this.nrecBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.eBox);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.formBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox formBox;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.TextBox eBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nrecBox;
        private System.Windows.Forms.TextBox resrecBox;
        private System.Windows.Forms.CheckBox rectangleBox;
        private System.Windows.Forms.CheckBox simpsonBox;
        private System.Windows.Forms.CheckBox trapezoidaBox;
        private System.Windows.Forms.TextBox nsimBox;
        private System.Windows.Forms.TextBox ressimBox;
        private System.Windows.Forms.TextBox ntraBox;
        private System.Windows.Forms.TextBox restraBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Label label2;
    }
}

