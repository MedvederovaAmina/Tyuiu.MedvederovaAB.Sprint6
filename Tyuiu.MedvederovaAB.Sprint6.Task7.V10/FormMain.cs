using Tyuiu.MedvederovaAB.Sprint6.Task7.V10.Lib;

namespace Tyuiu.MedvederovaAB.Sprint6.Task7.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_MAB.Filter = "Значения , разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_MAB.Filter = "Значения , разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService dataService = new DataService();
        static int rows;
        static int columns;
        static string? openFilePath;
        private void buttonOpen_MAB_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void buttonOpen_MAB_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MAB.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MAB_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MAB.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_MAB_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MAB.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_MAB_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MAB.ToolTipTitle = "Справка";
        }

        private void buttonHelp_MAB_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_MAB_Click(object sender, EventArgs e)
        {
            int[,] values = dataService.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut_MAB.Rows[i].Cells[j].Value = values[i, j];
                }
            }
            buttonSave_MAB.Enabled = true;
        }

        private void buttonSave_MAB_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_MAB.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_MAB.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_MAB.ShowDialog();

            string path = saveFileDialogMatrix_MAB.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOut_MAB.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut_MAB.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonOpen_MAB_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MAB.ShowDialog();
            openFilePath = openFileDialogTask_MAB.FileName;

            if (openFilePath != null)
            {
                int[,] arrayValues = dataService.GetMatrix(openFilePath);

                rows = arrayValues.GetLength(0);
                columns = arrayValues.GetLength(1);

                dataGridViewIn_MAB.ColumnCount = columns;
                dataGridViewIn_MAB.RowCount = rows;
                dataGridViewOut_MAB.ColumnCount = columns;
                dataGridViewOut_MAB.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewIn_MAB.Columns[i].Width = 25;
                    dataGridViewOut_MAB.Columns[i].Width = 25;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewIn_MAB.Rows[i].Cells[j].Value = arrayValues[i, j];
                    }
                }
                buttonDone_MAB.Enabled = true;
        }   }
    }
}
