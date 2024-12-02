using Tyuiu.NovikovDS.Sprint6.Task2.V20.Lib;

namespace Tyuiu.NovikovDS.Sprint6.Task2.V20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_StartValue_NovikovDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void TextBox_StopValue_NovikovDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void Button_About_NovikovDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы РППб-24-1 Новиков Дмитрий Семенович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_ToDo_NovikovDS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                this.DataGridView_Setka_NovikovDS.Rows.Clear();

                int Start = Convert.ToInt32(TextBox_StartValue_NovikovDS.Text);
                int Stop = Convert.ToInt32(TextBox_StopValue_NovikovDS.Text);

                int len = ds.GetMassFunction(Start, Stop).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(Start, Stop);

                this.Chart_Grafik_NovikovDS.ChartAreas[0].AxisX.Title = "Ось X";
                this.Chart_Grafik_NovikovDS.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.DataGridView_Setka_NovikovDS.Rows.Add(Convert.ToString(Start), Convert.ToString(valueArray[i]));

                    this.Chart_Grafik_NovikovDS.Series[0].Points.AddXY(Start, valueArray[i]);

                    Start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chart_Grafik_NovikovDS_Click(object sender, EventArgs e)
        {

        }
    }
}
