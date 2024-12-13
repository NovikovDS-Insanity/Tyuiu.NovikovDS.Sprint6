namespace Tyuiu.NovikovDS.Sprint6.Task5.V23
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
            GroupBox_Vivod_NovikovDS = new GroupBox();
            Chart_Grafik_NovikovDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            DataGridView_Setka_NovikovDS = new DataGridView();
            Button_About_NovikovDS = new Button();
            Button_ToDo_NovikovDS = new Button();
            TextBox_Uslovie_NovikovDS = new TextBox();
            GroupBox_Uslovie_NovikovDS = new GroupBox();
            Button_Open_NovikovDS = new Button();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            GroupBox_Vivod_NovikovDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Chart_Grafik_NovikovDS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Setka_NovikovDS).BeginInit();
            GroupBox_Uslovie_NovikovDS.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox_Vivod_NovikovDS
            // 
            GroupBox_Vivod_NovikovDS.Controls.Add(Chart_Grafik_NovikovDS);
            GroupBox_Vivod_NovikovDS.Controls.Add(DataGridView_Setka_NovikovDS);
            GroupBox_Vivod_NovikovDS.Font = new Font("Segoe UI", 11F);
            GroupBox_Vivod_NovikovDS.Location = new Point(18, 113);
            GroupBox_Vivod_NovikovDS.Name = "GroupBox_Vivod_NovikovDS";
            GroupBox_Vivod_NovikovDS.Size = new Size(691, 436);
            GroupBox_Vivod_NovikovDS.TabIndex = 6;
            GroupBox_Vivod_NovikovDS.TabStop = false;
            GroupBox_Vivod_NovikovDS.Text = "Вывод данных";
            // 
            // Chart_Grafik_NovikovDS
            // 
            chartArea1.Name = "ChartArea1";
            Chart_Grafik_NovikovDS.ChartAreas.Add(chartArea1);
            Chart_Grafik_NovikovDS.Location = new Point(147, 26);
            Chart_Grafik_NovikovDS.Name = "Chart_Grafik_NovikovDS";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            Chart_Grafik_NovikovDS.Series.Add(series1);
            Chart_Grafik_NovikovDS.Size = new Size(535, 404);
            Chart_Grafik_NovikovDS.TabIndex = 1;
            Chart_Grafik_NovikovDS.Text = "chart1";
            // 
            // DataGridView_Setka_NovikovDS
            // 
            DataGridView_Setka_NovikovDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Setka_NovikovDS.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            DataGridView_Setka_NovikovDS.Location = new Point(15, 26);
            DataGridView_Setka_NovikovDS.Name = "DataGridView_Setka_NovikovDS";
            DataGridView_Setka_NovikovDS.ReadOnly = true;
            DataGridView_Setka_NovikovDS.RowHeadersVisible = false;
            DataGridView_Setka_NovikovDS.Size = new Size(126, 404);
            DataGridView_Setka_NovikovDS.TabIndex = 0;
            // 
            // Button_About_NovikovDS
            // 
            Button_About_NovikovDS.BackColor = Color.Bisque;
            Button_About_NovikovDS.Font = new Font("Segoe UI", 11F);
            Button_About_NovikovDS.Location = new Point(715, 249);
            Button_About_NovikovDS.Name = "Button_About_NovikovDS";
            Button_About_NovikovDS.Size = new Size(95, 65);
            Button_About_NovikovDS.TabIndex = 8;
            Button_About_NovikovDS.TabStop = false;
            Button_About_NovikovDS.Text = "Справка";
            Button_About_NovikovDS.UseVisualStyleBackColor = false;
            Button_About_NovikovDS.Click += Button_About_NovikovDS_Click;
            // 
            // Button_ToDo_NovikovDS
            // 
            Button_ToDo_NovikovDS.BackColor = Color.Lavender;
            Button_ToDo_NovikovDS.Font = new Font("Segoe UI", 11F);
            Button_ToDo_NovikovDS.Location = new Point(715, 333);
            Button_ToDo_NovikovDS.Name = "Button_ToDo_NovikovDS";
            Button_ToDo_NovikovDS.Size = new Size(95, 65);
            Button_ToDo_NovikovDS.TabIndex = 7;
            Button_ToDo_NovikovDS.TabStop = false;
            Button_ToDo_NovikovDS.Text = "Выполнить";
            Button_ToDo_NovikovDS.UseVisualStyleBackColor = false;
            Button_ToDo_NovikovDS.Click += Button_ToDo_NovikovDS_Click;
            // 
            // TextBox_Uslovie_NovikovDS
            // 
            TextBox_Uslovie_NovikovDS.BorderStyle = BorderStyle.None;
            TextBox_Uslovie_NovikovDS.Location = new Point(6, 26);
            TextBox_Uslovie_NovikovDS.Multiline = true;
            TextBox_Uslovie_NovikovDS.Name = "TextBox_Uslovie_NovikovDS";
            TextBox_Uslovie_NovikovDS.ReadOnly = true;
            TextBox_Uslovie_NovikovDS.Size = new Size(676, 65);
            TextBox_Uslovie_NovikovDS.TabIndex = 1;
            TextBox_Uslovie_NovikovDS.TabStop = false;
            TextBox_Uslovie_NovikovDS.Text = resources.GetString("TextBox_Uslovie_NovikovDS.Text");
            // 
            // GroupBox_Uslovie_NovikovDS
            // 
            GroupBox_Uslovie_NovikovDS.Controls.Add(TextBox_Uslovie_NovikovDS);
            GroupBox_Uslovie_NovikovDS.Font = new Font("Segoe UI", 11F);
            GroupBox_Uslovie_NovikovDS.Location = new Point(12, 12);
            GroupBox_Uslovie_NovikovDS.Name = "GroupBox_Uslovie_NovikovDS";
            GroupBox_Uslovie_NovikovDS.Size = new Size(697, 95);
            GroupBox_Uslovie_NovikovDS.TabIndex = 5;
            GroupBox_Uslovie_NovikovDS.TabStop = false;
            GroupBox_Uslovie_NovikovDS.Text = "Условие";
            // 
            // Button_Open_NovikovDS
            // 
            Button_Open_NovikovDS.BackColor = Color.Pink;
            Button_Open_NovikovDS.Font = new Font("Segoe UI", 11F);
            Button_Open_NovikovDS.Location = new Point(715, 165);
            Button_Open_NovikovDS.Name = "Button_Open_NovikovDS";
            Button_Open_NovikovDS.Size = new Size(95, 65);
            Button_Open_NovikovDS.TabIndex = 11;
            Button_Open_NovikovDS.TabStop = false;
            Button_Open_NovikovDS.Text = "Открыть";
            Button_Open_NovikovDS.UseVisualStyleBackColor = false;
            Button_Open_NovikovDS.Click += Button_Open_NovikovDS_Click;
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
            Y.Width = 70;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 561);
            Controls.Add(Button_Open_NovikovDS);
            Controls.Add(Button_ToDo_NovikovDS);
            Controls.Add(Button_About_NovikovDS);
            Controls.Add(GroupBox_Vivod_NovikovDS);
            Controls.Add(GroupBox_Uslovie_NovikovDS);
            Name = "MainForm";
            Text = "Спринт 6 | Таск 5 | Вариант 23 | Новиков Д. С.";
            Load += MainForm_Load;
            GroupBox_Vivod_NovikovDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Chart_Grafik_NovikovDS).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Setka_NovikovDS).EndInit();
            GroupBox_Uslovie_NovikovDS.ResumeLayout(false);
            GroupBox_Uslovie_NovikovDS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox_Vivod_NovikovDS;
        private DataGridView DataGridView_Setka_NovikovDS;
        private Button Button_About_NovikovDS;
        private Button Button_ToDo_NovikovDS;
        private TextBox TextBox_Uslovie_NovikovDS;
        private GroupBox GroupBox_Uslovie_NovikovDS;
        private Button Button_Open_NovikovDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Grafik_NovikovDS;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}
