using Tyuiu.NovikovDS.Sprint6.Task6.V16.Lib;

namespace Tyuiu.NovikovDS.Sprint6.Task6.V16
{
    public partial class MainForm : Form
    {
        DataService ds = new DataService();

        string fileContent;
        string path;
        public MainForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void ButtonOpen_NovikovDS_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\"; // ��������� ����������
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "�������� ��������� ����";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;

                    // ������ �����
                    fileContent = File.ReadAllText(path);
                    TextBoxIn_NovikovDS.Text = fileContent; // ����������� ����������� � textBoxIn
                }
            }
        }

        private void ButtonChange_NovikovDS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileContent))
            {
                MessageBox.Show("������� �������� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ����� ����������
            TextBoxOut_NovikovDS.Text = ds.CollectTextFromFile(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
