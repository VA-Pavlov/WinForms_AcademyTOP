namespace WinForms_AcademyTOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bfgbfgfbgbfg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Выберите один из вариантов",
        "Сообщение",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
