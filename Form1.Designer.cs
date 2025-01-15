namespace WinForms_AcademyTOP
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 75);
            label1.Name = "label1";
            label1.Size = new Size(312, 23);
            label1.TabIndex = 0;
            label1.Text = "Какой программист сегодня ты?";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(88, 135);
            button1.Name = "button1";
            button1.Size = new Size(138, 74);
            button1.TabIndex = 1;
            button1.Text = "Hello World!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Salmon;
            button2.Location = new Point(334, 135);
            button2.Name = "button2";
            button2.Size = new Size(141, 74);
            button2.TabIndex = 2;
            button2.Text = "Привет Мир!";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(158, 236);
            button3.Name = "button3";
            button3.Size = new Size(220, 70);
            button3.TabIndex = 3;
            button3.Text = "Рука-клавиатура";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 380);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hello Мир!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
