namespace Tyuiu.MedvederovaAB.Sprint6.Task0.V14
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
            buttonDone_MAB = new Button();
            buttonHelp_MAB = new Button();
            groupBoxUslovie_MAB = new GroupBox();
            label1 = new Label();
            pictureBoxFormula_MAB = new PictureBox();
            groupBoxOutputData_MAB = new GroupBox();
            labelResult_MAB = new Label();
            textBoxResult_MAB = new TextBox();
            groupBoxInputData_MAB = new GroupBox();
            label = new Label();
            textBoxVarX_MAB = new TextBox();
            groupBoxUslovie_MAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_MAB).BeginInit();
            groupBoxOutputData_MAB.SuspendLayout();
            groupBoxInputData_MAB.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_MAB
            // 
            buttonDone_MAB.Location = new Point(639, 390);
            buttonDone_MAB.Name = "buttonDone_MAB";
            buttonDone_MAB.Size = new Size(151, 44);
            buttonDone_MAB.TabIndex = 0;
            buttonDone_MAB.Text = "Выполнить";
            buttonDone_MAB.UseVisualStyleBackColor = true;
            buttonDone_MAB.Click += buttonDone_MAB_Click;
            // 
            // buttonHelp_MAB
            // 
            buttonHelp_MAB.FlatStyle = FlatStyle.Flat;
            buttonHelp_MAB.Location = new Point(574, 390);
            buttonHelp_MAB.Name = "buttonHelp_MAB";
            buttonHelp_MAB.Size = new Size(50, 44);
            buttonHelp_MAB.TabIndex = 1;
            buttonHelp_MAB.Text = "?";
            buttonHelp_MAB.UseVisualStyleBackColor = true;
            buttonHelp_MAB.Click += buttonHelp_MAB_Click;
            // 
            // groupBoxUslovie_MAB
            // 
            groupBoxUslovie_MAB.Controls.Add(label1);
            groupBoxUslovie_MAB.Controls.Add(pictureBoxFormula_MAB);
            groupBoxUslovie_MAB.Location = new Point(12, 12);
            groupBoxUslovie_MAB.Name = "groupBoxUslovie_MAB";
            groupBoxUslovie_MAB.Size = new Size(778, 187);
            groupBoxUslovie_MAB.TabIndex = 2;
            groupBoxUslovie_MAB.TabStop = false;
            groupBoxUslovie_MAB.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(257, 20);
            label1.TabIndex = 1;
            label1.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_MAB
            // 
            pictureBoxFormula_MAB.Image = Properties.Resources._2024_12_07_17_22_52;
            pictureBoxFormula_MAB.Location = new Point(573, 46);
            pictureBoxFormula_MAB.Name = "pictureBoxFormula_MAB";
            pictureBoxFormula_MAB.Size = new Size(172, 81);
            pictureBoxFormula_MAB.TabIndex = 0;
            pictureBoxFormula_MAB.TabStop = false;
            // 
            // groupBoxOutputData_MAB
            // 
            groupBoxOutputData_MAB.Controls.Add(labelResult_MAB);
            groupBoxOutputData_MAB.Controls.Add(textBoxResult_MAB);
            groupBoxOutputData_MAB.Location = new Point(322, 241);
            groupBoxOutputData_MAB.Name = "groupBoxOutputData_MAB";
            groupBoxOutputData_MAB.Size = new Size(239, 130);
            groupBoxOutputData_MAB.TabIndex = 3;
            groupBoxOutputData_MAB.TabStop = false;
            groupBoxOutputData_MAB.Text = "Вывод данных:";
            // 
            // labelResult_MAB
            // 
            labelResult_MAB.AutoSize = true;
            labelResult_MAB.Location = new Point(19, 46);
            labelResult_MAB.Name = "labelResult_MAB";
            labelResult_MAB.Size = new Size(75, 20);
            labelResult_MAB.TabIndex = 1;
            labelResult_MAB.Text = "Результат";
            // 
            // textBoxResult_MAB
            // 
            textBoxResult_MAB.Location = new Point(19, 78);
            textBoxResult_MAB.Name = "textBoxResult_MAB";
            textBoxResult_MAB.Size = new Size(172, 27);
            textBoxResult_MAB.TabIndex = 0;
            // 
            // groupBoxInputData_MAB
            // 
            groupBoxInputData_MAB.Controls.Add(label);
            groupBoxInputData_MAB.Controls.Add(textBoxVarX_MAB);
            groupBoxInputData_MAB.Location = new Point(18, 241);
            groupBoxInputData_MAB.Name = "groupBoxInputData_MAB";
            groupBoxInputData_MAB.Size = new Size(232, 130);
            groupBoxInputData_MAB.TabIndex = 4;
            groupBoxInputData_MAB.TabStop = false;
            groupBoxInputData_MAB.Text = "Ввод данных:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(16, 46);
            label.Name = "label";
            label.Size = new Size(114, 20);
            label.TabIndex = 5;
            label.Text = "Переменная Х:";
            // 
            // textBoxVarX_MAB
            // 
            textBoxVarX_MAB.Location = new Point(16, 78);
            textBoxVarX_MAB.Name = "textBoxVarX_MAB";
            textBoxVarX_MAB.Size = new Size(176, 27);
            textBoxVarX_MAB.TabIndex = 5;
            textBoxVarX_MAB.KeyPress += textBoxVarX_MAB_KeyPress;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxInputData_MAB);
            Controls.Add(groupBoxOutputData_MAB);
            Controls.Add(groupBoxUslovie_MAB);
            Controls.Add(buttonHelp_MAB);
            Controls.Add(buttonDone_MAB);
            Name = "FormMain";
            Text = "Form1";
            groupBoxUslovie_MAB.ResumeLayout(false);
            groupBoxUslovie_MAB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_MAB).EndInit();
            groupBoxOutputData_MAB.ResumeLayout(false);
            groupBoxOutputData_MAB.PerformLayout();
            groupBoxInputData_MAB.ResumeLayout(false);
            groupBoxInputData_MAB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_MAB;
        private Button buttonHelp_MAB;
        private GroupBox groupBoxUslovie_MAB;
        private Label label1;
        private PictureBox pictureBoxFormula_MAB;
        private GroupBox groupBoxOutputData_MAB;
        private GroupBox groupBoxInputData_MAB;
        private Label labelResult_MAB;
        private TextBox textBoxResult_MAB;
        private TextBox textBoxVarX_MAB;
        private Label label;
    }
}
