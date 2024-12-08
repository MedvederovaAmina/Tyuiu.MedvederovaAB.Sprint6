namespace Tyuiu.MedvederovaAB.Sprint6.Task5.V23
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelChart_MAB = new Panel();
            chart_MAB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter_MAB = new Splitter();
            panelTask_MAB = new Panel();
            buttonDone_MAB = new Button();
            buttonOpen_MAB = new Button();
            buttonHelp_MAB = new Button();
            groupBoxTask_MAB = new GroupBox();
            label1 = new Label();
            panelResult_MAB = new Panel();
            groupBoxResult_MAB = new GroupBox();
            dataGridViewResult_MAB = new DataGridView();
            panelChart_MAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_MAB).BeginInit();
            panelTask_MAB.SuspendLayout();
            groupBoxTask_MAB.SuspendLayout();
            panelResult_MAB.SuspendLayout();
            groupBoxResult_MAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MAB).BeginInit();
            SuspendLayout();
            // 
            // panelChart_MAB
            // 
            panelChart_MAB.Controls.Add(chart_MAB);
            panelChart_MAB.Controls.Add(splitter_MAB);
            panelChart_MAB.Location = new Point(260, 91);
            panelChart_MAB.Name = "panelChart_MAB";
            panelChart_MAB.Size = new Size(667, 362);
            panelChart_MAB.TabIndex = 0;
            // 
            // chart_MAB
            // 
            chartArea1.Name = "ChartArea1";
            chart_MAB.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_MAB.Legends.Add(legend1);
            chart_MAB.Location = new Point(27, 6);
            chart_MAB.Name = "chart_MAB";
            chart_MAB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_MAB.Series.Add(series1);
            chart_MAB.Size = new Size(600, 347);
            chart_MAB.TabIndex = 1;
            chart_MAB.Text = "chart1";
            // 
            // splitter_MAB
            // 
            splitter_MAB.Location = new Point(0, 0);
            splitter_MAB.Name = "splitter_MAB";
            splitter_MAB.Size = new Size(4, 362);
            splitter_MAB.TabIndex = 0;
            splitter_MAB.TabStop = false;
            // 
            // panelTask_MAB
            // 
            panelTask_MAB.Controls.Add(buttonDone_MAB);
            panelTask_MAB.Controls.Add(buttonOpen_MAB);
            panelTask_MAB.Controls.Add(buttonHelp_MAB);
            panelTask_MAB.Controls.Add(groupBoxTask_MAB);
            panelTask_MAB.Dock = DockStyle.Top;
            panelTask_MAB.Location = new Point(0, 0);
            panelTask_MAB.Name = "panelTask_MAB";
            panelTask_MAB.Size = new Size(927, 91);
            panelTask_MAB.TabIndex = 1;
            // 
            // buttonDone_MAB
            // 
            buttonDone_MAB.BackColor = Color.Green;
            buttonDone_MAB.Location = new Point(755, 17);
            buttonDone_MAB.Name = "buttonDone_MAB";
            buttonDone_MAB.Size = new Size(160, 63);
            buttonDone_MAB.TabIndex = 3;
            buttonDone_MAB.Text = "Выполнить";
            buttonDone_MAB.UseVisualStyleBackColor = false;
            buttonDone_MAB.Click += buttonDone_MAB_Click;
            // 
            // buttonOpen_MAB
            // 
            buttonOpen_MAB.BackColor = SystemColors.HotTrack;
            buttonOpen_MAB.Location = new Point(609, 17);
            buttonOpen_MAB.Name = "buttonOpen_MAB";
            buttonOpen_MAB.Size = new Size(117, 63);
            buttonOpen_MAB.TabIndex = 2;
            buttonOpen_MAB.Text = "Открыть файл";
            buttonOpen_MAB.UseVisualStyleBackColor = false;
            buttonOpen_MAB.Click += buttonOpen_MAB_Click;
            // 
            // buttonHelp_MAB
            // 
            buttonHelp_MAB.BackColor = SystemColors.MenuHighlight;
            buttonHelp_MAB.Location = new Point(469, 17);
            buttonHelp_MAB.Name = "buttonHelp_MAB";
            buttonHelp_MAB.Size = new Size(117, 63);
            buttonHelp_MAB.TabIndex = 1;
            buttonHelp_MAB.Text = "Справка";
            buttonHelp_MAB.UseVisualStyleBackColor = false;
            buttonHelp_MAB.Click += buttonHelp_MAB_Click;
            // 
            // groupBoxTask_MAB
            // 
            groupBoxTask_MAB.Controls.Add(label1);
            groupBoxTask_MAB.Location = new Point(3, 3);
            groupBoxTask_MAB.Name = "groupBoxTask_MAB";
            groupBoxTask_MAB.Size = new Size(432, 82);
            groupBoxTask_MAB.TabIndex = 0;
            groupBoxTask_MAB.TabStop = false;
            groupBoxTask_MAB.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(350, 60);
            label1.TabIndex = 0;
            label1.Text = "Прочитать данные из файла InPutFileTask5V23.txt.\r\nВывести в dataGridView. Дан список из чисел.\r\nВывести все числа, меньше 0.";
            // 
            // panelResult_MAB
            // 
            panelResult_MAB.Controls.Add(groupBoxResult_MAB);
            panelResult_MAB.Dock = DockStyle.Left;
            panelResult_MAB.Location = new Point(0, 91);
            panelResult_MAB.Name = "panelResult_MAB";
            panelResult_MAB.Size = new Size(262, 362);
            panelResult_MAB.TabIndex = 2;
            // 
            // groupBoxResult_MAB
            // 
            groupBoxResult_MAB.Controls.Add(dataGridViewResult_MAB);
            groupBoxResult_MAB.Location = new Point(12, 6);
            groupBoxResult_MAB.Name = "groupBoxResult_MAB";
            groupBoxResult_MAB.Size = new Size(226, 344);
            groupBoxResult_MAB.TabIndex = 1;
            groupBoxResult_MAB.TabStop = false;
            groupBoxResult_MAB.Text = "Вывод данных";
            // 
            // dataGridViewResult_MAB
            // 
            dataGridViewResult_MAB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_MAB.Location = new Point(11, 29);
            dataGridViewResult_MAB.Name = "dataGridViewResult_MAB";
            dataGridViewResult_MAB.RowHeadersWidth = 51;
            dataGridViewResult_MAB.Size = new Size(207, 308);
            dataGridViewResult_MAB.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 453);
            Controls.Add(panelResult_MAB);
            Controls.Add(panelTask_MAB);
            Controls.Add(panelChart_MAB);
            MinimumSize = new Size(945, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            panelChart_MAB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_MAB).EndInit();
            panelTask_MAB.ResumeLayout(false);
            groupBoxTask_MAB.ResumeLayout(false);
            groupBoxTask_MAB.PerformLayout();
            panelResult_MAB.ResumeLayout(false);
            groupBoxResult_MAB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MAB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChart_MAB;
        private Panel panelTask_MAB;
        private Panel panelResult_MAB;
        private Splitter splitter_MAB;
        private GroupBox groupBoxTask_MAB;
        private GroupBox groupBoxResult_MAB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MAB;
        private DataGridView dataGridViewResult_MAB;
        private Button buttonDone_MAB;
        private Button buttonOpen_MAB;
        private Button buttonHelp_MAB;
        private Label label1;
    }
}
