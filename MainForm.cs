using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_AcademyTOP.Properties;

namespace WinForms_AcademyTOP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            tovarsComboBox.Items.AddRange(Sclad.GetTovars().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TovarPrice tovarPrice = new TovarPrice(
                (Tovar)tovarsComboBox.SelectedItem,
                (int)numericUpDown1.Value);
            checkedListBox1.Items.Add(tovarPrice);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.ShowDialog();
        }
    }
}
