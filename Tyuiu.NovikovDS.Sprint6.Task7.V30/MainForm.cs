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
                openFileDialog.InitialDirectory = "c:\\"; // ��������� ����������
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "�������� CSV ����";

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
                // ������ ���� ����� �����
                var lines = reader.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                // ����������� ������������� ���������� ��������
                int maxColumns = lines.Max(line => line.Split(',').Length);

                // ���������� ������� � DataTable
                for (int i = 0; i < maxColumns; i++)
                {
                    dataTable.Columns.Add($"Column {i + 1}");
                }

                // ���������� ������ � DataTable
                foreach (var line in lines)
                {
                    var rowData = line.Split(',');
                    dataTable.Rows.Add(rowData.Concat(new string[maxColumns - rowData.Length]).ToArray());
                }
            }

            // �������� �� ������������
            int rowCount = dataTable.Rows.Count;
            int columnCount = dataTable.Columns.Count;

            if (rowCount != columnCount)
            {
                MessageBox.Show("������ �� ����� ���� ������������ � ���������� �������. ����������, ��������� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ����������� ������ � DataGridView
            DataGridViewIn_NovikovDS.DataSource = dataTable;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

    }
}
