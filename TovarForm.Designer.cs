namespace WinForms_AcademyTOP
{
    partial class TovarForm
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
            components = new System.ComponentModel.Container();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            numericUpDown1 = new NumericUpDown();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            proizvodGroupBox = new GroupBox();
            label1 = new Label();
            saveButton = new Button();
            button2 = new Button();
            toolTip1 = new ToolTip(components);
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            proizvodGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(33, 29);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(128, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Название товара";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(27, 52);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(320, 27);
            nameTextBox.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(227, 198);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 56);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(92, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Крупская";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(100, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Конти-Рус";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(151, 26);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(149, 24);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Красный октябрь";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(151, 56);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(112, 24);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "Славяночка";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // proizvodGroupBox
            // 
            proizvodGroupBox.Controls.Add(radioButton2);
            proizvodGroupBox.Controls.Add(radioButton4);
            proizvodGroupBox.Controls.Add(radioButton1);
            proizvodGroupBox.Controls.Add(radioButton3);
            proizvodGroupBox.Location = new Point(27, 85);
            proizvodGroupBox.Name = "proizvodGroupBox";
            proizvodGroupBox.Size = new Size(320, 100);
            proizvodGroupBox.TabIndex = 7;
            proizvodGroupBox.TabStop = false;
            proizvodGroupBox.Text = "Производитель";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 200);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 8;
            label1.Text = "Количество на складе";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(33, 275);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(316, 35);
            saveButton.TabIndex = 9;
            saveButton.Text = "Сохранить";
            toolTip1.SetToolTip(saveButton, "Сохранить введенные данные");
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(33, 316);
            button2.Name = "button2";
            button2.Size = new Size(314, 32);
            button2.TabIndex = 10;
            button2.Text = "Отменить";
            button2.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Сохранить";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 235);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 11;
            label2.Text = "Стоимость (шт)";
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(227, 233);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 27);
            numericUpDown2.TabIndex = 12;
            // 
            // TovarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 361);
            Controls.Add(numericUpDown2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(saveButton);
            Controls.Add(label1);
            Controls.Add(proizvodGroupBox);
            Controls.Add(numericUpDown1);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TovarForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Карточка товара";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            proizvodGroupBox.ResumeLayout(false);
            proizvodGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private NumericUpDown numericUpDown1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox proizvodGroupBox;
        private Label label1;
        private Button saveButton;
        private Button button2;
        private ToolTip toolTip1;
        private Label label2;
        private NumericUpDown numericUpDown2;
    }
}