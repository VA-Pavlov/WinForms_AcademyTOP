namespace WinForms_AcademyTOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void красеыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void пѕ11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Arial", 14);
        }

        private void пѕ12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Arial", 20);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TextFile = "";
            OpenFileDialog open = new OpenFileDialog();
            // создали экземпл€р установим фильтр дл€ файлов
            open.Filter = "All txt files (*.txt)|*.txt";
            open.FilterIndex = 1;// по умолчанию фильтруютс€
                                 // текстовые файлы
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                TextFile = reader.ReadToEnd(); // считываем файл до конца
                reader.Close(); // закрываем reader
            }
            textBox1.Text = TextFile;
        }

        private void wdtnNtrcnfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }
    }
}
