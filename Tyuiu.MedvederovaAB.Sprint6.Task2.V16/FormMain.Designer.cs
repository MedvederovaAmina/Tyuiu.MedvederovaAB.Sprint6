namespace Tyuiu.MedvederovaAB.Sprint6.Task2.V16
{
    partial class Form1
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
            groupBoxTask_MAB = new GroupBox();
            labelTask_MAB = new Label();
            groupBoxResult_MAB = new GroupBox();
            chartFunction_MAB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult_MAB = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            groupBoxInputData_MAB = new GroupBox();
            labelStopStep_MAB = new Label();
            labelStartStep_MAB = new Label();
            textBoxStopStep_MAB = new TextBox();
            textBoxStartStep_MAB = new TextBox();
            buttonHelp_MAB = new Button();
            buttonResult_MAB = new Button();
            groupBoxTask_MAB.SuspendLayout();
            groupBoxResult_MAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MAB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MAB).BeginInit();
            groupBoxInputData_MAB.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_MAB
            // 
            groupBoxTask_MAB.Controls.Add(labelTask_MAB);
            groupBoxTask_MAB.Location = new Point(12, 22);
            groupBoxTask_MAB.Name = "groupBoxTask_MAB";
            groupBoxTask_MAB.Size = new Size(554, 285);
            groupBoxTask_MAB.TabIndex = 0;
            groupBoxTask_MAB.TabStop = false;
            groupBoxTask_MAB.Text = "Условие";
            // 
            // labelTask_MAB
            // 
            labelTask_MAB.AutoSize = true;
            labelTask_MAB.Location = new Point(6, 33);
            labelTask_MAB.Name = "labelTask_MAB";
            labelTask_MAB.Size = new Size(404, 40);
            labelTask_MAB.TabIndex = 0;
            labelTask_MAB.Text = "Протабулировать функцию F(x) на заданном диапазоне.\r\nРезультат сохранить в DataGridView и построить график.";
            // 
            // groupBoxResult_MAB
            // 
            groupBoxResult_MAB.Controls.Add(chartFunction_MAB);
            groupBoxResult_MAB.Controls.Add(dataGridViewResult_MAB);
            groupBoxResult_MAB.Location = new Point(683, 22);
            groupBoxResult_MAB.Name = "groupBoxResult_MAB";
            groupBoxResult_MAB.Size = new Size(648, 410);
            groupBoxResult_MAB.TabIndex = 1;
            groupBoxResult_MAB.TabStop = false;
            groupBoxResult_MAB.Text = "Вывод данных";
            groupBoxResult_MAB.Enter += groupBoxResult_MAB_Enter;
            // 
            // chartFunction_MAB
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_MAB.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_MAB.Legends.Add(legend1);
            chartFunction_MAB.Location = new Point(180, 44);
            chartFunction_MAB.Name = "chartFunction_MAB";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_MAB.Series.Add(series1);
            chartFunction_MAB.Size = new Size(468, 357);
            chartFunction_MAB.TabIndex = 1;
            chartFunction_MAB.Text = "chart1";
            // 
            // dataGridViewResult_MAB
            // 
            dataGridViewResult_MAB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_MAB.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridViewResult_MAB.Location = new Point(6, 44);
            dataGridViewResult_MAB.Name = "dataGridViewResult_MAB";
            dataGridViewResult_MAB.RowHeadersVisible = false;
            dataGridViewResult_MAB.RowHeadersWidth = 51;
            dataGridViewResult_MAB.Size = new Size(168, 357);
            dataGridViewResult_MAB.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // F
            // 
            F.HeaderText = "F";
            F.MinimumWidth = 6;
            F.Name = "F";
            F.Width = 50;
            // 
            // groupBoxInputData_MAB
            // 
            groupBoxInputData_MAB.Controls.Add(labelStopStep_MAB);
            groupBoxInputData_MAB.Controls.Add(labelStartStep_MAB);
            groupBoxInputData_MAB.Controls.Add(textBoxStopStep_MAB);
            groupBoxInputData_MAB.Controls.Add(textBoxStartStep_MAB);
            groupBoxInputData_MAB.Location = new Point(12, 327);
            groupBoxInputData_MAB.Name = "groupBoxInputData_MAB";
            groupBoxInputData_MAB.Size = new Size(349, 96);
            groupBoxInputData_MAB.TabIndex = 2;
            groupBoxInputData_MAB.TabStop = false;
            groupBoxInputData_MAB.Text = "Ввод данных";
            // 
            // labelStopStep_MAB
            // 
            labelStopStep_MAB.AutoSize = true;
            labelStopStep_MAB.Location = new Point(183, 35);
            labelStopStep_MAB.Name = "labelStopStep_MAB";
            labelStopStep_MAB.Size = new Size(94, 20);
            labelStopStep_MAB.TabIndex = 3;
            labelStopStep_MAB.Text = "Конец шага:";
            // 
            // labelStartStep_MAB
            // 
            labelStartStep_MAB.AutoSize = true;
            labelStartStep_MAB.Location = new Point(6, 35);
            labelStartStep_MAB.Name = "labelStartStep_MAB";
            labelStartStep_MAB.Size = new Size(88, 20);
            labelStartStep_MAB.TabIndex = 3;
            labelStartStep_MAB.Text = "Старт шага:";
            // 
            // textBoxStopStep_MAB
            // 
            textBoxStopStep_MAB.Location = new Point(183, 58);
            textBoxStopStep_MAB.Name = "textBoxStopStep_MAB";
            textBoxStopStep_MAB.Size = new Size(160, 27);
            textBoxStopStep_MAB.TabIndex = 3;
            // 
            // textBoxStartStep_MAB
            // 
            textBoxStartStep_MAB.Location = new Point(6, 58);
            textBoxStartStep_MAB.Name = "textBoxStartStep_MAB";
            textBoxStartStep_MAB.Size = new Size(160, 27);
            textBoxStartStep_MAB.TabIndex = 4;
            // 
            // buttonHelp_MAB
            // 
            buttonHelp_MAB.BackColor = SystemColors.MenuHighlight;
            buttonHelp_MAB.Location = new Point(377, 347);
            buttonHelp_MAB.Name = "buttonHelp_MAB";
            buttonHelp_MAB.Size = new Size(115, 76);
            buttonHelp_MAB.TabIndex = 3;
            buttonHelp_MAB.Text = "Справка";
            buttonHelp_MAB.UseVisualStyleBackColor = false;
            buttonHelp_MAB.Click += buttonHelp_MAB_Click;
            // 
            // buttonResult_MAB
            // 
            buttonResult_MAB.BackColor = Color.Green;
            buttonResult_MAB.Location = new Point(510, 347);
            buttonResult_MAB.Name = "buttonResult_MAB";
            buttonResult_MAB.Size = new Size(167, 76);
            buttonResult_MAB.TabIndex = 4;
            buttonResult_MAB.Text = "Выполнить";
            buttonResult_MAB.UseVisualStyleBackColor = false;
            buttonResult_MAB.Click += buttonResult_MAB_Click;
            buttonResult_MAB.MouseDown += buttonResult_MAB_MouseDown;
            buttonResult_MAB.MouseEnter += buttonResult_MAB_MouseEnter;
            buttonResult_MAB.MouseLeave += buttonResult_MAB_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 450);
            Controls.Add(buttonResult_MAB);
            Controls.Add(buttonHelp_MAB);
            Controls.Add(groupBoxInputData_MAB);
            Controls.Add(groupBoxResult_MAB);
            Controls.Add(groupBoxTask_MAB);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxTask_MAB.ResumeLayout(false);
            groupBoxTask_MAB.PerformLayout();
            groupBoxResult_MAB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_MAB).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MAB).EndInit();
            groupBoxInputData_MAB.ResumeLayout(false);
            groupBoxInputData_MAB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MAB;
        private GroupBox groupBoxResult_MAB;
        private Label labelTask_MAB;
        private GroupBox groupBoxInputData_MAB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MAB;
        private DataGridView dataGridViewResult_MAB;
        private Label labelStopStep_MAB;
        private Label labelStartStep_MAB;
        private TextBox textBoxStopStep_MAB;
        private TextBox textBoxStartStep_MAB;
        private Button buttonHelp_MAB;
        private Button buttonResult_MAB;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
    }
}
