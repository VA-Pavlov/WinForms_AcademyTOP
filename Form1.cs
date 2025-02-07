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

        private void êðàñåûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void êðàñíûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void ïÏ11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Arial", 14);
        }

        private void ïÏ12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Arial", 20);

        }
    }
}
