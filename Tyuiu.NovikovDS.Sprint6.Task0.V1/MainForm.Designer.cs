namespace Tyuiu.NovikovDS.Sprint6.Task0.V1
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
            groupBox_Uslovie_NovikovDS = new GroupBox();
            pictureBox_Formula_NovikovDS = new PictureBox();
            textBox_Uslovie_NovikovDS = new TextBox();
            groupBox_Vvod_NovikovDS = new GroupBox();
            textBox_Vvodiks_NovikovDS = new TextBox();
            textBox_iks_NovikovDS = new TextBox();
            groupBox_Vivod_NovikovDS = new GroupBox();
            textBox_Vivodigrek_NovikovDS = new TextBox();
            textBox_igrek_NovikovDS = new TextBox();
            button_ToDo_NovikovDS = new Button();
            button_About_NovikovDS = new Button();
            groupBox_Uslovie_NovikovDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Formula_NovikovDS).BeginInit();
            groupBox_Vvod_NovikovDS.SuspendLayout();
            groupBox_Vivod_NovikovDS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Uslovie_NovikovDS
            // 
            groupBox_Uslovie_NovikovDS.Controls.Add(pictureBox_Formula_NovikovDS);
            groupBox_Uslovie_NovikovDS.Controls.Add(textBox_Uslovie_NovikovDS);
            groupBox_Uslovie_NovikovDS.Font = new Font("Segoe UI", 11F);
            groupBox_Uslovie_NovikovDS.Location = new Point(12, 12);
            groupBox_Uslovie_NovikovDS.Name = "groupBox_Uslovie_NovikovDS";
            groupBox_Uslovie_NovikovDS.Size = new Size(672, 226);
            groupBox_Uslovie_NovikovDS.TabIndex = 0;
            groupBox_Uslovie_NovikovDS.TabStop = false;
            groupBox_Uslovie_NovikovDS.Text = "Условие";
            // 
            // pictureBox_Formula_NovikovDS
            // 
            pictureBox_Formula_NovikovDS.Image = (Image)resources.GetObject("pictureBox_Formula_NovikovDS.Image");
            pictureBox_Formula_NovikovDS.Location = new Point(519, 28);
            pictureBox_Formula_NovikovDS.Name = "pictureBox_Formula_NovikovDS";
            pictureBox_Formula_NovikovDS.Size = new Size(147, 80);
            pictureBox_Formula_NovikovDS.TabIndex = 1;
            pictureBox_Formula_NovikovDS.TabStop = false;
            // 
            // textBox_Uslovie_NovikovDS
            // 
            textBox_Uslovie_NovikovDS.Font = new Font("Segoe UI", 13F);
            textBox_Uslovie_NovikovDS.ForeColor = SystemColors.ControlText;
            textBox_Uslovie_NovikovDS.Location = new Point(6, 28);
            textBox_Uslovie_NovikovDS.Multiline = true;
            textBox_Uslovie_NovikovDS.Name = "textBox_Uslovie_NovikovDS";
            textBox_Uslovie_NovikovDS.ReadOnly = true;
            textBox_Uslovie_NovikovDS.Size = new Size(507, 174);
            textBox_Uslovie_NovikovDS.TabIndex = 0;
            textBox_Uslovie_NovikovDS.TabStop = false;
            textBox_Uslovie_NovikovDS.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. ";
            // 
            // groupBox_Vvod_NovikovDS
            // 
            groupBox_Vvod_NovikovDS.Controls.Add(textBox_Vvodiks_NovikovDS);
            groupBox_Vvod_NovikovDS.Controls.Add(textBox_iks_NovikovDS);
            groupBox_Vvod_NovikovDS.Font = new Font("Segoe UI", 11F);
            groupBox_Vvod_NovikovDS.Location = new Point(12, 244);
            groupBox_Vvod_NovikovDS.Name = "groupBox_Vvod_NovikovDS";
            groupBox_Vvod_NovikovDS.Size = new Size(462, 100);
            groupBox_Vvod_NovikovDS.TabIndex = 1;
            groupBox_Vvod_NovikovDS.TabStop = false;
            groupBox_Vvod_NovikovDS.Text = "Ввод данных";
            // 
            // textBox_Vvodiks_NovikovDS
            // 
            textBox_Vvodiks_NovikovDS.Location = new Point(17, 60);
            textBox_Vvodiks_NovikovDS.Name = "textBox_Vvodiks_NovikovDS";
            textBox_Vvodiks_NovikovDS.Size = new Size(128, 27);
            textBox_Vvodiks_NovikovDS.TabIndex = 4;
            textBox_Vvodiks_NovikovDS.KeyPress += textBox_Vvodiks_NovikovDS_KeyPress;
            // 
            // textBox_iks_NovikovDS
            // 
            textBox_iks_NovikovDS.BackColor = SystemColors.Control;
            textBox_iks_NovikovDS.BorderStyle = BorderStyle.None;
            textBox_iks_NovikovDS.Location = new Point(17, 34);
            textBox_iks_NovikovDS.Name = "textBox_iks_NovikovDS";
            textBox_iks_NovikovDS.ReadOnly = true;
            textBox_iks_NovikovDS.Size = new Size(128, 20);
            textBox_iks_NovikovDS.TabIndex = 0;
            textBox_iks_NovikovDS.TabStop = false;
            textBox_iks_NovikovDS.Text = "Переменная X:";
            // 
            // groupBox_Vivod_NovikovDS
            // 
            groupBox_Vivod_NovikovDS.Controls.Add(textBox_Vivodigrek_NovikovDS);
            groupBox_Vivod_NovikovDS.Controls.Add(textBox_igrek_NovikovDS);
            groupBox_Vivod_NovikovDS.Font = new Font("Segoe UI", 11F);
            groupBox_Vivod_NovikovDS.Location = new Point(480, 244);
            groupBox_Vivod_NovikovDS.Name = "groupBox_Vivod_NovikovDS";
            groupBox_Vivod_NovikovDS.Size = new Size(204, 100);
            groupBox_Vivod_NovikovDS.TabIndex = 2;
            groupBox_Vivod_NovikovDS.TabStop = false;
            groupBox_Vivod_NovikovDS.Text = "Вывод данных";
            // 
            // textBox_Vivodigrek_NovikovDS
            // 
            textBox_Vivodigrek_NovikovDS.Enabled = false;
            textBox_Vivodigrek_NovikovDS.Location = new Point(20, 60);
            textBox_Vivodigrek_NovikovDS.Name = "textBox_Vivodigrek_NovikovDS";
            textBox_Vivodigrek_NovikovDS.ReadOnly = true;
            textBox_Vivodigrek_NovikovDS.Size = new Size(128, 27);
            textBox_Vivodigrek_NovikovDS.TabIndex = 3;
            // 
            // textBox_igrek_NovikovDS
            // 
            textBox_igrek_NovikovDS.BorderStyle = BorderStyle.None;
            textBox_igrek_NovikovDS.Location = new Point(20, 34);
            textBox_igrek_NovikovDS.Name = "textBox_igrek_NovikovDS";
            textBox_igrek_NovikovDS.ReadOnly = true;
            textBox_igrek_NovikovDS.Size = new Size(128, 20);
            textBox_igrek_NovikovDS.TabIndex = 2;
            textBox_igrek_NovikovDS.TabStop = false;
            textBox_igrek_NovikovDS.Text = "Результат:";
            // 
            // button_ToDo_NovikovDS
            // 
            button_ToDo_NovikovDS.Font = new Font("Segoe UI", 11F);
            button_ToDo_NovikovDS.Location = new Point(531, 350);
            button_ToDo_NovikovDS.Name = "button_ToDo_NovikovDS";
            button_ToDo_NovikovDS.Size = new Size(153, 27);
            button_ToDo_NovikovDS.TabIndex = 3;
            button_ToDo_NovikovDS.Text = "Выполнить";
            button_ToDo_NovikovDS.UseVisualStyleBackColor = true;
            button_ToDo_NovikovDS.Click += button_ToDo_NovikovDS_Click;
            // 
            // button_About_NovikovDS
            // 
            button_About_NovikovDS.Font = new Font("Segoe UI", 12F);
            button_About_NovikovDS.Location = new Point(480, 350);
            button_About_NovikovDS.Name = "button_About_NovikovDS";
            button_About_NovikovDS.Size = new Size(45, 27);
            button_About_NovikovDS.TabIndex = 4;
            button_About_NovikovDS.Text = "?";
            button_About_NovikovDS.UseVisualStyleBackColor = true;
            button_About_NovikovDS.Click += button_About_NovikovDS_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 389);
            Controls.Add(button_About_NovikovDS);
            Controls.Add(button_ToDo_NovikovDS);
            Controls.Add(groupBox_Vivod_NovikovDS);
            Controls.Add(groupBox_Vvod_NovikovDS);
            Controls.Add(groupBox_Uslovie_NovikovDS);
            Name = "MainForm";
            Text = "Спринт 1 | Таск 0 | Вариант 1 | Новиков Д. С.";
            Load += MainForm_Load;
            groupBox_Uslovie_NovikovDS.ResumeLayout(false);
            groupBox_Uslovie_NovikovDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Formula_NovikovDS).EndInit();
            groupBox_Vvod_NovikovDS.ResumeLayout(false);
            groupBox_Vvod_NovikovDS.PerformLayout();
            groupBox_Vivod_NovikovDS.ResumeLayout(false);
            groupBox_Vivod_NovikovDS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Uslovie_NovikovDS;
        private GroupBox groupBox_Vvod_NovikovDS;
        private GroupBox groupBox_Vivod_NovikovDS;
        private Button button_ToDo_NovikovDS;
        private Button button_About_NovikovDS;
        private PictureBox pictureBox_Formula_NovikovDS;
        private TextBox textBox_Uslovie_NovikovDS;
        private TextBox textBox_Vvodiks_NovikovDS;
        private TextBox textBox_iks_NovikovDS;
        private TextBox textBox_Vivodigrek_NovikovDS;
        private TextBox textBox_igrek_NovikovDS;
    }
}
