using System.Windows.Forms;
using Tyuiu.MedvederovaAB.Sprint6.Task1.V14.Lib;

namespace Tyuiu.MedvederovaAB.Sprint6.Task1.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_MAB_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_MAB.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_MAB.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_MAB.Text = "";
                textBoxResult_MAB.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_MAB.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_MAB.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1,6:f2}   |", startStep, valueArray[i]);
                    textBoxResult_MAB.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_MAB.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Введены неверные данные " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MAB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ПКТб-24-1 Медведерова Амина Борисовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
