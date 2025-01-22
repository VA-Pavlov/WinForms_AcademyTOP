namespace WinForms_AcademyTOP
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkedListBox1 = new CheckedListBox();
            tovarsComboBox = new ComboBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("SimSun-ExtB", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(23, 97);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(519, 140);
            checkedListBox1.TabIndex = 0;
            // 
            // tovarsComboBox
            // 
            tovarsComboBox.FormattingEnabled = true;
            tovarsComboBox.Location = new Point(23, 32);
            tovarsComboBox.Name = "tovarsComboBox";
            tovarsComboBox.Size = new Size(348, 23);
            tovarsComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(470, 266);
            label1.Name = "label1";
            label1.Size = new Size(43, 30);
            label1.TabIndex = 2;
            label1.Text = "0,0";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(390, 32);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(516, 35);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 4;
            label2.Text = "кг";
            // 
            // button1
            // 
            button1.Location = new Point(188, 61);
            button1.Name = "button1";
            button1.Size = new Size(194, 23);
            button1.TabIndex = 5;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSpringGreen;
            button2.FlatStyle = FlatStyle.System;
            button2.ForeColor = Color.FromArgb(0, 0, 64);
            button2.Location = new Point(215, 319);
            button2.Name = "button2";
            button2.Size = new Size(156, 30);
            button2.TabIndex = 6;
            button2.Text = "Выдать чек";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(tovarsComboBox);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 363);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Касса";
            // 
            // button3
            // 
            button3.BackColor = Color.RosyBrown;
            button3.Location = new Point(394, 397);
            button3.Name = "button3";
            button3.Size = new Size(187, 41);
            button3.TabIndex = 8;
            button3.Text = "Закончить смену";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Location = new Point(17, 397);
            button4.Name = "button4";
            button4.Size = new Size(177, 41);
            button4.TabIndex = 9;
            button4.Text = "Склад";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(511, 278);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 7;
            label3.Text = "р.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private ComboBox tovarsComboBox;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Button button3;
        private Button button4;
        private Label label3;
    }
}