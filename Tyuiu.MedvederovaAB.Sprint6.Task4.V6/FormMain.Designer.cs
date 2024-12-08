namespace Tyuiu.MedvederovaAB.Sprint6.Task4.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            buttonSave_MAB = new Button();
            buttonDone_MAB = new Button();
            buttonHelp_MAB = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBoxStopStep_MAB = new TextBox();
            textBoxStartStep_MAB = new TextBox();
            groupBox3 = new GroupBox();
            textBoxResult_MAB = new TextBox();
            chartFunction_MAB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelStartStep_MAB = new Label();
            labelStopStep_MAB = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MAB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonSave_MAB
            // 
            buttonSave_MAB.BackColor = SystemColors.Highlight;
            buttonSave_MAB.Location = new Point(1237, 12);
            buttonSave_MAB.Name = "buttonSave_MAB";
            buttonSave_MAB.Size = new Size(118, 69);
            buttonSave_MAB.TabIndex = 0;
            buttonSave_MAB.Text = "Сохранить";
            buttonSave_MAB.UseVisualStyleBackColor = false;
            buttonSave_MAB.Click += buttonSave_MAB_Click;
            // 
            // buttonDone_MAB
            // 
            buttonDone_MAB.BackColor = Color.Green;
            buttonDone_MAB.Location = new Point(1096, 12);
            buttonDone_MAB.Name = "buttonDone_MAB";
            buttonDone_MAB.Size = new Size(118, 69);
            buttonDone_MAB.TabIndex = 1;
            buttonDone_MAB.Text = "Выполнить";
            buttonDone_MAB.UseVisualStyleBackColor = false;
            buttonDone_MAB.Click += buttonDone_MAB_Click;
            // 
            // buttonHelp_MAB
            // 
            buttonHelp_MAB.BackColor = SystemColors.ActiveCaption;
            buttonHelp_MAB.Location = new Point(1380, 12);
            buttonHelp_MAB.Name = "buttonHelp_MAB";
            buttonHelp_MAB.Size = new Size(85, 69);
            buttonHelp_MAB.TabIndex = 2;
            buttonHelp_MAB.Text = "Справка";
            buttonHelp_MAB.UseVisualStyleBackColor = false;
            buttonHelp_MAB.Click += buttonHelp_MAB_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(694, 217);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelStopStep_MAB);
            groupBox2.Controls.Add(labelStartStep_MAB);
            groupBox2.Controls.Add(textBoxStopStep_MAB);
            groupBox2.Controls.Add(textBoxStartStep_MAB);
            groupBox2.Location = new Point(772, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 101);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBoxStopStep_MAB
            // 
            textBoxStopStep_MAB.Location = new Point(172, 61);
            textBoxStopStep_MAB.Name = "textBoxStopStep_MAB";
            textBoxStopStep_MAB.Size = new Size(125, 27);
            textBoxStopStep_MAB.TabIndex = 1;
            // 
            // textBoxStartStep_MAB
            // 
            textBoxStartStep_MAB.Location = new Point(24, 61);
            textBoxStartStep_MAB.Name = "textBoxStartStep_MAB";
            textBoxStartStep_MAB.Size = new Size(118, 27);
            textBoxStartStep_MAB.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult_MAB);
            groupBox3.Location = new Point(12, 234);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(483, 295);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBoxResult_MAB
            // 
            textBoxResult_MAB.Location = new Point(11, 35);
            textBoxResult_MAB.Multiline = true;
            textBoxResult_MAB.Name = "textBoxResult_MAB";
            textBoxResult_MAB.ScrollBars = ScrollBars.Vertical;
            textBoxResult_MAB.Size = new Size(342, 369);
            textBoxResult_MAB.TabIndex = 0;
            // 
            // chartFunction_MAB
            // 
            chartArea3.Name = "ChartArea1";
            chartFunction_MAB.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartFunction_MAB.Legends.Add(legend3);
            chartFunction_MAB.Location = new Point(704, 121);
            chartFunction_MAB.Name = "chartFunction_MAB";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartFunction_MAB.Series.Add(series3);
            chartFunction_MAB.Size = new Size(761, 408);
            chartFunction_MAB.TabIndex = 6;
            chartFunction_MAB.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "График функции F(x)";
            chartFunction_MAB.Titles.Add(title3);
            // 
            // labelStartStep_MAB
            // 
            labelStartStep_MAB.AutoSize = true;
            labelStartStep_MAB.Location = new Point(24, 38);
            labelStartStep_MAB.Name = "labelStartStep_MAB";
            labelStartStep_MAB.Size = new Size(88, 20);
            labelStartStep_MAB.TabIndex = 2;
            labelStartStep_MAB.Text = "Старт шага:";
            // 
            // labelStopStep_MAB
            // 
            labelStopStep_MAB.AutoSize = true;
            labelStopStep_MAB.Location = new Point(172, 38);
            labelStopStep_MAB.Name = "labelStopStep_MAB";
            labelStopStep_MAB.Size = new Size(83, 20);
            labelStopStep_MAB.TabIndex = 3;
            labelStopStep_MAB.Text = "Стоп шага:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2024_12_08_16_47_23;
            pictureBox1.Location = new Point(6, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(680, 196);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 538);
            Controls.Add(chartFunction_MAB);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonHelp_MAB);
            Controls.Add(buttonDone_MAB);
            Controls.Add(buttonSave_MAB);
            MinimumSize = new Size(1495, 585);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MAB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSave_MAB;
        private Button buttonDone_MAB;
        private Button buttonHelp_MAB;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxStopStep_MAB;
        private TextBox textBoxStartStep_MAB;
        private TextBox textBoxResult_MAB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MAB;
        private PictureBox pictureBox1;
        private Label labelStopStep_MAB;
        private Label labelStartStep_MAB;
    }
}
