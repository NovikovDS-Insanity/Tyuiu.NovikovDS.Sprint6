namespace Tyuiu.NovikovDS.Sprint6.Task2.V20
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            GroupBox_Uslovie_NovikovDS = new GroupBox();
            TextBox_Uslovie_NovikovDS = new TextBox();
            PictureBox_Formula_NovikovDS = new PictureBox();
            GroupBox_Vvod_NovikovDS = new GroupBox();
            TextBox_StopValue_NovikovDS = new TextBox();
            TextBox_Stop_NovikovDS = new TextBox();
            TextBox_StartValue_NovikovDS = new TextBox();
            TextBox_Start_NovikovDS = new TextBox();
            GroupBox_Vivod_NovikovDS = new GroupBox();
            Chart_Grafik_NovikovDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            TextBox_Result_NovikovDS = new TextBox();
            DataGridView_Setka_NovikovDS = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            Button_ToDo_NovikovDS = new Button();
            Button_About_NovikovDS = new Button();
            GroupBox_Uslovie_NovikovDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Formula_NovikovDS).BeginInit();
            GroupBox_Vvod_NovikovDS.SuspendLayout();
            GroupBox_Vivod_NovikovDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Chart_Grafik_NovikovDS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Setka_NovikovDS).BeginInit();
            SuspendLayout();
            // 
            // GroupBox_Uslovie_NovikovDS
            // 
            GroupBox_Uslovie_NovikovDS.Controls.Add(TextBox_Uslovie_NovikovDS);
            GroupBox_Uslovie_NovikovDS.Controls.Add(PictureBox_Formula_NovikovDS);
            GroupBox_Uslovie_NovikovDS.Font = new Font("Segoe UI", 11F);
            GroupBox_Uslovie_NovikovDS.Location = new Point(12, 12);
            GroupBox_Uslovie_NovikovDS.Name = "GroupBox_Uslovie_NovikovDS";
            GroupBox_Uslovie_NovikovDS.Size = new Size(477, 308);
            GroupBox_Uslovie_NovikovDS.TabIndex = 0;
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
            PictureBox_Formula_NovikovDS.Size = new Size(465, 58);
            PictureBox_Formula_NovikovDS.TabIndex = 0;
            PictureBox_Formula_NovikovDS.TabStop = false;
            // 
            // GroupBox_Vvod_NovikovDS
            // 
            GroupBox_Vvod_NovikovDS.Controls.Add(TextBox_StopValue_NovikovDS);
            GroupBox_Vvod_NovikovDS.Controls.Add(TextBox_Stop_NovikovDS);
            GroupBox_Vvod_NovikovDS.Controls.Add(TextBox_StartValue_NovikovDS);
            GroupBox_Vvod_NovikovDS.Controls.Add(TextBox_Start_NovikovDS);
            GroupBox_Vvod_NovikovDS.Font = new Font("Segoe UI", 11F);
            GroupBox_Vvod_NovikovDS.Location = new Point(12, 326);
            GroupBox_Vvod_NovikovDS.Name = "GroupBox_Vvod_NovikovDS";
            GroupBox_Vvod_NovikovDS.Size = new Size(316, 103);
            GroupBox_Vvod_NovikovDS.TabIndex = 1;
            GroupBox_Vvod_NovikovDS.TabStop = false;
            GroupBox_Vvod_NovikovDS.Text = "Ввод данных";
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
            // GroupBox_Vivod_NovikovDS
            // 
            GroupBox_Vivod_NovikovDS.Controls.Add(Chart_Grafik_NovikovDS);
            GroupBox_Vivod_NovikovDS.Controls.Add(TextBox_Result_NovikovDS);
            GroupBox_Vivod_NovikovDS.Controls.Add(DataGridView_Setka_NovikovDS);
            GroupBox_Vivod_NovikovDS.Font = new Font("Segoe UI", 11F);
            GroupBox_Vivod_NovikovDS.Location = new Point(495, 12);
            GroupBox_Vivod_NovikovDS.Name = "GroupBox_Vivod_NovikovDS";
            GroupBox_Vivod_NovikovDS.Size = new Size(478, 417);
            GroupBox_Vivod_NovikovDS.TabIndex = 2;
            GroupBox_Vivod_NovikovDS.TabStop = false;
            GroupBox_Vivod_NovikovDS.Text = "Вывод данных";
            // 
            // Chart_Grafik_NovikovDS
            // 
            chartArea1.Name = "ChartArea1";
            Chart_Grafik_NovikovDS.ChartAreas.Add(chartArea1);
            Chart_Grafik_NovikovDS.Location = new Point(127, 52);
            Chart_Grafik_NovikovDS.Name = "Chart_Grafik_NovikovDS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            Chart_Grafik_NovikovDS.Series.Add(series1);
            Chart_Grafik_NovikovDS.Size = new Size(345, 364);
            Chart_Grafik_NovikovDS.TabIndex = 6;
            Chart_Grafik_NovikovDS.Text = "График функции";
            Chart_Grafik_NovikovDS.Click += Chart_Grafik_NovikovDS_Click;
            // 
            // TextBox_Result_NovikovDS
            // 
            TextBox_Result_NovikovDS.BorderStyle = BorderStyle.None;
            TextBox_Result_NovikovDS.Location = new Point(15, 26);
            TextBox_Result_NovikovDS.Name = "TextBox_Result_NovikovDS";
            TextBox_Result_NovikovDS.ReadOnly = true;
            TextBox_Result_NovikovDS.Size = new Size(78, 20);
            TextBox_Result_NovikovDS.TabIndex = 5;
            TextBox_Result_NovikovDS.TabStop = false;
            TextBox_Result_NovikovDS.Text = "Результат:";
            TextBox_Result_NovikovDS.TextChanged += textBox1_TextChanged;
            // 
            // DataGridView_Setka_NovikovDS
            // 
            DataGridView_Setka_NovikovDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Setka_NovikovDS.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            DataGridView_Setka_NovikovDS.Location = new Point(15, 52);
            DataGridView_Setka_NovikovDS.Name = "DataGridView_Setka_NovikovDS";
            DataGridView_Setka_NovikovDS.ReadOnly = true;
            DataGridView_Setka_NovikovDS.RowHeadersVisible = false;
            DataGridView_Setka_NovikovDS.Size = new Size(106, 359);
            DataGridView_Setka_NovikovDS.TabIndex = 0;
            DataGridView_Setka_NovikovDS.CellContentClick += dataGridView1_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.Name = "Y";
            Y.ReadOnly = true;
            Y.Width = 50;
            // 
            // Button_ToDo_NovikovDS
            // 
            Button_ToDo_NovikovDS.BackColor = Color.Lavender;
            Button_ToDo_NovikovDS.Font = new Font("Segoe UI", 11F);
            Button_ToDo_NovikovDS.Location = new Point(334, 335);
            Button_ToDo_NovikovDS.Name = "Button_ToDo_NovikovDS";
            Button_ToDo_NovikovDS.Size = new Size(155, 48);
            Button_ToDo_NovikovDS.TabIndex = 3;
            Button_ToDo_NovikovDS.TabStop = false;
            Button_ToDo_NovikovDS.Text = "Выполнитть";
            Button_ToDo_NovikovDS.UseVisualStyleBackColor = false;
            Button_ToDo_NovikovDS.Click += Button_ToDo_NovikovDS_Click;
            // 
            // Button_About_NovikovDS
            // 
            Button_About_NovikovDS.BackColor = Color.Bisque;
            Button_About_NovikovDS.Font = new Font("Segoe UI", 11F);
            Button_About_NovikovDS.Location = new Point(334, 389);
            Button_About_NovikovDS.Name = "Button_About_NovikovDS";
            Button_About_NovikovDS.Size = new Size(155, 40);
            Button_About_NovikovDS.TabIndex = 4;
            Button_About_NovikovDS.TabStop = false;
            Button_About_NovikovDS.Text = "Справка";
            Button_About_NovikovDS.UseVisualStyleBackColor = false;
            Button_About_NovikovDS.Click += Button_About_NovikovDS_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 440);
            Controls.Add(Button_About_NovikovDS);
            Controls.Add(Button_ToDo_NovikovDS);
            Controls.Add(GroupBox_Vivod_NovikovDS);
            Controls.Add(GroupBox_Vvod_NovikovDS);
            Controls.Add(GroupBox_Uslovie_NovikovDS);
            Name = "Form1";
            Text = "Спринт 6 | Таск 2 | Вариант 20 | Новиков Д. С.";
            Load += Form1_Load;
            GroupBox_Uslovie_NovikovDS.ResumeLayout(false);
            GroupBox_Uslovie_NovikovDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Formula_NovikovDS).EndInit();
            GroupBox_Vvod_NovikovDS.ResumeLayout(false);
            GroupBox_Vvod_NovikovDS.PerformLayout();
            GroupBox_Vivod_NovikovDS.ResumeLayout(false);
            GroupBox_Vivod_NovikovDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Chart_Grafik_NovikovDS).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Setka_NovikovDS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox_Uslovie_NovikovDS;
        private GroupBox GroupBox_Vvod_NovikovDS;
        private GroupBox GroupBox_Vivod_NovikovDS;
        private Button Button_ToDo_NovikovDS;
        private Button Button_About_NovikovDS;
        private PictureBox PictureBox_Formula_NovikovDS;
        private TextBox TextBox_Uslovie_NovikovDS;
        private TextBox TextBox_StopValue_NovikovDS;
        private TextBox TextBox_Stop_NovikovDS;
        private TextBox TextBox_StartValue_NovikovDS;
        private TextBox TextBox_Start_NovikovDS;
        private DataGridView DataGridView_Setka_NovikovDS;
        private TextBox TextBox_Result_NovikovDS;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Grafik_NovikovDS;
    }
}
