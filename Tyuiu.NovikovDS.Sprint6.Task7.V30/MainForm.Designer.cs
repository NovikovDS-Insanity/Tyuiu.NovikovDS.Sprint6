namespace Tyuiu.NovikovDS.Sprint6.Task7.V30
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
            DataGridViewIn_NovikovDS = new DataGridView();
            DataGridViewOut_NovikovDS = new DataGridView();
            ButtonOpen_NovikovDS = new Button();
            ButtonChange_NovikovDS = new Button();
            ButtonSave_NovikovDS = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewIn_NovikovDS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOut_NovikovDS).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewIn_NovikovDS
            // 
            DataGridViewIn_NovikovDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewIn_NovikovDS.Location = new Point(11, 58);
            DataGridViewIn_NovikovDS.Name = "DataGridViewIn_NovikovDS";
            DataGridViewIn_NovikovDS.Size = new Size(273, 214);
            DataGridViewIn_NovikovDS.TabIndex = 0;
            // 
            // DataGridViewOut_NovikovDS
            // 
            DataGridViewOut_NovikovDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewOut_NovikovDS.Location = new Point(290, 58);
            DataGridViewOut_NovikovDS.Name = "DataGridViewOut_NovikovDS";
            DataGridViewOut_NovikovDS.Size = new Size(273, 214);
            DataGridViewOut_NovikovDS.TabIndex = 1;
            // 
            // ButtonOpen_NovikovDS
            // 
            ButtonOpen_NovikovDS.Location = new Point(130, 13);
            ButtonOpen_NovikovDS.Name = "ButtonOpen_NovikovDS";
            ButtonOpen_NovikovDS.Size = new Size(101, 39);
            ButtonOpen_NovikovDS.TabIndex = 2;
            ButtonOpen_NovikovDS.Text = "Открыть";
            ButtonOpen_NovikovDS.UseVisualStyleBackColor = true;
            ButtonOpen_NovikovDS.Click += this.ButtonOpen_NovikovDS_Click;
            // 
            // ButtonChange_NovikovDS
            // 
            ButtonChange_NovikovDS.Location = new Point(237, 13);
            ButtonChange_NovikovDS.Name = "ButtonChange_NovikovDS";
            ButtonChange_NovikovDS.Size = new Size(101, 39);
            ButtonChange_NovikovDS.TabIndex = 3;
            ButtonChange_NovikovDS.Text = "Преобразовать";
            ButtonChange_NovikovDS.UseVisualStyleBackColor = true;
            // 
            // ButtonSave_NovikovDS
            // 
            ButtonSave_NovikovDS.Location = new Point(344, 13);
            ButtonSave_NovikovDS.Name = "ButtonSave_NovikovDS";
            ButtonSave_NovikovDS.Size = new Size(101, 39);
            ButtonSave_NovikovDS.TabIndex = 4;
            ButtonSave_NovikovDS.Text = "Сохранить";
            ButtonSave_NovikovDS.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 285);
            Controls.Add(ButtonSave_NovikovDS);
            Controls.Add(ButtonChange_NovikovDS);
            Controls.Add(ButtonOpen_NovikovDS);
            Controls.Add(DataGridViewOut_NovikovDS);
            Controls.Add(DataGridViewIn_NovikovDS);
            Name = "MainForm";
            Text = "Спринт 6 | Таск 7 | Вариант 30 | Новиков Д. С.";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewIn_NovikovDS).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOut_NovikovDS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewIn_NovikovDS;
        private DataGridView DataGridViewOut_NovikovDS;
        private Button ButtonOpen_NovikovDS;
        private Button ButtonChange_NovikovDS;
        private Button ButtonSave_NovikovDS;
    }
}
