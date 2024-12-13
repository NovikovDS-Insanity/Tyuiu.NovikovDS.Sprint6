namespace Tyuiu.NovikovDS.Sprint6.Task4.V25
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Button_About_NovikovDS = new Button();
            Button_ToDo_NovikovDS = new Button();
            GroupBox_Vivod_NovikovDS = new GroupBox();
            Chart_Grafik_NovikovDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            TextBox_Res_NovikovDS = new TextBox();
            TextBox_Result_NovikovDS = new TextBox();
            GroupBox_Uslovie_NovikovDS = new GroupBox();
            TextBox_Uslovie_NovikovDS = new TextBox();
            PictureBox_Formula_NovikovDS = new PictureBox();
            TextBox_StopValue_NovikovDS = new TextBox();
            TextBox_Stop_NovikovDS = new TextBox();
            TextBox_StartValue_NovikovDS = new TextBox();
            TextBox_Start_NovikovDS = new TextBox();
            GroupBox_Vvod_NovikovDS = new GroupBox();
            Button_Save_NovikovDS = new Button();
            GroupBox_Vivod_NovikovDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Chart_Grafik_NovikovDS).BeginInit();
            GroupBox_Uslovie_NovikovDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Formula_NovikovDS).BeginInit();
            GroupBox_Vvod_NovikovDS.SuspendLayout();
            SuspendLayout();
            // 
            // Button_About_NovikovDS
            // 
            Button_About_NovikovDS.BackColor = Color.Bisque;
            Button_About_NovikovDS.Font = new Font("Segoe UI", 11F);
            Button_About_NovikovDS.Location = new Point(332, 406);
            Button_About_NovikovDS.Name = "Button_About_NovikovDS";
            Button_About_NovikovDS.Size = new Size(173, 27);
            Button_About_NovikovDS.TabIndex = 9;
            Button_About_NovikovDS.TabStop = false;
            Button_About_NovikovDS.Text = "Справка";
            Button_About_NovikovDS.UseVisualStyleBackColor = false;
            Button_About_NovikovDS.Click += Button_About_NovikovDS_Click;
            // 
            // Button_ToDo_NovikovDS
            // 
            Button_ToDo_NovikovDS.BackColor = Color.Lavender;
            Button_ToDo_NovikovDS.Font = new Font("Segoe UI", 11F);
            Button_ToDo_NovikovDS.Location = new Point(332, 340);
            Button_ToDo_NovikovDS.Name = "Button_ToDo_NovikovDS";
            Button_ToDo_NovikovDS.Size = new Size(173, 27);
            Button_ToDo_NovikovDS.TabIndex = 8;
            Button_ToDo_NovikovDS.TabStop = false;
            Button_ToDo_NovikovDS.Text = "Выполнитть";
            Button_ToDo_NovikovDS.UseVisualStyleBackColor = false;
            Button_ToDo_NovikovDS.Click += Button_ToDo_NovikovDS_Click;
            // 
            // GroupBox_Vivod_NovikovDS
            // 
            GroupBox_Vivod_NovikovDS.Controls.Add(Chart_Grafik_NovikovDS);
            GroupBox_Vivod_NovikovDS.Controls.Add(TextBox_Res_NovikovDS);
            GroupBox_Vivod_NovikovDS.Controls.Add(TextBox_Result_NovikovDS);
            GroupBox_Vivod_NovikovDS.Font = new Font("Segoe UI", 11F);
            GroupBox_Vivod_NovikovDS.Location = new Point(511, 17);
            GroupBox_Vivod_NovikovDS.Name = "GroupBox_Vivod_NovikovDS";
            GroupBox_Vivod_NovikovDS.Size = new Size(554, 417);
            GroupBox_Vivod_NovikovDS.TabIndex = 7;
            GroupBox_Vivod_NovikovDS.TabStop = false;
            GroupBox_Vivod_NovikovDS.Text = "Вывод данных";
            // 
            // Chart_Grafik_NovikovDS
            // 
            chartArea1.Name = "ChartArea1";
            Chart_Grafik_NovikovDS.ChartAreas.Add(chartArea1);
            Chart_Grafik_NovikovDS.Location = new Point(160, 26);
            Chart_Grafik_NovikovDS.Name = "Chart_Grafik_NovikovDS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            Chart_Grafik_NovikovDS.Series.Add(series1);
            Chart_Grafik_NovikovDS.Size = new Size(388, 385);
            Chart_Grafik_NovikovDS.TabIndex = 7;
            Chart_Grafik_NovikovDS.Text = "chart1";
            // 
            // TextBox_Res_NovikovDS
            // 
            TextBox_Res_NovikovDS.BorderStyle = BorderStyle.None;
            TextBox_Res_NovikovDS.Location = new Point(6, 52);
            TextBox_Res_NovikovDS.Multiline = true;
            TextBox_Res_NovikovDS.Name = "TextBox_Res_NovikovDS";
            TextBox_Res_NovikovDS.ReadOnly = true;
            TextBox_Res_NovikovDS.Size = new Size(148, 352);
            TextBox_Res_NovikovDS.TabIndex = 6;
            TextBox_Res_NovikovDS.TabStop = false;
            // 
            // TextBox_Result_NovikovDS
            // 
            TextBox_Result_NovikovDS.BorderStyle = BorderStyle.None;
            TextBox_Result_NovikovDS.Location = new Point(6, 26);
            TextBox_Result_NovikovDS.Name = "TextBox_Result_NovikovDS";
            TextBox_Result_NovikovDS.ReadOnly = true;
            TextBox_Result_NovikovDS.Size = new Size(78, 20);
            TextBox_Result_NovikovDS.TabIndex = 5;
            TextBox_Result_NovikovDS.TabStop = false;
            TextBox_Result_NovikovDS.Text = "Результат:";
            // 
            // GroupBox_Uslovie_NovikovDS
            // 
            GroupBox_Uslovie_NovikovDS.Controls.Add(TextBox_Uslovie_NovikovDS);
            GroupBox_Uslovie_NovikovDS.Controls.Add(PictureBox_Formula_NovikovDS);
            GroupBox_Uslovie_NovikovDS.Font = new Font("Segoe UI", 11F);
            GroupBox_Uslovie_NovikovDS.Location = new Point(10, 17);
            GroupBox_Uslovie_NovikovDS.Name = "GroupBox_Uslovie_NovikovDS";
            GroupBox_Uslovie_NovikovDS.Size = new Size(495, 308);
            GroupBox_Uslovie_NovikovDS.TabIndex = 5;
            GroupBox_Uslovie_NovikovDS.TabStop = false;
            GroupBox_Uslovie_NovikovDS.Text = "Условие";
            // 
            // TextBox_Uslovie_NovikovDS
            // 
            TextBox_Uslovie_NovikovDS.BorderStyle = BorderStyle.None;
            TextBox_Uslovie_NovikovDS.Location = new Point(15, 26);
            TextBox_Uslovie_NovikovDS.Multiline = true;
            TextBox_Uslovie_NovikovDS.Name = "TextBox_Uslovie_NovikovDS";
            TextBox_Uslovie_NovikovDS.ReadOnly = true;
            TextBox_Uslovie_NovikovDS.Size = new Size(456, 89);
            TextBox_Uslovie_NovikovDS.TabIndex = 1;
            TextBox_Uslovie_NovikovDS.TabStop = false;
            TextBox_Uslovie_NovikovDS.Text = resources.GetString("TextBox_Uslovie_NovikovDS.Text");
            // 
            // PictureBox_Formula_NovikovDS
            // 
            PictureBox_Formula_NovikovDS.Image = (Image)resources.GetObject("PictureBox_Formula_NovikovDS.Image");
            PictureBox_Formula_NovikovDS.Location = new Point(6, 244);
            PictureBox_Formula_NovikovDS.Name = "PictureBox_Formula_NovikovDS";
            PictureBox_Formula_NovikovDS.Size = new Size(482, 58);
            PictureBox_Formula_NovikovDS.TabIndex = 0;
            PictureBox_Formula_NovikovDS.TabStop = false;
            // 
            // TextBox_StopValue_NovikovDS
            // 
            TextBox_StopValue_NovikovDS.Location = new Point(170, 63);
            TextBox_StopValue_NovikovDS.Name = "TextBox_StopValue_NovikovDS";
            TextBox_StopValue_NovikovDS.Size = new Size(128, 27);
            TextBox_StopValue_NovikovDS.TabIndex = 7;
            TextBox_StopValue_NovikovDS.TabStop = false;
            TextBox_StopValue_NovikovDS.KeyPress += TextBox_StopValue_NovikovDS_KeyPress;
            // 
            // TextBox_Stop_NovikovDS
            // 
            TextBox_Stop_NovikovDS.BorderStyle = BorderStyle.None;
            TextBox_Stop_NovikovDS.Location = new Point(170, 37);
            TextBox_Stop_NovikovDS.Name = "TextBox_Stop_NovikovDS";
            TextBox_Stop_NovikovDS.ReadOnly = true;
            TextBox_Stop_NovikovDS.Size = new Size(100, 20);
            TextBox_Stop_NovikovDS.TabIndex = 6;
            TextBox_Stop_NovikovDS.TabStop = false;
            TextBox_Stop_NovikovDS.Text = "Конец шага:";
            // 
            // TextBox_StartValue_NovikovDS
            // 
            TextBox_StartValue_NovikovDS.Location = new Point(15, 63);
            TextBox_StartValue_NovikovDS.Name = "TextBox_StartValue_NovikovDS";
            TextBox_StartValue_NovikovDS.Size = new Size(127, 27);
            TextBox_StartValue_NovikovDS.TabIndex = 5;
            TextBox_StartValue_NovikovDS.TabStop = false;
            TextBox_StartValue_NovikovDS.KeyPress += TextBox_StartValue_NovikovDS_KeyPress;
            // 
            // TextBox_Start_NovikovDS
            // 
            TextBox_Start_NovikovDS.BorderStyle = BorderStyle.None;
            TextBox_Start_NovikovDS.Location = new Point(15, 37);
            TextBox_Start_NovikovDS.Name = "TextBox_Start_NovikovDS";
            TextBox_Start_NovikovDS.ReadOnly = true;
            TextBox_Start_NovikovDS.Size = new Size(100, 20);
            TextBox_Start_NovikovDS.TabIndex = 4;
            TextBox_Start_NovikovDS.TabStop = false;
            TextBox_Start_NovikovDS.Text = "Старт шага:";
            // 
            // GroupBox_Vvod_NovikovDS
            // 
            GroupBox_Vvod_NovikovDS.Controls.Add(TextBox_StopValue_NovikovDS);
            GroupBox_Vvod_NovikovDS.Controls.Add(TextBox_Stop_NovikovDS);
            GroupBox_Vvod_NovikovDS.Controls.Add(TextBox_StartValue_NovikovDS);
            GroupBox_Vvod_NovikovDS.Controls.Add(TextBox_Start_NovikovDS);
            GroupBox_Vvod_NovikovDS.Font = new Font("Segoe UI", 11F);
            GroupBox_Vvod_NovikovDS.Location = new Point(10, 331);
            GroupBox_Vvod_NovikovDS.Name = "GroupBox_Vvod_NovikovDS";
            GroupBox_Vvod_NovikovDS.Size = new Size(316, 103);
            GroupBox_Vvod_NovikovDS.TabIndex = 6;
            GroupBox_Vvod_NovikovDS.TabStop = false;
            GroupBox_Vvod_NovikovDS.Text = "Ввод данных";
            // 
            // Button_Save_NovikovDS
            // 
            Button_Save_NovikovDS.BackColor = Color.Pink;
            Button_Save_NovikovDS.Font = new Font("Segoe UI", 11F);
            Button_Save_NovikovDS.Location = new Point(332, 373);
            Button_Save_NovikovDS.Name = "Button_Save_NovikovDS";
            Button_Save_NovikovDS.Size = new Size(173, 27);
            Button_Save_NovikovDS.TabIndex = 10;
            Button_Save_NovikovDS.TabStop = false;
            Button_Save_NovikovDS.Text = "Сохранить";
            Button_Save_NovikovDS.UseVisualStyleBackColor = false;
            Button_Save_NovikovDS.Click += Button_Save_NovikovDS_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 445);
            Controls.Add(Button_Save_NovikovDS);
            Controls.Add(GroupBox_Vivod_NovikovDS);
            Controls.Add(GroupBox_Uslovie_NovikovDS);
            Controls.Add(Button_About_NovikovDS);
            Controls.Add(GroupBox_Vvod_NovikovDS);
            Controls.Add(Button_ToDo_NovikovDS);
            Name = "MainForm";
            Text = "Спринт 6 | Таск 4 | Вариант 25 | Новиков Д. С.";
            Load += MainForm_Load;
            GroupBox_Vivod_NovikovDS.ResumeLayout(false);
            GroupBox_Vivod_NovikovDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Chart_Grafik_NovikovDS).EndInit();
            GroupBox_Uslovie_NovikovDS.ResumeLayout(false);
            GroupBox_Uslovie_NovikovDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Formula_NovikovDS).EndInit();
            GroupBox_Vvod_NovikovDS.ResumeLayout(false);
            GroupBox_Vvod_NovikovDS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Button_About_NovikovDS;
        private Button Button_ToDo_NovikovDS;
        private GroupBox GroupBox_Vivod_NovikovDS;
        private TextBox TextBox_Result_NovikovDS;
        private GroupBox GroupBox_Uslovie_NovikovDS;
        private TextBox TextBox_Uslovie_NovikovDS;
        private PictureBox PictureBox_Formula_NovikovDS;
        private TextBox TextBox_StopValue_NovikovDS;
        private TextBox TextBox_Stop_NovikovDS;
        private TextBox TextBox_StartValue_NovikovDS;
        private TextBox TextBox_Start_NovikovDS;
        private GroupBox GroupBox_Vvod_NovikovDS;
        private TextBox TextBox_Res_NovikovDS;
        private Button Button_Save_NovikovDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Grafik_NovikovDS;
    }
}
