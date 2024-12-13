namespace Tyuiu.NovikovDS.Sprint6.Task3.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            GroupBox_Uslovie_NovikovDS = new GroupBox();
            PictureBox_Massiv_NovikovDS = new PictureBox();
            TextBox_Uslovie_NovikovDS = new TextBox();
            Button_About_NovikovDS = new Button();
            Button_ToDo_NovikovDS = new Button();
            DataGridView_Setka_NovikovDS = new DataGridView();
            GroupBox_Vivod_NovikovDS = new GroupBox();
            GroupBox_Uslovie_NovikovDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Massiv_NovikovDS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Setka_NovikovDS).BeginInit();
            GroupBox_Vivod_NovikovDS.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox_Uslovie_NovikovDS
            // 
            GroupBox_Uslovie_NovikovDS.Controls.Add(PictureBox_Massiv_NovikovDS);
            GroupBox_Uslovie_NovikovDS.Controls.Add(TextBox_Uslovie_NovikovDS);
            GroupBox_Uslovie_NovikovDS.Font = new Font("Segoe UI", 11F);
            GroupBox_Uslovie_NovikovDS.Location = new Point(12, 12);
            GroupBox_Uslovie_NovikovDS.Name = "GroupBox_Uslovie_NovikovDS";
            GroupBox_Uslovie_NovikovDS.Size = new Size(244, 347);
            GroupBox_Uslovie_NovikovDS.TabIndex = 1;
            GroupBox_Uslovie_NovikovDS.TabStop = false;
            GroupBox_Uslovie_NovikovDS.Text = "Условие";
            // 
            // PictureBox_Massiv_NovikovDS
            // 
            PictureBox_Massiv_NovikovDS.Image = (Image)resources.GetObject("PictureBox_Massiv_NovikovDS.Image");
            PictureBox_Massiv_NovikovDS.Location = new Point(42, 103);
            PictureBox_Massiv_NovikovDS.Name = "PictureBox_Massiv_NovikovDS";
            PictureBox_Massiv_NovikovDS.Size = new Size(150, 200);
            PictureBox_Massiv_NovikovDS.TabIndex = 2;
            PictureBox_Massiv_NovikovDS.TabStop = false;
            // 
            // TextBox_Uslovie_NovikovDS
            // 
            TextBox_Uslovie_NovikovDS.BorderStyle = BorderStyle.None;
            TextBox_Uslovie_NovikovDS.Location = new Point(6, 26);
            TextBox_Uslovie_NovikovDS.Multiline = true;
            TextBox_Uslovie_NovikovDS.Name = "TextBox_Uslovie_NovikovDS";
            TextBox_Uslovie_NovikovDS.ReadOnly = true;
            TextBox_Uslovie_NovikovDS.Size = new Size(232, 71);
            TextBox_Uslovie_NovikovDS.TabIndex = 1;
            TextBox_Uslovie_NovikovDS.TabStop = false;
            TextBox_Uslovie_NovikovDS.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в четвертой строке на 0.";
            TextBox_Uslovie_NovikovDS.TextChanged += TextBox_Uslovie_NovikovDS_TextChanged;
            // 
            // Button_About_NovikovDS
            // 
            Button_About_NovikovDS.BackColor = Color.Bisque;
            Button_About_NovikovDS.Font = new Font("Segoe UI", 11F);
            Button_About_NovikovDS.Location = new Point(22, 279);
            Button_About_NovikovDS.Name = "Button_About_NovikovDS";
            Button_About_NovikovDS.Size = new Size(149, 48);
            Button_About_NovikovDS.TabIndex = 6;
            Button_About_NovikovDS.TabStop = false;
            Button_About_NovikovDS.Text = "Справка";
            Button_About_NovikovDS.UseVisualStyleBackColor = false;
            Button_About_NovikovDS.Click += Button_About_NovikovDS_Click;
            // 
            // Button_ToDo_NovikovDS
            // 
            Button_ToDo_NovikovDS.BackColor = Color.Lavender;
            Button_ToDo_NovikovDS.Font = new Font("Segoe UI", 11F);
            Button_ToDo_NovikovDS.Location = new Point(22, 225);
            Button_ToDo_NovikovDS.Name = "Button_ToDo_NovikovDS";
            Button_ToDo_NovikovDS.Size = new Size(149, 48);
            Button_ToDo_NovikovDS.TabIndex = 5;
            Button_ToDo_NovikovDS.TabStop = false;
            Button_ToDo_NovikovDS.Text = "Выполнить";
            Button_ToDo_NovikovDS.UseVisualStyleBackColor = false;
            Button_ToDo_NovikovDS.Click += Button_ToDo_NovikovDS_Click;
            // 
            // DataGridView_Setka_NovikovDS
            // 
            DataGridView_Setka_NovikovDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Setka_NovikovDS.Location = new Point(6, 44);
            DataGridView_Setka_NovikovDS.Name = "DataGridView_Setka_NovikovDS";
            DataGridView_Setka_NovikovDS.ReadOnly = true;
            DataGridView_Setka_NovikovDS.RowHeadersVisible = false;
            DataGridView_Setka_NovikovDS.Size = new Size(180, 159);
            DataGridView_Setka_NovikovDS.TabIndex = 2;
            // 
            // GroupBox_Vivod_NovikovDS
            // 
            GroupBox_Vivod_NovikovDS.Controls.Add(DataGridView_Setka_NovikovDS);
            GroupBox_Vivod_NovikovDS.Controls.Add(Button_About_NovikovDS);
            GroupBox_Vivod_NovikovDS.Controls.Add(Button_ToDo_NovikovDS);
            GroupBox_Vivod_NovikovDS.Font = new Font("Segoe UI", 11F);
            GroupBox_Vivod_NovikovDS.Location = new Point(262, 13);
            GroupBox_Vivod_NovikovDS.Name = "GroupBox_Vivod_NovikovDS";
            GroupBox_Vivod_NovikovDS.Size = new Size(192, 346);
            GroupBox_Vivod_NovikovDS.TabIndex = 7;
            GroupBox_Vivod_NovikovDS.TabStop = false;
            GroupBox_Vivod_NovikovDS.Text = "Вывод данных";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 371);
            Controls.Add(GroupBox_Vivod_NovikovDS);
            Controls.Add(GroupBox_Uslovie_NovikovDS);
            Name = "MainForm";
            Text = "Спринт 6 | Таск 3 | Вариант 18 | Новиков Д. С.";
            GroupBox_Uslovie_NovikovDS.ResumeLayout(false);
            GroupBox_Uslovie_NovikovDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Massiv_NovikovDS).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Setka_NovikovDS).EndInit();
            GroupBox_Vivod_NovikovDS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox_Uslovie_NovikovDS;
        private TextBox TextBox_Uslovie_NovikovDS;
        private PictureBox PictureBox_Massiv_NovikovDS;
        private Button Button_About_NovikovDS;
        private Button Button_ToDo_NovikovDS;
        private DataGridView DataGridView_Setka_NovikovDS;
        private GroupBox GroupBox_Vivod_NovikovDS;
    }
}
