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
            MessageBox.Show(radioButton1.Checked.ToString()+"\n"
                +checkBox1.Checked+checkBox1.Text+" \n"
                + dateTimePicker1.Value
                +"\n"+monthCalendar1);
        }
    }
}
