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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методПрямоугольниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методТрапецииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методПараболToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.formBox = new System.Windows.Forms.TextBox();
            this.aBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.eBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.resBox = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методПрямоугольниковToolStripMenuItem,
            this.методТрапецииToolStripMenuItem,
            this.методПараболToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // методПрямоугольниковToolStripMenuItem
            // 
            this.методПрямоугольниковToolStripMenuItem.Name = "методПрямоугольниковToolStripMenuItem";
            this.методПрямоугольниковToolStripMenuItem.Size = new System.Drawing.Size(267, 30);
            this.методПрямоугольниковToolStripMenuItem.Text = "Метод прямоугольника";
            this.методПрямоугольниковToolStripMenuItem.Click += new System.EventHandler(this.методПрямоугольниковToolStripMenuItem_Click);
            // 
            // методТрапецииToolStripMenuItem
            // 
            this.методТрапецииToolStripMenuItem.Name = "методТрапецииToolStripMenuItem";
            this.методТрапецииToolStripMenuItem.Size = new System.Drawing.Size(267, 30);
            this.методТрапецииToolStripMenuItem.Text = "Метод трапеции";
            // 
            // методПараболToolStripMenuItem
            // 
            this.методПараболToolStripMenuItem.Name = "методПараболToolStripMenuItem";
            this.методПараболToolStripMenuItem.Size = new System.Drawing.Size(267, 30);
            this.методПараболToolStripMenuItem.Text = "Метод парабол";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(267, 30);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Формула:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "a = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "b =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "e = ";
            // 
            // formBox
            // 
            this.formBox.Location = new System.Drawing.Point(120, 43);
            this.formBox.Name = "formBox";
            this.formBox.Size = new System.Drawing.Size(100, 22);
            this.formBox.TabIndex = 5;
            this.formBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(83, 74);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(100, 22);
            this.aBox.TabIndex = 6;
            this.aBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(83, 114);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(100, 22);
            this.bBox.TabIndex = 7;
            // 
            // eBox
            // 
            this.eBox.Location = new System.Drawing.Point(83, 151);
            this.eBox.Name = "eBox";
            this.eBox.Size = new System.Drawing.Size(100, 22);
            this.eBox.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(373, 43);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(384, 362);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Оптимальное число разбиений:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Значение интеграла:";
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(247, 245);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(69, 22);
            this.nBox.TabIndex = 12;
            // 
            // resBox
            // 
            this.resBox.Location = new System.Drawing.Point(183, 299);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(100, 22);
            this.resBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.eBox);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.formBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.ToolStripMenuItem методПрямоугольниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методТрапецииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методПараболToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox formBox;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.TextBox eBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.TextBox resBox;
    }
}

