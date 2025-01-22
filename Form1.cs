namespace WinForms_AcademyTOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var tovar = new Tovar();
            TovarForm tovarForm = new TovarForm(tovar);
            if (tovarForm.ShowDialog() == DialogResult.OK)
                listBox1.Items.Add(tovar);
        }
    }
}
