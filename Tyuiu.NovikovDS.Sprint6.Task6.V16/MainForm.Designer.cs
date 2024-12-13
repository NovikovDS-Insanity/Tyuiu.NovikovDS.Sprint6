namespace Tyuiu.NovikovDS.Sprint6.Task6.V16
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
            TextBoxIn_NovikovDS = new TextBox();
            TextBoxOut_NovikovDS = new TextBox();
            ButtonOpen_NovikovDS = new Button();
            ButtonChange_NovikovDS = new Button();
            SuspendLayout();
            // 
            // TextBoxIn_NovikovDS
            // 
            TextBoxIn_NovikovDS.Location = new Point(12, 76);
            TextBoxIn_NovikovDS.Multiline = true;
            TextBoxIn_NovikovDS.Name = "TextBoxIn_NovikovDS";
            TextBoxIn_NovikovDS.Size = new Size(271, 207);
            TextBoxIn_NovikovDS.TabIndex = 0;
            // 
            // TextBoxOut_NovikovDS
            // 
            TextBoxOut_NovikovDS.Location = new Point(289, 76);
            TextBoxOut_NovikovDS.Multiline = true;
            TextBoxOut_NovikovDS.Name = "TextBoxOut_NovikovDS";
            TextBoxOut_NovikovDS.Size = new Size(271, 207);
            TextBoxOut_NovikovDS.TabIndex = 1;
            // 
            // ButtonOpen_NovikovDS
            // 
            ButtonOpen_NovikovDS.Location = new Point(177, 12);
            ButtonOpen_NovikovDS.Name = "ButtonOpen_NovikovDS";
            ButtonOpen_NovikovDS.Size = new Size(106, 58);
            ButtonOpen_NovikovDS.TabIndex = 2;
            ButtonOpen_NovikovDS.Text = "Открыть";
            ButtonOpen_NovikovDS.UseVisualStyleBackColor = true;
            ButtonOpen_NovikovDS.Click += ButtonOpen_NovikovDS_Click;
            // 
            // ButtonChange_NovikovDS
            // 
            ButtonChange_NovikovDS.Location = new Point(289, 12);
            ButtonChange_NovikovDS.Name = "ButtonChange_NovikovDS";
            ButtonChange_NovikovDS.Size = new Size(106, 58);
            ButtonChange_NovikovDS.TabIndex = 3;
            ButtonChange_NovikovDS.Text = "Преобразовать";
            ButtonChange_NovikovDS.UseVisualStyleBackColor = true;
            ButtonChange_NovikovDS.Click += ButtonChange_NovikovDS_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 291);
            Controls.Add(ButtonChange_NovikovDS);
            Controls.Add(ButtonOpen_NovikovDS);
            Controls.Add(TextBoxOut_NovikovDS);
            Controls.Add(TextBoxIn_NovikovDS);
            Name = "MainForm";
            Text = "Спринт 6 | Таск 6 | Вариант 16 | Новиков Д. С.";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxIn_NovikovDS;
        private TextBox TextBoxOut_NovikovDS;
        private Button ButtonOpen_NovikovDS;
        private Button ButtonChange_NovikovDS;
    }
}
