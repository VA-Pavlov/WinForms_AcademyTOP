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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            пункт1ToolStripMenuItem = new ToolStripMenuItem();
            пП11ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            пП12ToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            пункт2ToolStripMenuItem = new ToolStripMenuItem();
            красеыйToolStripMenuItem = new ToolStripMenuItem();
            зеленыйToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            красныйToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { пункт1ToolStripMenuItem, пункт2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // пункт1ToolStripMenuItem
            // 
            пункт1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { пП11ToolStripMenuItem, toolStripMenuItem1, пП12ToolStripMenuItem, toolStripComboBox1 });
            пункт1ToolStripMenuItem.Name = "пункт1ToolStripMenuItem";
            пункт1ToolStripMenuItem.Size = new Size(61, 20);
            пункт1ToolStripMenuItem.Text = "Пункт 1";
            // 
            // пП11ToolStripMenuItem
            // 
            пП11ToolStripMenuItem.Name = "пП11ToolStripMenuItem";
            пП11ToolStripMenuItem.Size = new Size(181, 22);
            пП11ToolStripMenuItem.Text = "ПП1.1";
            пП11ToolStripMenuItem.Click += пП11ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(178, 6);
            // 
            // пП12ToolStripMenuItem
            // 
            пП12ToolStripMenuItem.Name = "пП12ToolStripMenuItem";
            пП12ToolStripMenuItem.Size = new Size(181, 22);
            пП12ToolStripMenuItem.Text = "ПП1.2";
            пП12ToolStripMenuItem.Click += пП12ToolStripMenuItem_Click;
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            toolStripComboBox1.Click += toolStripComboBox1_Click;
            // 
            // пункт2ToolStripMenuItem
            // 
            пункт2ToolStripMenuItem.Checked = true;
            пункт2ToolStripMenuItem.CheckOnClick = true;
            пункт2ToolStripMenuItem.CheckState = CheckState.Checked;
            пункт2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { красеыйToolStripMenuItem, зеленыйToolStripMenuItem });
            пункт2ToolStripMenuItem.Name = "пункт2ToolStripMenuItem";
            пункт2ToolStripMenuItem.Size = new Size(59, 20);
            пункт2ToolStripMenuItem.Text = "пункт 2";
            // 
            // красеыйToolStripMenuItem
            // 
            красеыйToolStripMenuItem.BackColor = Color.OrangeRed;
            красеыйToolStripMenuItem.CheckOnClick = true;
            красеыйToolStripMenuItem.Name = "красеыйToolStripMenuItem";
            красеыйToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            красеыйToolStripMenuItem.Size = new Size(164, 22);
            красеыйToolStripMenuItem.Text = "красеый";
            красеыйToolStripMenuItem.Click += красеыйToolStripMenuItem_Click;
            // 
            // зеленыйToolStripMenuItem
            // 
            зеленыйToolStripMenuItem.BackColor = Color.MediumSeaGreen;
            зеленыйToolStripMenuItem.CheckOnClick = true;
            зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            зеленыйToolStripMenuItem.Size = new Size(164, 22);
            зеленыйToolStripMenuItem.Text = "зеленый";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { красныйToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 26);
            // 
            // красныйToolStripMenuItem
            // 
            красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            красныйToolStripMenuItem.Size = new Size(122, 22);
            красныйToolStripMenuItem.Text = "красный";
            красныйToolStripMenuItem.Click += красныйToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(716, 382);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem пункт1ToolStripMenuItem;
        private ToolStripMenuItem пП11ToolStripMenuItem;
        private ToolStripMenuItem пП12ToolStripMenuItem;
        private ToolStripMenuItem пункт2ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem красеыйToolStripMenuItem;
        private ToolStripMenuItem зеленыйToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem красныйToolStripMenuItem;
        private TextBox textBox1;
    }
}
