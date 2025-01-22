using WinForms_AcademyTOP.Properties;

namespace WinForms_AcademyTOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.AddRange(Sclad.GetTovars().ToArray());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var tovar = new Tovar();
            TovarForm tovarForm = new TovarForm(tovar);
            if (tovarForm.ShowDialog() == DialogResult.OK)
                listBox1.Items.Add(tovar);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var tovar = (Tovar)listBox1.SelectedItem;
            TovarForm tovarForm = new TovarForm(tovar);
            if (tovarForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Remove(tovar);
                listBox1.Items.Add(tovar);
            }
                
        }
    }
}
