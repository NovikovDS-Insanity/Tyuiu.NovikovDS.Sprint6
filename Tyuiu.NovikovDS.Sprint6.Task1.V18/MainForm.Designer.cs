namespace Tyuiu.NovikovDS.Sprint6.Task1.V18
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
            TextBox_Uslovie_NovikovDS = new TextBox();
            PictureBox_Formula_NovikovDS = new PictureBox();
            GroupBox_Vvod_NovikovDS = new GroupBox();
            TextBox_StopValue_NovikovDS = new TextBox();
            TextBox_Stop_NovikovDS = new TextBox();
            TextBox_StartValue_NovikovDS = new TextBox();
            TextBox_Start_NovikovDS = new TextBox();
            GroupBox_Vivod_NovikovDS = new GroupBox();
            TextBox_VivodIgrekov_NovikovDS = new TextBox();
            TextBox_Igreki_NovikovDS = new TextBox();
            Button_ToDo_NovikovDS = new Button();
            Button_About_NovikovDS = new Button();
            GroupBox_Uslovie_NovikovDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Formula_NovikovDS).BeginInit();
            GroupBox_Vvod_NovikovDS.SuspendLayout();
            GroupBox_Vivod_NovikovDS.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox_Uslovie_NovikovDS
            // 
            GroupBox_Uslovie_NovikovDS.Controls.Add(TextBox_Uslovie_NovikovDS);
            GroupBox_Uslovie_NovikovDS.Controls.Add(PictureBox_Formula_NovikovDS);
            GroupBox_Uslovie_NovikovDS.Font = new Font("Segoe UI", 11F);
            GroupBox_Uslovie_NovikovDS.Location = new Point(12, 12);
            GroupBox_Uslovie_NovikovDS.Name = "GroupBox_Uslovie_NovikovDS";
            GroupBox_Uslovie_NovikovDS.Size = new Size(503, 289);
            GroupBox_Uslovie_NovikovDS.TabIndex = 0;
            GroupBox_Uslovie_NovikovDS.TabStop = false;
            GroupBox_Uslovie_NovikovDS.Text = "Условие";
            // 
            // TextBox_Uslovie_NovikovDS
            // 
            TextBox_Uslovie_NovikovDS.BorderStyle = BorderStyle.None;
            TextBox_Uslovie_NovikovDS.Location = new Point(12, 26);
            TextBox_Uslovie_NovikovDS.Multiline = true;
            TextBox_Uslovie_NovikovDS.Name = "TextBox_Uslovie_NovikovDS";
            TextBox_Uslovie_NovikovDS.ReadOnly = true;
            TextBox_Uslovie_NovikovDS.Size = new Size(485, 83);
            TextBox_Uslovie_NovikovDS.TabIndex = 1;
            TextBox_Uslovie_NovikovDS.TabStop = false;
            TextBox_Uslovie_NovikovDS.Text = resources.GetString("TextBox_Uslovie_NovikovDS.Text");
            // 
            // PictureBox_Formula_NovikovDS
            // 
            PictureBox_Formula_NovikovDS.Image = (Image)resources.GetObject("PictureBox_Formula_NovikovDS.Image");
            PictureBox_Formula_NovikovDS.Location = new Point(12, 115);
            PictureBox_Formula_NovikovDS.Name = "PictureBox_Formula_NovikovDS";
            PictureBox_Formula_NovikovDS.Size = new Size(385, 50);
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
            GroupBox_Vvod_NovikovDS.Location = new Point(12, 307);
            GroupBox_Vvod_NovikovDS.Name = "GroupBox_Vvod_NovikovDS";
            GroupBox_Vvod_NovikovDS.Size = new Size(312, 97);
            GroupBox_Vvod_NovikovDS.TabIndex = 1;
            GroupBox_Vvod_NovikovDS.TabStop = false;
            GroupBox_Vvod_NovikovDS.Text = "Ввод данных";
            // 
            // TextBox_StopValue_NovikovDS
            // 
            TextBox_StopValue_NovikovDS.Location = new Point(161, 52);
            TextBox_StopValue_NovikovDS.Name = "TextBox_StopValue_NovikovDS";
            TextBox_StopValue_NovikovDS.Size = new Size(128, 27);
            TextBox_StopValue_NovikovDS.TabIndex = 3;
            TextBox_StopValue_NovikovDS.TabStop = false;
            TextBox_StopValue_NovikovDS.KeyPress += textBox_StopValue_NovikovDS_KeyPress;
            // 
            // TextBox_Stop_NovikovDS
            // 
            TextBox_Stop_NovikovDS.BorderStyle = BorderStyle.None;
            TextBox_Stop_NovikovDS.Location = new Point(161, 26);
            TextBox_Stop_NovikovDS.Name = "TextBox_Stop_NovikovDS";
            TextBox_Stop_NovikovDS.ReadOnly = true;
            TextBox_Stop_NovikovDS.Size = new Size(100, 20);
            TextBox_Stop_NovikovDS.TabIndex = 2;
            TextBox_Stop_NovikovDS.TabStop = false;
            TextBox_Stop_NovikovDS.Text = "Конец шага:";
            // 
            // TextBox_StartValue_NovikovDS
            // 
            TextBox_StartValue_NovikovDS.Location = new Point(6, 52);
            TextBox_StartValue_NovikovDS.Name = "TextBox_StartValue_NovikovDS";
            TextBox_StartValue_NovikovDS.Size = new Size(127, 27);
            TextBox_StartValue_NovikovDS.TabIndex = 1;
            TextBox_StartValue_NovikovDS.TabStop = false;
            TextBox_StartValue_NovikovDS.KeyPress += textBox_StartValue_NovikovDS_KeyPress;
            // 
            // TextBox_Start_NovikovDS
            // 
            TextBox_Start_NovikovDS.BorderStyle = BorderStyle.None;
            TextBox_Start_NovikovDS.Location = new Point(6, 26);
            TextBox_Start_NovikovDS.Name = "TextBox_Start_NovikovDS";
            TextBox_Start_NovikovDS.ReadOnly = true;
            TextBox_Start_NovikovDS.Size = new Size(100, 20);
            TextBox_Start_NovikovDS.TabIndex = 0;
            TextBox_Start_NovikovDS.TabStop = false;
            TextBox_Start_NovikovDS.Text = "Старт шага:";
            // 
            // GroupBox_Vivod_NovikovDS
            // 
            GroupBox_Vivod_NovikovDS.Controls.Add(TextBox_VivodIgrekov_NovikovDS);
            GroupBox_Vivod_NovikovDS.Controls.Add(TextBox_Igreki_NovikovDS);
            GroupBox_Vivod_NovikovDS.Font = new Font("Segoe UI", 11F);
            GroupBox_Vivod_NovikovDS.Location = new Point(521, 12);
            GroupBox_Vivod_NovikovDS.Name = "GroupBox_Vivod_NovikovDS";
            GroupBox_Vivod_NovikovDS.Size = new Size(267, 392);
            GroupBox_Vivod_NovikovDS.TabIndex = 2;
            GroupBox_Vivod_NovikovDS.TabStop = false;
            GroupBox_Vivod_NovikovDS.Text = "Вывод данных";
            // 
            // TextBox_VivodIgrekov_NovikovDS
            // 
            TextBox_VivodIgrekov_NovikovDS.Location = new Point(6, 52);
            TextBox_VivodIgrekov_NovikovDS.Multiline = true;
            TextBox_VivodIgrekov_NovikovDS.Name = "TextBox_VivodIgrekov_NovikovDS";
            TextBox_VivodIgrekov_NovikovDS.ReadOnly = true;
            TextBox_VivodIgrekov_NovikovDS.ScrollBars = ScrollBars.Vertical;
            TextBox_VivodIgrekov_NovikovDS.Size = new Size(255, 334);
            TextBox_VivodIgrekov_NovikovDS.TabIndex = 3;
            TextBox_VivodIgrekov_NovikovDS.TabStop = false;
            // 
            // TextBox_Igreki_NovikovDS
            // 
            TextBox_Igreki_NovikovDS.BorderStyle = BorderStyle.None;
            TextBox_Igreki_NovikovDS.Location = new Point(6, 26);
            TextBox_Igreki_NovikovDS.Name = "TextBox_Igreki_NovikovDS";
            TextBox_Igreki_NovikovDS.ReadOnly = true;
            TextBox_Igreki_NovikovDS.Size = new Size(100, 20);
            TextBox_Igreki_NovikovDS.TabIndex = 2;
            TextBox_Igreki_NovikovDS.TabStop = false;
            TextBox_Igreki_NovikovDS.Text = "Результат:";
            // 
            // Button_ToDo_NovikovDS
            // 
            Button_ToDo_NovikovDS.BackColor = Color.PeachPuff;
            Button_ToDo_NovikovDS.Font = new Font("Segoe UI", 11F);
            Button_ToDo_NovikovDS.Location = new Point(330, 317);
            Button_ToDo_NovikovDS.Name = "Button_ToDo_NovikovDS";
            Button_ToDo_NovikovDS.Size = new Size(185, 41);
            Button_ToDo_NovikovDS.TabIndex = 3;
            Button_ToDo_NovikovDS.TabStop = false;
            Button_ToDo_NovikovDS.Text = "Выполнить";
            Button_ToDo_NovikovDS.UseVisualStyleBackColor = false;
            Button_ToDo_NovikovDS.Click += button_ToDo_NovikovDS_Click;
            // 
            // Button_About_NovikovDS
            // 
            Button_About_NovikovDS.BackColor = Color.LightCyan;
            Button_About_NovikovDS.Font = new Font("Segoe UI", 11F);
            Button_About_NovikovDS.Location = new Point(330, 364);
            Button_About_NovikovDS.Name = "Button_About_NovikovDS";
            Button_About_NovikovDS.Size = new Size(185, 40);
            Button_About_NovikovDS.TabIndex = 4;
            Button_About_NovikovDS.TabStop = false;
            Button_About_NovikovDS.Text = "Справка";
            Button_About_NovikovDS.UseVisualStyleBackColor = false;
            Button_About_NovikovDS.Click += button_About_NovikovDS_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 416);
            Controls.Add(Button_About_NovikovDS);
            Controls.Add(Button_ToDo_NovikovDS);
            Controls.Add(GroupBox_Vivod_NovikovDS);
            Controls.Add(GroupBox_Vvod_NovikovDS);
            Controls.Add(GroupBox_Uslovie_NovikovDS);
            Name = "MainForm";
            Text = "Спринт 6 | Таск 1 | Вариант 18 | Новиков Д. С.";
            Load += MainForm_Load;
            GroupBox_Uslovie_NovikovDS.ResumeLayout(false);
            GroupBox_Uslovie_NovikovDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Formula_NovikovDS).EndInit();
            GroupBox_Vvod_NovikovDS.ResumeLayout(false);
            GroupBox_Vvod_NovikovDS.PerformLayout();
            GroupBox_Vivod_NovikovDS.ResumeLayout(false);
            GroupBox_Vivod_NovikovDS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox_Uslovie_NovikovDS;
        private GroupBox GroupBox_Vvod_NovikovDS;
        private GroupBox GroupBox_Vivod_NovikovDS;
        private Button Button_ToDo_NovikovDS;
        private Button Button_About_NovikovDS;
        private TextBox TextBox_StopValue_NovikovDS;
        private TextBox TextBox_Stop_NovikovDS;
        private TextBox TextBox_StartValue_NovikovDS;
        private TextBox TextBox_Start_NovikovDS;
        private TextBox TextBox_Uslovie_NovikovDS;
        private PictureBox PictureBox_Formula_NovikovDS;
        private TextBox TextBox_VivodIgrekov_NovikovDS;
        private TextBox TextBox_Igreki_NovikovDS;
    }
}
