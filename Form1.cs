namespace WinForms_AcademyTOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    priceBox.Text = "55,6";
                    break;
                case 1:
                    priceBox.Text = "34.6";
                    break;
                case 2:
                    priceBox.Text = "45.6";
                    break;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) { textBox1.Enabled = true; }
            else textBox1.Enabled = false;
        }
    }
}
