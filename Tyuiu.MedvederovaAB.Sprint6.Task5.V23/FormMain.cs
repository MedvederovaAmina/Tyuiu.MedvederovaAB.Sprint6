using System.Diagnostics;
using Tyuiu.MedvederovaAB.Sprint6.Task5.V23.Lib;

namespace Tyuiu.MedvederovaAB.Sprint6.Task5.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Амина Медведерова\source\repos\Tyuiu.MedvederovaAB.Sprint6\Tyuiu.MedvederovaAB.Sprint6.Task5.V23\bin\Debug\net8.0-windows\InPutDataFileTask5V23.txt";
        
        private void buttonDone_MAB_Click(object sender, EventArgs e)
        {
            dataGridViewResult_MAB.ColumnCount = 2;
            dataGridViewResult_MAB.Columns[0].Width = 20;
            dataGridViewResult_MAB.Columns[1].Width = 50;

            chart_MAB.ChartAreas[0].AxisX.Title = "Ось X";
            chart_MAB.ChartAreas[0].AxisY.Title = "Ось Y";
            chart_MAB.Series[0].Points.Clear();

            double[] valueArray = new double[ds.Length];

            valueArray = ds.LoadFromDataFile(path);

            for (int i = 0; i < valueArray.Length; i++)
            {
                dataGridViewResult_MAB.Rows.Add(Convert.ToString(i), Convert.ToString(valueArray[i]));
                chart_MAB.Series[0].Points.AddXY(i, valueArray[i]);
            }
        }

        private void buttonOpen_MAB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_MAB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ПКТб-24-1 Медведерова Амина Борисовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    }
}
