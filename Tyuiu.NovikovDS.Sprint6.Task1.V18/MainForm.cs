using Tyuiu.NovikovDS.Sprint6.Task1.V18.Lib;

namespace Tyuiu.NovikovDS.Sprint6.Task1.V18
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

        private void textBox_StartValue_NovikovDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBox_StopValue_NovikovDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void button_About_NovikovDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РППб-24-1 Новиков Дмитрий Семенович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_ToDo_NovikovDS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int Start = Convert.ToInt32(TextBox_StartValue_NovikovDS.Text);
                int Stop = Convert.ToInt32(TextBox_StopValue_NovikovDS.Text);

                string strLine;
                int len = ds.GetMassFunction(Start, Stop).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(Start, Stop);

                TextBox_VivodIgrekov_NovikovDS.Text = "";
                TextBox_VivodIgrekov_NovikovDS.AppendText("+----------+----------+" + Environment.NewLine);
                TextBox_VivodIgrekov_NovikovDS.AppendText("|       X        |      f(x)     |" + Environment.NewLine);
                TextBox_VivodIgrekov_NovikovDS.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|     {0,4:f1}      |{1,10:f2}   |", Start, valueArray[i]);
                    TextBox_VivodIgrekov_NovikovDS.AppendText(strLine + Environment.NewLine);
                    Start++;
                }

                TextBox_VivodIgrekov_NovikovDS.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
