using Tyuiu.MedvederovaAB.Sprint6.Task4.V6.Lib;

namespace Tyuiu.MedvederovaAB.Sprint6.Task4.V6
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

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);
                chartFunction_MAB.ChartAreas[0].AxisX.Title = "��� X";
                chartFunction_MAB.ChartAreas[0].AxisY.Title = "��� Y";
                textBoxResult_MAB.Text = "";
                for (int i = 0; i < valueArray.Length; i++)
                {
                    chartFunction_MAB.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_MAB.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� �������� ������ " + ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_MAB_Click(object sender, EventArgs e)
        {
            try 
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_MAB.Text);
                DialogResult dialogResult = MessageBox.Show("���� " + path + " �������� �������!\n ������� ��� � ��������?");
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MAB_Click(object sender, EventArgs e)
        {

            MessageBox.Show("���� 4 ��������� ��������� ������ ����-24-1 ����������� ����� ���������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
