using Tyuiu.MedvederovaAB.Sprint6.Task0.V14.Lib;

namespace Tyuiu.MedvederovaAB.Sprint6.Task0.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }



        private void textBoxVarX_MAB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',' || e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_MAB_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_MAB.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_MAB.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MAB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ПКТб-24-1 Медведерова Амина Борисовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
