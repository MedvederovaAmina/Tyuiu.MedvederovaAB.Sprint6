using System.Drawing.Drawing2D;
using Tyuiu.MedvederovaAB.Sprint6.Task3.V25.Lib;

namespace Tyuiu.MedvederovaAB.Sprint6.Task3.V25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[,]
           {
                { 14, 5, -9, 18, 21},

                { -5, -12, -12, 4, 28},

                { 27, -2, -14, 23, 27},

                { -19, -15, 17, 15, 1 },

                {33, 2, 6, 24, 24 }
           };
        private void buttonDone_MAB_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = Convert.ToString(ds.Calculate(matrix));
        }

        private void groupBoxResult_MAB_Enter(object sender, EventArgs e)
        {

        }

        private void buttonHelp_MAB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ПКТб-24-1 Медведерова Амина Борисовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            matrix = ds.Calculate(matrix);
            dataGridViewTask_MAB.ColumnCount = columns;
            dataGridViewTask_MAB.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewTask_MAB.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewTask_MAB.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }

            }

        }
    }
}
