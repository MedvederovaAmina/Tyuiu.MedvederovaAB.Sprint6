namespace Tyuiu.MedvederovaAB.Sprint6.Task3.V25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonDone_MAB = new Button();
            groupBoxResult_MAB = new GroupBox();
            labelResult_MAB = new Label();
            textBoxResult = new TextBox();
            groupBoxTask_MAB = new GroupBox();
            dataGridViewTask_MAB = new DataGridView();
            labelTask_MAB = new Label();
            buttonHelp_MAB = new Button();
            groupBoxResult_MAB.SuspendLayout();
            groupBoxTask_MAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_MAB).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_MAB
            // 
            buttonDone_MAB.Location = new Point(902, 380);
            buttonDone_MAB.Name = "buttonDone_MAB";
            buttonDone_MAB.Size = new Size(135, 58);
            buttonDone_MAB.TabIndex = 0;
            buttonDone_MAB.Text = "Выполнить";
            buttonDone_MAB.UseVisualStyleBackColor = true;
            buttonDone_MAB.Click += buttonDone_MAB_Click;
            // 
            // groupBoxResult_MAB
            // 
            groupBoxResult_MAB.Controls.Add(labelResult_MAB);
            groupBoxResult_MAB.Controls.Add(textBoxResult);
            groupBoxResult_MAB.Location = new Point(805, 12);
            groupBoxResult_MAB.Name = "groupBoxResult_MAB";
            groupBoxResult_MAB.Size = new Size(232, 95);
            groupBoxResult_MAB.TabIndex = 1;
            groupBoxResult_MAB.TabStop = false;
            groupBoxResult_MAB.Text = "Вывод данных";
            groupBoxResult_MAB.Enter += groupBoxResult_MAB_Enter;
            // 
            // labelResult_MAB
            // 
            labelResult_MAB.AutoSize = true;
            labelResult_MAB.Location = new Point(22, 29);
            labelResult_MAB.Name = "labelResult_MAB";
            labelResult_MAB.Size = new Size(78, 20);
            labelResult_MAB.TabIndex = 1;
            labelResult_MAB.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(22, 52);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(177, 27);
            textBoxResult.TabIndex = 0;
            // 
            // groupBoxTask_MAB
            // 
            groupBoxTask_MAB.Controls.Add(dataGridViewTask_MAB);
            groupBoxTask_MAB.Controls.Add(labelTask_MAB);
            groupBoxTask_MAB.Location = new Point(14, 12);
            groupBoxTask_MAB.Name = "groupBoxTask_MAB";
            groupBoxTask_MAB.Size = new Size(757, 426);
            groupBoxTask_MAB.TabIndex = 2;
            groupBoxTask_MAB.TabStop = false;
            groupBoxTask_MAB.Text = "Условие";
            // 
            // dataGridViewTask_MAB
            // 
            dataGridViewTask_MAB.AllowUserToDeleteRows = false;
            dataGridViewTask_MAB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask_MAB.Location = new Point(480, 113);
            dataGridViewTask_MAB.Name = "dataGridViewTask_MAB";
            dataGridViewTask_MAB.RowHeadersWidth = 51;
            dataGridViewTask_MAB.Size = new Size(266, 227);
            dataGridViewTask_MAB.TabIndex = 1;
            // 
            // labelTask_MAB
            // 
            labelTask_MAB.AutoSize = true;
            labelTask_MAB.Location = new Point(6, 31);
            labelTask_MAB.Name = "labelTask_MAB";
            labelTask_MAB.Size = new Size(424, 240);
            labelTask_MAB.TabIndex = 0;
            labelTask_MAB.Text = resources.GetString("labelTask_MAB.Text");
            // 
            // buttonHelp_MAB
            // 
            buttonHelp_MAB.Location = new Point(792, 380);
            buttonHelp_MAB.Name = "buttonHelp_MAB";
            buttonHelp_MAB.Size = new Size(104, 58);
            buttonHelp_MAB.TabIndex = 3;
            buttonHelp_MAB.Text = "Справка";
            buttonHelp_MAB.UseVisualStyleBackColor = true;
            buttonHelp_MAB.Click += buttonHelp_MAB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 450);
            Controls.Add(buttonHelp_MAB);
            Controls.Add(groupBoxTask_MAB);
            Controls.Add(groupBoxResult_MAB);
            Controls.Add(buttonDone_MAB);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxResult_MAB.ResumeLayout(false);
            groupBoxResult_MAB.PerformLayout();
            groupBoxTask_MAB.ResumeLayout(false);
            groupBoxTask_MAB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_MAB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_MAB;
        private GroupBox groupBoxResult_MAB;
        private GroupBox groupBoxTask_MAB;
        private Button buttonHelp_MAB;
        private Label labelResult_MAB;
        private TextBox textBoxResult;
        private DataGridView dataGridViewTask_MAB;
        private Label labelTask_MAB;
    }
}
