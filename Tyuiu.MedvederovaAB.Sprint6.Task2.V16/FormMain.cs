using Tyuiu.MedvederovaAB.Sprint6.Task2.V16.Lib;

namespace Tyuiu.MedvederovaAB.Sprint6.Task2.V16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void groupBoxResult_MAB_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonResult_MAB_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_MAB.BackColor = Color.Red;
        }

        private void buttonResult_MAB_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_MAB.BackColor = Color.Green;
        }

        private void buttonResult_MAB_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_MAB.BackColor = Color.Blue;
        }

        private void buttonResult_MAB_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_MAB.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_MAB.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);
                chartFunction_MAB.Titles.Add("График функции F(x)");

                chartFunction_MAB.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_MAB.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    dataGridViewResult_MAB.Rows.Add(Convert.ToString(startStep), valueArray[i]);
                    chartFunction_MAB.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show(" Введены неверные данные ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MAB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ПКТб-24-1 Медведерова Амина Борисовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
