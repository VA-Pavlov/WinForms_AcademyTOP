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
            listBox1 = new ListBox();
            deleteButton = new Button();
            addButton = new Button();
            editButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 17);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(385, 304);
            listBox1.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(6, 385);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(385, 23);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Удалить товар";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(6, 327);
            addButton.Name = "addButton";
            addButton.Size = new Size(385, 23);
            addButton.TabIndex = 2;
            addButton.Text = "Добавить товар";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(6, 356);
            editButton.Name = "editButton";
            editButton.Size = new Size(385, 23);
            editButton.TabIndex = 3;
            editButton.Text = "Изменить товар";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 414);
            button1.Name = "button1";
            button1.Size = new Size(385, 23);
            button1.TabIndex = 4;
            button1.Text = "Вернуться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(403, 454);
            Controls.Add(button1);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(deleteButton);
            Controls.Add(listBox1);
            Cursor = Cursors.SizeAll;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Товары";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button deleteButton;
        private Button addButton;
        private Button editButton;
        private Button button1;
    }
}
