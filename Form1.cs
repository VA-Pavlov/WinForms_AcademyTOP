namespace WinForms_AcademyTOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[i]);
                i--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text += listBox1.SelectedItem.ToString();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                label1.Text += "\n " + item.ToString();
            }
            label1.Text += comboBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            checkedListBox1.Items.Add(textBox1.Text);
            comboBox1.Items.Add(textBox1.Text);
        }
    }
}
