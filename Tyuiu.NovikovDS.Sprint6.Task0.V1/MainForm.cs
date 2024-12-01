using Tyuiu.NovikovDS.Sprint6.Task0.V1.Lib;

namespace Tyuiu.NovikovDS.Sprint6.Task0.V1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_ToDo_NovikovDS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBox_Vivodigrek_NovikovDS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBox_Vvodiks_NovikovDS.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_Vvodiks_NovikovDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void button_About_NovikovDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РППб-24-1 Новиков Дмитрий Семенович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
