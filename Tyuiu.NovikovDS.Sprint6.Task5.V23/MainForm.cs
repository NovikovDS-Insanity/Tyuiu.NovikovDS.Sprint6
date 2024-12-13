using Tyuiu.NovikovDS.Sprint6.Task5.V23.Lib;

namespace Tyuiu.NovikovDS.Sprint6.Task5.V23
{
    public partial class MainForm : Form
    {
        DataService ds = new DataService();

        string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V23.txt");

        public MainForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Button_About_NovikovDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы РППб-24-1 Новиков Дмитрий Семенович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_Open_NovikovDS_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Файл не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_ToDo_NovikovDS_Click(object sender, EventArgs e)
        {
            this.Chart_Grafik_NovikovDS.ChartAreas[0].AxisX.Title = "Ось Х";
            this.Chart_Grafik_NovikovDS.ChartAreas[0].AxisY.Title = "Ось Y";

            Chart_Grafik_NovikovDS.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                DataGridView_Setka_NovikovDS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                Chart_Grafik_NovikovDS.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
