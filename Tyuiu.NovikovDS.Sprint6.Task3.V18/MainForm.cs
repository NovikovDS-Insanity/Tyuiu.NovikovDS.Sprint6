using Tyuiu.NovikovDS.Sprint6.Task3.V18.Lib;

namespace Tyuiu.NovikovDS.Sprint6.Task3.V18
{
    public partial class MainForm : Form
    {
        DataService ds = new DataService();

        int[,] matrix = new int[5,5]{ 
            { -19, -19,  1,   18,  7 },
            {  5,   3,  -4,  -6,  -12 },
            { -15,  6,   2,   2,  -14 },
            { -9,  -10,  15, -5,  -6 },
            { -13, -15, -9,   7,   1 } };

        public MainForm()
        {
            InitializeComponent();

            TextBox_Uslovie_NovikovDS.TextAlign = HorizontalAlignment.Center;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Button_About_NovikovDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы РППб-24-1 Новиков Дмитрий Семенович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_ToDo_NovikovDS_Click(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[,] res = ds.Calculate(matrix);

            DataGridView_Setka_NovikovDS.ColumnCount = columns;
            DataGridView_Setka_NovikovDS.RowCount = rows;

            for (int i = 0; i < columns; i++) DataGridView_Setka_NovikovDS.Columns[i].Width = 35;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) 
                    DataGridView_Setka_NovikovDS.Rows[i].Cells[j].Value = res[i, j].ToString();
            }

            DataGridView_Setka_NovikovDS.AllowUserToResizeRows = false;
            DataGridView_Setka_NovikovDS.AllowUserToResizeColumns = false;

            DataGridView_Setka_NovikovDS.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn column in DataGridView_Setka_NovikovDS.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void TextBox_Uslovie_NovikovDS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
