using System.Data;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Tyuiu.NovikovDS.Sprint6.Task7.V30.Lib;

namespace Tyuiu.NovikovDS.Sprint6.Task7.V30
{
    public partial class MainForm : Form
    {
        DataService ds = new DataService();

        string filePath;
        int[,] matrixOut; 

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
                    filePath = openFileDialog.FileName;

                    string[] lines = File.ReadAllLines(filePath);
                    int rows = lines.Length;

                    int column = lines[0].Split(';').Length;

                    int[,] matrix = new int[rows, column];

                    for (int i = 0; i < rows; i++)
                    {
                        string[] values = lines[i].Split(";");
                        for (int j = 0; j < column; j++)
                        {
                            matrix[i, j] = int.Parse(values[j]);
                        }
                    }

                    DataGridViewIn_NovikovDS.Rows.Clear();
                    DataGridViewIn_NovikovDS.Columns.Clear();

                    int rowCount = matrix.GetLength(0);
                    int columnCount = matrix.GetLength(1);

                    for (int j = 0; j < columnCount; j++)
                    {
                        DataGridViewIn_NovikovDS.Columns.Add($"{j + 1}", $"{j + 1}");
                    }

                    for (int i = 0; i < rowCount; i++)
                    {
                        var row = new DataGridViewRow();
                        for (int j = 0; j < columnCount; j++)
                        {
                            row.Cells.Add(new DataGridViewTextBoxCell() { Value = matrix[i, j] });
                        }
                        DataGridViewIn_NovikovDS.Rows.Add(row);
                    }

                    for (int i = 0; i < columnCount; i++) DataGridViewIn_NovikovDS.Columns[i].Width = 35;
                }
            }
        }

        private void ButtonChange_NovikovDS_Click(object sender, EventArgs e)
        {
            if (DataGridViewIn_NovikovDS.Rows.Count == 0)
            {
                MessageBox.Show("Сначала загрузите файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            matrixOut = ds.GetMatrix(filePath);

            DataGridViewOut_NovikovDS.Rows.Clear();
            DataGridViewOut_NovikovDS.Columns.Clear();

            int rowCount = matrixOut.GetLength(0);
            int columnCount = matrixOut.GetLength(1);

            for (int j = 0; j < columnCount; j++)
            {
                DataGridViewOut_NovikovDS.Columns.Add($"{j + 1}", $"{j + 1}");
            }

            for (int i = 0; i < rowCount; i++)
            {
                var row = new DataGridViewRow();
                for (int j = 0; j < columnCount; j++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = matrixOut[i, j] });
                }
                DataGridViewOut_NovikovDS.Rows.Add(row);
            }

            for (int i = 0; i < columnCount; i++) DataGridViewOut_NovikovDS.Columns[i].Width = 35;
        }

        private void ButtonSave_NovikovDS_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    int rowCount = matrixOut.GetLength(0);
                    int columnCount = matrixOut.GetLength(1);

                    for (int i = 0; i < rowCount; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            writer.Write(matrixOut[i, j]);

                            // Не добавляем запятую после последнего элемента в строке
                            if (j < columnCount - 1)
                            {
                                writer.Write(";");
                            }
                        }
                        writer.WriteLine(); // Переход на новую строку после записи строки матрицы
                    }
                }

                MessageBox.Show("Матрица успешно сохранена в файл " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

    }
}
