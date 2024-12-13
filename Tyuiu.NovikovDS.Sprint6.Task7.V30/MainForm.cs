using System.Data;
using System.Windows.Forms;

namespace Tyuiu.NovikovDS.Sprint6.Task7.V30
{
    public partial class MainForm : Form
    {

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
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите CSV файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    LoadCsvData(filePath);
                }
            }
        }

        private void LoadCsvData(string filePath)
        {
            DataTable dataTable = new DataTable();

            using (var reader = new StreamReader(filePath))
            {
                // Чтение всех строк файла
                var lines = reader.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                // Определение максимального количества столбцов
                int maxColumns = lines.Max(line => line.Split(',').Length);

                // Добавление колонок в DataTable
                for (int i = 0; i < maxColumns; i++)
                {
                    dataTable.Columns.Add($"Column {i + 1}");
                }

                // Добавление данных в DataTable
                foreach (var line in lines)
                {
                    var rowData = line.Split(',');
                    dataTable.Rows.Add(rowData.Concat(new string[maxColumns - rowData.Length]).ToArray());
                }
            }

            // Проверка на квадратность
            int rowCount = dataTable.Rows.Count;
            int columnCount = dataTable.Columns.Count;

            if (rowCount != columnCount)
            {
                MessageBox.Show("Данные не могут быть представлены в квадратной таблице. Пожалуйста, проверьте файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Отображение данных в DataGridView
            DataGridViewIn_NovikovDS.DataSource = dataTable;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

    }
}
