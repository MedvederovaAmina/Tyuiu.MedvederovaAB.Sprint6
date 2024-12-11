using Tyuiu.MedvederovaAB.Sprint6.Task6.V30.Lib;

namespace Tyuiu.MedvederovaAB.Sprint6.Task6.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void button3_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_MAB_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MAB.ShowDialog();
            openFilePath = openFileDialogTask_MAB.FileName;
           
                textBoxInputData_MAB.Text = File.ReadAllText(openFilePath);
                groupBoxInputData_MAB.Text = groupBoxInputData_MAB.Text + " " + openFileDialogTask_MAB.FileName;
                buttonDone_MAB.Enabled = true;
            
            
        }
    }
}
