namespace Tyuiu.MedvederovaAB.Sprint6.Task1.V14
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
            groupBoxTask_MAB = new GroupBox();
            labelTask_MAB = new Label();
            groupBoxResult_MAB = new GroupBox();
            labelResult_MAB = new Label();
            textBoxResult_MAB = new TextBox();
            groupBoxInputData_MAB = new GroupBox();
            labelStopStep_MAB = new Label();
            labelStartStep_MAB = new Label();
            textBoxStopStep_MAB = new TextBox();
            textBoxStartStep_MAB = new TextBox();
            buttonHelp_MAB = new Button();
            buttonDone_MAB = new Button();
            groupBoxTask_MAB.SuspendLayout();
            groupBoxResult_MAB.SuspendLayout();
            groupBoxInputData_MAB.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_MAB
            // 
            groupBoxTask_MAB.Controls.Add(labelTask_MAB);
            groupBoxTask_MAB.Location = new Point(14, 25);
            groupBoxTask_MAB.Name = "groupBoxTask_MAB";
            groupBoxTask_MAB.Size = new Size(747, 297);
            groupBoxTask_MAB.TabIndex = 0;
            groupBoxTask_MAB.TabStop = false;
            groupBoxTask_MAB.Text = "Условие";
            // 
            // labelTask_MAB
            // 
            labelTask_MAB.AutoSize = true;
            labelTask_MAB.Location = new Point(7, 23);
            labelTask_MAB.Name = "labelTask_MAB";
            labelTask_MAB.Size = new Size(413, 40);
            labelTask_MAB.TabIndex = 0;
            labelTask_MAB.Text = "Протабулировать функцию F(x) на заданном диапазоне.\r\nРезультат вывести в таблицу.";
            // 
            // groupBoxResult_MAB
            // 
            groupBoxResult_MAB.Controls.Add(labelResult_MAB);
            groupBoxResult_MAB.Controls.Add(textBoxResult_MAB);
            groupBoxResult_MAB.Location = new Point(802, 25);
            groupBoxResult_MAB.Name = "groupBoxResult_MAB";
            groupBoxResult_MAB.Size = new Size(290, 395);
            groupBoxResult_MAB.TabIndex = 1;
            groupBoxResult_MAB.TabStop = false;
            groupBoxResult_MAB.Text = "Вывод данных";
            // 
            // labelResult_MAB
            // 
            labelResult_MAB.AutoSize = true;
            labelResult_MAB.Location = new Point(7, 37);
            labelResult_MAB.Name = "labelResult_MAB";
            labelResult_MAB.Size = new Size(78, 20);
            labelResult_MAB.TabIndex = 1;
            labelResult_MAB.Text = "Результат:";
            // 
            // textBoxResult_MAB
            // 
            textBoxResult_MAB.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_MAB.Location = new Point(7, 60);
            textBoxResult_MAB.Multiline = true;
            textBoxResult_MAB.Name = "textBoxResult_MAB";
            textBoxResult_MAB.ReadOnly = true;
            textBoxResult_MAB.ScrollBars = ScrollBars.Vertical;
            textBoxResult_MAB.Size = new Size(276, 315);
            textBoxResult_MAB.TabIndex = 0;
            // 
            // groupBoxInputData_MAB
            // 
            groupBoxInputData_MAB.Controls.Add(labelStopStep_MAB);
            groupBoxInputData_MAB.Controls.Add(labelStartStep_MAB);
            groupBoxInputData_MAB.Controls.Add(textBoxStopStep_MAB);
            groupBoxInputData_MAB.Controls.Add(textBoxStartStep_MAB);
            groupBoxInputData_MAB.Location = new Point(14, 328);
            groupBoxInputData_MAB.Name = "groupBoxInputData_MAB";
            groupBoxInputData_MAB.Size = new Size(389, 92);
            groupBoxInputData_MAB.TabIndex = 2;
            groupBoxInputData_MAB.TabStop = false;
            groupBoxInputData_MAB.Text = "Ввод данных";
            // 
            // labelStopStep_MAB
            // 
            labelStopStep_MAB.AutoSize = true;
            labelStopStep_MAB.Location = new Point(214, 22);
            labelStopStep_MAB.Name = "labelStopStep_MAB";
            labelStopStep_MAB.Size = new Size(95, 20);
            labelStopStep_MAB.TabIndex = 1;
            labelStopStep_MAB.Text = "Конец шага:";
            // 
            // labelStartStep_MAB
            // 
            labelStartStep_MAB.AutoSize = true;
            labelStartStep_MAB.Location = new Point(7, 23);
            labelStartStep_MAB.Name = "labelStartStep_MAB";
            labelStartStep_MAB.Size = new Size(89, 20);
            labelStartStep_MAB.TabIndex = 1;
            labelStartStep_MAB.Text = "Старт шага:";
            // 
            // textBoxStopStep_MAB
            // 
            textBoxStopStep_MAB.Location = new Point(214, 45);
            textBoxStopStep_MAB.Name = "textBoxStopStep_MAB";
            textBoxStopStep_MAB.Size = new Size(152, 27);
            textBoxStopStep_MAB.TabIndex = 1;
            // 
            // textBoxStartStep_MAB
            // 
            textBoxStartStep_MAB.Location = new Point(7, 45);
            textBoxStartStep_MAB.Name = "textBoxStartStep_MAB";
            textBoxStartStep_MAB.Size = new Size(136, 27);
            textBoxStartStep_MAB.TabIndex = 1;
            // 
            // buttonHelp_MAB
            // 
            buttonHelp_MAB.BackColor = SystemColors.MenuHighlight;
            buttonHelp_MAB.Location = new Point(492, 336);
            buttonHelp_MAB.Name = "buttonHelp_MAB";
            buttonHelp_MAB.Size = new Size(93, 79);
            buttonHelp_MAB.TabIndex = 3;
            buttonHelp_MAB.Text = "Справка";
            buttonHelp_MAB.UseVisualStyleBackColor = false;
            buttonHelp_MAB.Click += buttonHelp_MAB_Click;
            // 
            // buttonDone_MAB
            // 
            buttonDone_MAB.BackColor = Color.Green;
            buttonDone_MAB.Location = new Point(591, 336);
            buttonDone_MAB.Name = "buttonDone_MAB";
            buttonDone_MAB.Size = new Size(170, 79);
            buttonDone_MAB.TabIndex = 4;
            buttonDone_MAB.Text = "Выполнить";
            buttonDone_MAB.UseVisualStyleBackColor = false;
            buttonDone_MAB.Click += buttonDone_MAB_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 450);
            Controls.Add(buttonDone_MAB);
            Controls.Add(buttonHelp_MAB);
            Controls.Add(groupBoxInputData_MAB);
            Controls.Add(groupBoxResult_MAB);
            Controls.Add(groupBoxTask_MAB);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Name = "FormMain";
            Text = "Form1";
            groupBoxTask_MAB.ResumeLayout(false);
            groupBoxTask_MAB.PerformLayout();
            groupBoxResult_MAB.ResumeLayout(false);
            groupBoxResult_MAB.PerformLayout();
            groupBoxInputData_MAB.ResumeLayout(false);
            groupBoxInputData_MAB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MAB;
        private GroupBox groupBoxResult_MAB;
        private GroupBox groupBoxInputData_MAB;
        private TextBox textBoxResult_MAB;
        private Label labelTask_MAB;
        private Label labelResult_MAB;
        private Button buttonHelp_MAB;
        private Button buttonDone_MAB;
        private Label labelStopStep_MAB;
        private Label labelStartStep_MAB;
        private TextBox textBoxStopStep_MAB;
        private TextBox textBoxStartStep_MAB;
    }
}
