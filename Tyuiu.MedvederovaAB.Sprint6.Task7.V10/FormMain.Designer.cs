namespace Tyuiu.MedvederovaAB.Sprint6.Task7.V10
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
            buttonSave_MAB = new Button();
            buttonDone_MAB = new Button();
            buttonOpen_MAB = new Button();
            buttonHelp_MAB = new Button();
            panelTask_MAB = new Panel();
            groupBoxTask_MAB = new GroupBox();
            labelTask_MAB = new Label();
            panelInputData_MAB = new Panel();
            groupBoxInput_MAB = new GroupBox();
            dataGridViewIn_MAB = new DataGridView();
            panelResult_MAB = new Panel();
            groupBoxOutput_MAB = new GroupBox();
            dataGridViewOut_MAB = new DataGridView();
            splitter_MAB = new Splitter();
            openFileDialogTask_MAB = new OpenFileDialog();
            toolTipButton_MAB = new ToolTip(components);
            saveFileDialogMatrix_MAB = new SaveFileDialog();
            panelBotton_MAB.SuspendLayout();
            panelTask_MAB.SuspendLayout();
            groupBoxTask_MAB.SuspendLayout();
            panelInputData_MAB.SuspendLayout();
            groupBoxInput_MAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MAB).BeginInit();
            panelResult_MAB.SuspendLayout();
            groupBoxOutput_MAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MAB).BeginInit();
            SuspendLayout();
            // 
            // panelBotton_MAB
            // 
            panelBotton_MAB.Controls.Add(buttonSave_MAB);
            panelBotton_MAB.Controls.Add(buttonDone_MAB);
            panelBotton_MAB.Controls.Add(buttonOpen_MAB);
            panelBotton_MAB.Controls.Add(buttonHelp_MAB);
            panelBotton_MAB.Dock = DockStyle.Top;
            panelBotton_MAB.Location = new Point(0, 0);
            panelBotton_MAB.Name = "panelBotton_MAB";
            panelBotton_MAB.Size = new Size(980, 82);
            panelBotton_MAB.TabIndex = 0;
            // 
            // buttonSave_MAB
            // 
            buttonSave_MAB.Enabled = false;
            buttonSave_MAB.FlatStyle = FlatStyle.Flat;
            buttonSave_MAB.Image = Properties.Resources.book_key;
            buttonSave_MAB.Location = new Point(227, 12);
            buttonSave_MAB.Name = "buttonSave_MAB";
            buttonSave_MAB.Size = new Size(112, 52);
            buttonSave_MAB.TabIndex = 3;
            toolTipButton_MAB.SetToolTip(buttonSave_MAB, "Сохранить обработанные данные в файл в формате CSV\r\n");
            buttonSave_MAB.UseVisualStyleBackColor = true;
            buttonSave_MAB.Click += buttonSave_MAB_Click;
            buttonSave_MAB.MouseEnter += buttonSave_MAB_MouseEnter;
            // 
            // buttonDone_MAB
            // 
            buttonDone_MAB.Enabled = false;
            buttonDone_MAB.FlatStyle = FlatStyle.Flat;
            buttonDone_MAB.Image = Properties.Resources.book_go;
            buttonDone_MAB.Location = new Point(117, 12);
            buttonDone_MAB.Name = "buttonDone_MAB";
            buttonDone_MAB.Size = new Size(104, 52);
            buttonDone_MAB.TabIndex = 2;
            toolTipButton_MAB.SetToolTip(buttonDone_MAB, "Выполнить обработку данных");
            buttonDone_MAB.UseVisualStyleBackColor = true;
            buttonDone_MAB.Click += buttonDone_MAB_Click;
            buttonDone_MAB.MouseEnter += buttonDone_MAB_MouseEnter;
            // 
            // buttonOpen_MAB
            // 
            buttonOpen_MAB.FlatStyle = FlatStyle.Flat;
            buttonOpen_MAB.Image = Properties.Resources.book_open;
            buttonOpen_MAB.Location = new Point(12, 12);
            buttonOpen_MAB.Name = "buttonOpen_MAB";
            buttonOpen_MAB.Size = new Size(99, 52);
            buttonOpen_MAB.TabIndex = 1;
            toolTipButton_MAB.SetToolTip(buttonOpen_MAB, "Открыть файл для обработки данных в формате CSV\r\n");
            buttonOpen_MAB.UseVisualStyleBackColor = true;
            buttonOpen_MAB.Click += buttonOpen_MAB_Click;
            buttonOpen_MAB.MouseDown += buttonOpen_MAB_MouseDown;
            buttonOpen_MAB.MouseEnter += buttonOpen_MAB_MouseEnter;
            // 
            // buttonHelp_MAB
            // 
            buttonHelp_MAB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_MAB.FlatStyle = FlatStyle.Flat;
            buttonHelp_MAB.Image = Properties.Resources.application_form_edit;
            buttonHelp_MAB.Location = new Point(875, 12);
            buttonHelp_MAB.Name = "buttonHelp_MAB";
            buttonHelp_MAB.Size = new Size(83, 52);
            buttonHelp_MAB.TabIndex = 0;
            toolTipButton_MAB.SetToolTip(buttonHelp_MAB, "Сведение о программе");
            buttonHelp_MAB.UseVisualStyleBackColor = true;
            buttonHelp_MAB.Click += buttonHelp_MAB_Click;
            buttonHelp_MAB.MouseEnter += buttonHelp_MAB_MouseEnter;
            // 
            // panelTask_MAB
            // 
            panelTask_MAB.Controls.Add(groupBoxTask_MAB);
            panelTask_MAB.Dock = DockStyle.Top;
            panelTask_MAB.Location = new Point(0, 82);
            panelTask_MAB.Name = "panelTask_MAB";
            panelTask_MAB.Size = new Size(980, 93);
            panelTask_MAB.TabIndex = 1;
            // 
            // groupBoxTask_MAB
            // 
            groupBoxTask_MAB.Controls.Add(labelTask_MAB);
            groupBoxTask_MAB.Dock = DockStyle.Fill;
            groupBoxTask_MAB.Location = new Point(0, 0);
            groupBoxTask_MAB.Name = "groupBoxTask_MAB";
            groupBoxTask_MAB.Size = new Size(980, 93);
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
            labelTask_MAB.Size = new Size(805, 60);
            labelTask_MAB.TabIndex = 0;
            labelTask_MAB.Text = resources.GetString("labelTask_MAB.Text");
            // 
            // panelInputData_MAB
            // 
            panelInputData_MAB.Controls.Add(groupBoxInput_MAB);
            panelInputData_MAB.Dock = DockStyle.Left;
            panelInputData_MAB.Location = new Point(0, 175);
            panelInputData_MAB.Name = "panelInputData_MAB";
            panelInputData_MAB.Size = new Size(453, 338);
            panelInputData_MAB.TabIndex = 2;
            // 
            // groupBoxInput_MAB
            // 
            groupBoxInput_MAB.Controls.Add(dataGridViewIn_MAB);
            groupBoxInput_MAB.Dock = DockStyle.Fill;
            groupBoxInput_MAB.Location = new Point(0, 0);
            groupBoxInput_MAB.Name = "groupBoxInput_MAB";
            groupBoxInput_MAB.Size = new Size(453, 338);
            groupBoxInput_MAB.TabIndex = 0;
            groupBoxInput_MAB.TabStop = false;
            groupBoxInput_MAB.Text = "Ввод";
            // 
            // dataGridViewIn_MAB
            // 
            dataGridViewIn_MAB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewIn_MAB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_MAB.Dock = DockStyle.Fill;
            dataGridViewIn_MAB.Location = new Point(3, 23);
            dataGridViewIn_MAB.Name = "dataGridViewIn_MAB";
            dataGridViewIn_MAB.RowHeadersVisible = false;
            dataGridViewIn_MAB.RowHeadersWidth = 51;
            dataGridViewIn_MAB.ScrollBars = ScrollBars.Horizontal;
            dataGridViewIn_MAB.Size = new Size(447, 312);
            dataGridViewIn_MAB.TabIndex = 0;
            // 
            // panelResult_MAB
            // 
            panelResult_MAB.Controls.Add(groupBoxOutput_MAB);
            panelResult_MAB.Dock = DockStyle.Fill;
            panelResult_MAB.Location = new Point(453, 175);
            panelResult_MAB.Name = "panelResult_MAB";
            panelResult_MAB.Size = new Size(527, 338);
            panelResult_MAB.TabIndex = 3;
            // 
            // groupBoxOutput_MAB
            // 
            groupBoxOutput_MAB.Controls.Add(dataGridViewOut_MAB);
            groupBoxOutput_MAB.Dock = DockStyle.Fill;
            groupBoxOutput_MAB.Location = new Point(0, 0);
            groupBoxOutput_MAB.Name = "groupBoxOutput_MAB";
            groupBoxOutput_MAB.Size = new Size(527, 338);
            groupBoxOutput_MAB.TabIndex = 0;
            groupBoxOutput_MAB.TabStop = false;
            groupBoxOutput_MAB.Text = "Вывод";
            // 
            // dataGridViewOut_MAB
            // 
            dataGridViewOut_MAB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewOut_MAB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_MAB.Dock = DockStyle.Fill;
            dataGridViewOut_MAB.Location = new Point(3, 23);
            dataGridViewOut_MAB.Name = "dataGridViewOut_MAB";
            dataGridViewOut_MAB.RowHeadersVisible = false;
            dataGridViewOut_MAB.RowHeadersWidth = 51;
            dataGridViewOut_MAB.ScrollBars = ScrollBars.Horizontal;
            dataGridViewOut_MAB.Size = new Size(521, 312);
            dataGridViewOut_MAB.TabIndex = 0;
            // 
            // splitter_MAB
            // 
            splitter_MAB.Location = new Point(453, 175);
            splitter_MAB.Name = "splitter_MAB";
            splitter_MAB.Size = new Size(11, 338);
            splitter_MAB.TabIndex = 4;
            splitter_MAB.TabStop = false;
            // 
            // openFileDialogTask_MAB
            // 
            openFileDialogTask_MAB.FileName = "openFileDialog1";
            // 
            // toolTipButton_MAB
            // 
            toolTipButton_MAB.IsBalloon = true;
            toolTipButton_MAB.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton_MAB.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 513);
            Controls.Add(splitter_MAB);
            Controls.Add(panelResult_MAB);
            Controls.Add(panelInputData_MAB);
            Controls.Add(panelTask_MAB);
            Controls.Add(panelBotton_MAB);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 10 | Медведерова А.Б.";
            panelBotton_MAB.ResumeLayout(false);
            panelTask_MAB.ResumeLayout(false);
            groupBoxTask_MAB.ResumeLayout(false);
            groupBoxTask_MAB.PerformLayout();
            panelInputData_MAB.ResumeLayout(false);
            groupBoxInput_MAB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MAB).EndInit();
            panelResult_MAB.ResumeLayout(false);
            groupBoxOutput_MAB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MAB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBotton_MAB;
        private Panel panelTask_MAB;
        private Panel panelInputData_MAB;
        private Panel panelResult_MAB;
        private Splitter splitter_MAB;
        private Button buttonSave_MAB;
        private Button buttonDone_MAB;
        private Button buttonOpen_MAB;
        private Button buttonHelp_MAB;
        private OpenFileDialog openFileDialogTask_MAB;
        private ToolTip toolTipButton_MAB;
        private GroupBox groupBoxTask_MAB;
        private Label labelTask_MAB;
        private GroupBox groupBoxInput_MAB;
        private GroupBox groupBoxOutput_MAB;
        private DataGridView dataGridViewIn_MAB;
        private DataGridView dataGridViewOut_MAB;
        private SaveFileDialog saveFileDialogMatrix_MAB;
    }
}
