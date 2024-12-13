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
                openFileDialog.InitialDirectory = "c:\\"; // Начальная директория
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите текстовый файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;

                    // Чтение файла
                    fileContent = File.ReadAllText(path);
                    TextBoxIn_NovikovDS.Text = fileContent; // Отображение содержимого в textBoxIn
                }
            }
        }

        private void ButtonChange_NovikovDS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileContent))
            {
                MessageBox.Show("Сначала откройте файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Вывод результата
            TextBoxOut_NovikovDS.Text = ds.CollectTextFromFile(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
