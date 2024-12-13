using Tyuiu.NovikovDS.Sprint6.Task4.V25.Lib;

namespace Tyuiu.NovikovDS.Sprint6.Task4.V25
{
    public partial class MainForm : Form
    {
        DataService ds = new DataService();

        public MainForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            try
            {
                int Start = Convert.ToInt32(TextBox_StartValue_NovikovDS.Text);
                int Stop = Convert.ToInt32(TextBox_StopValue_NovikovDS.Text);

                int len = ds.GetMassFunction(Start, Stop).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(Start, Stop);

                this.Chart_Grafik_NovikovDS.Titles.Add("График функции");

                this.Chart_Grafik_NovikovDS.ChartAreas[0].AxisX.Title = "Ось X";
                this.Chart_Grafik_NovikovDS.ChartAreas[0].AxisY.Title = "Ось Y";

                TextBox_Res_NovikovDS.Text = "";

                Chart_Grafik_NovikovDS.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.Chart_Grafik_NovikovDS.Series[0].Points.AddXY(Start, valueArray[i]);

                    TextBox_Res_NovikovDS.AppendText("X = " + Start + "\tY = " + valueArray[i] + Environment.NewLine);

                    Start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Save_NovikovDS_Click(object sender, EventArgs e)
        {
            try
            {
               string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V25.txt";
                File.WriteAllText(path, TextBox_Res_NovikovDS.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();

                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой присохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
