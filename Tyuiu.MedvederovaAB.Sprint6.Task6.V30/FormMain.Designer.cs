

namespace Tyuiu.MedvederovaAB.Sprint6.Task6.V30
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelBotton_MAB = new Panel();
            buttonHelp_MAB = new Button();
            buttonDone_MAB = new Button();
            buttonOpenFile_MAB = new Button();
            panelTask_MAB = new Panel();
            groupBoxTask_MAB = new GroupBox();
            labelTask_MAB = new Label();
            panelInputData_MAB = new Panel();
            groupBoxInputData_MAB = new GroupBox();
            textBoxInputData_MAB = new TextBox();
            splitter_MAB = new Splitter();
            panelResult_MAB = new Panel();
            groupBoxResult_MAB = new GroupBox();
            textBoxRsult_MAB = new TextBox();
            openFileDialogTask_MAB = new OpenFileDialog();
            toolTip_MAB = new ToolTip(components);
            panelBotton_MAB.SuspendLayout();
            panelTask_MAB.SuspendLayout();
            groupBoxTask_MAB.SuspendLayout();
            panelInputData_MAB.SuspendLayout();
            groupBoxInputData_MAB.SuspendLayout();
            panelResult_MAB.SuspendLayout();
            groupBoxResult_MAB.SuspendLayout();
            SuspendLayout();
            // 
            // panelBotton_MAB
            // 
            panelBotton_MAB.Controls.Add(buttonHelp_MAB);
            panelBotton_MAB.Controls.Add(buttonDone_MAB);
            panelBotton_MAB.Controls.Add(buttonOpenFile_MAB);
            panelBotton_MAB.Dock = DockStyle.Top;
            panelBotton_MAB.Location = new Point(0, 0);
            panelBotton_MAB.Name = "panelBotton_MAB";
            panelBotton_MAB.Size = new Size(1125, 96);
            panelBotton_MAB.TabIndex = 0;
            // 
            // buttonHelp_MAB
            // 
            buttonHelp_MAB.Image = Properties.Resources.application_form_edit;
            buttonHelp_MAB.Location = new Point(1003, 11);
            buttonHelp_MAB.Name = "buttonHelp_MAB";
            buttonHelp_MAB.Size = new Size(96, 69);
            buttonHelp_MAB.TabIndex = 2;
            toolTip_MAB.SetToolTip(buttonHelp_MAB, "Сведение о программе");
            buttonHelp_MAB.UseVisualStyleBackColor = true;
            buttonHelp_MAB.Click += button3_Click;
            // 
            // buttonDone_MAB
            // 
            buttonDone_MAB.Image = Properties.Resources.book_go1;
            buttonDone_MAB.Location = new Point(152, 12);
            buttonDone_MAB.Name = "buttonDone_MAB";
            buttonDone_MAB.Size = new Size(125, 69);
            buttonDone_MAB.TabIndex = 1;
            toolTip_MAB.SetToolTip(buttonDone_MAB, "Производит поиск в файле вхождений символов\r\nи конкатенирует строки в которых находятся эти символы\r\n");
            buttonDone_MAB.UseVisualStyleBackColor = true;
            buttonDone_MAB.Click += buttonDone_MAB_Click;
            // 
            // buttonOpenFile_MAB
            // 
            buttonOpenFile_MAB.Image = Properties.Resources.book_open;
            buttonOpenFile_MAB.Location = new Point(12, 11);
            buttonOpenFile_MAB.Name = "buttonOpenFile_MAB";
            buttonOpenFile_MAB.Size = new Size(114, 69);
            buttonOpenFile_MAB.TabIndex = 0;
            toolTip_MAB.SetToolTip(buttonOpenFile_MAB, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_MAB.UseVisualStyleBackColor = true;
            buttonOpenFile_MAB.Click += buttonOpenFile_MAB_Click;
            // 
            // panelTask_MAB
            // 
            panelTask_MAB.Controls.Add(groupBoxTask_MAB);
            panelTask_MAB.Dock = DockStyle.Top;
            panelTask_MAB.Location = new Point(0, 96);
            panelTask_MAB.Name = "panelTask_MAB";
            panelTask_MAB.Size = new Size(1125, 112);
            panelTask_MAB.TabIndex = 1;
            // 
            // groupBoxTask_MAB
            // 
            groupBoxTask_MAB.Controls.Add(labelTask_MAB);
            groupBoxTask_MAB.Dock = DockStyle.Fill;
            groupBoxTask_MAB.Location = new Point(0, 0);
            groupBoxTask_MAB.Name = "groupBoxTask_MAB";
            groupBoxTask_MAB.Size = new Size(1125, 112);
            groupBoxTask_MAB.TabIndex = 0;
            groupBoxTask_MAB.TabStop = false;
            groupBoxTask_MAB.Text = "Условие";
            // 
            // labelTask_MAB
            // 
            labelTask_MAB.AutoSize = true;
            labelTask_MAB.Dock = DockStyle.Fill;
            labelTask_MAB.Location = new Point(3, 23);
            labelTask_MAB.Name = "labelTask_MAB";
            labelTask_MAB.Size = new Size(664, 60);
            labelTask_MAB.TabIndex = 0;
            labelTask_MAB.Text = resources.GetString("labelTask_MAB.Text");
            // 
            // panelInputData_MAB
            // 
            panelInputData_MAB.Controls.Add(groupBoxInputData_MAB);
            panelInputData_MAB.Controls.Add(splitter_MAB);
            panelInputData_MAB.Dock = DockStyle.Left;
            panelInputData_MAB.Location = new Point(0, 208);
            panelInputData_MAB.Name = "panelInputData_MAB";
            panelInputData_MAB.Size = new Size(518, 373);
            panelInputData_MAB.TabIndex = 2;
            // 
            // groupBoxInputData_MAB
            // 
            groupBoxInputData_MAB.Controls.Add(textBoxInputData_MAB);
            groupBoxInputData_MAB.Dock = DockStyle.Fill;
            groupBoxInputData_MAB.Location = new Point(4, 0);
            groupBoxInputData_MAB.Name = "groupBoxInputData_MAB";
            groupBoxInputData_MAB.Size = new Size(514, 373);
            groupBoxInputData_MAB.TabIndex = 1;
            groupBoxInputData_MAB.TabStop = false;
            groupBoxInputData_MAB.Text = "Ввод данных";
            // 
            // textBoxInputData_MAB
            // 
            textBoxInputData_MAB.Dock = DockStyle.Fill;
            textBoxInputData_MAB.Location = new Point(3, 23);
            textBoxInputData_MAB.Multiline = true;
            textBoxInputData_MAB.Name = "textBoxInputData_MAB";
            textBoxInputData_MAB.ReadOnly = true;
            textBoxInputData_MAB.ScrollBars = ScrollBars.Vertical;
            textBoxInputData_MAB.Size = new Size(508, 347);
            textBoxInputData_MAB.TabIndex = 0;
            // 
            // splitter_MAB
            // 
            splitter_MAB.Location = new Point(0, 0);
            splitter_MAB.Name = "splitter_MAB";
            splitter_MAB.Size = new Size(4, 373);
            splitter_MAB.TabIndex = 0;
            splitter_MAB.TabStop = false;
            // 
            // panelResult_MAB
            // 
            panelResult_MAB.Controls.Add(groupBoxResult_MAB);
            panelResult_MAB.Dock = DockStyle.Fill;
            panelResult_MAB.Location = new Point(518, 208);
            panelResult_MAB.Name = "panelResult_MAB";
            panelResult_MAB.Size = new Size(607, 373);
            panelResult_MAB.TabIndex = 3;
            // 
            // groupBoxResult_MAB
            // 
            groupBoxResult_MAB.Controls.Add(textBoxRsult_MAB);
            groupBoxResult_MAB.Dock = DockStyle.Fill;
            groupBoxResult_MAB.Location = new Point(0, 0);
            groupBoxResult_MAB.Name = "groupBoxResult_MAB";
            groupBoxResult_MAB.Size = new Size(607, 373);
            groupBoxResult_MAB.TabIndex = 0;
            groupBoxResult_MAB.TabStop = false;
            groupBoxResult_MAB.Text = "Вывод данных";
            // 
            // textBoxRsult_MAB
            // 
            textBoxRsult_MAB.Dock = DockStyle.Fill;
            textBoxRsult_MAB.Location = new Point(3, 23);
            textBoxRsult_MAB.Multiline = true;
            textBoxRsult_MAB.Name = "textBoxRsult_MAB";
            textBoxRsult_MAB.ReadOnly = true;
            textBoxRsult_MAB.ScrollBars = ScrollBars.Vertical;
            textBoxRsult_MAB.Size = new Size(601, 347);
            textBoxRsult_MAB.TabIndex = 0;
            // 
            // openFileDialogTask_MAB
            // 
            openFileDialogTask_MAB.FileName = "openFileDialog1";
            // 
            // toolTip_MAB
            // 
            toolTip_MAB.ToolTipIcon = ToolTipIcon.Info;
            toolTip_MAB.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 581);
            Controls.Add(panelResult_MAB);
            Controls.Add(panelInputData_MAB);
            Controls.Add(panelTask_MAB);
            Controls.Add(panelBotton_MAB);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 30 | Медведерова А.Б.";
            panelBotton_MAB.ResumeLayout(false);
            panelTask_MAB.ResumeLayout(false);
            groupBoxTask_MAB.ResumeLayout(false);
            groupBoxTask_MAB.PerformLayout();
            panelInputData_MAB.ResumeLayout(false);
            groupBoxInputData_MAB.ResumeLayout(false);
            groupBoxInputData_MAB.PerformLayout();
            panelResult_MAB.ResumeLayout(false);
            groupBoxResult_MAB.ResumeLayout(false);
            groupBoxResult_MAB.PerformLayout();
            ResumeLayout(false);
        }

        private void buttonDone_MAB_Click(object sender, EventArgs e)
        {
            textBoxRsult_MAB.Text = ds.CollectTextFromFile(openFilePath);
        }



        #endregion

        private Panel panelBotton_MAB;
        private Panel panelTask_MAB;
        private Panel panelInputData_MAB;
        private Splitter splitter_MAB;
        private Panel panelResult_MAB;
        private GroupBox groupBoxTask_MAB;
        private Label labelTask_MAB;
        private GroupBox groupBoxInputData_MAB;
        private GroupBox groupBoxResult_MAB;
        private Button buttonHelp_MAB;
        private Button buttonDone_MAB;
        private Button buttonOpenFile_MAB;
        private ToolTip toolTip_MAB;
        private OpenFileDialog openFileDialogTask_MAB;
        private TextBox textBoxInputData_MAB;
        private TextBox textBoxRsult_MAB;
    }
}
