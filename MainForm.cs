using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            tovarsComboBox.Items.Clear();
            tovarsComboBox.Items.AddRange(Sclad.GetTovars().ToArray());
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            decimal price = 0;
            foreach (var item in checkedListBox1.CheckedItems)
            {
                price += (item as TovarPrice).Tovar.Price * (item as TovarPrice).Count;
            }
            priceLabel.Text = price.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ansver = "Чек\n";
            foreach (TovarPrice item in checkedListBox1.CheckedItems)
            {
                ansver += $"{item.Tovar.Name} - {item.Tovar.Price}р.*{item.Count}\t{item.Count*item.Tovar.Price} руб.\n";
            }
            ansver += $"Итог: {priceLabel.Text} руб.";
            MessageBox.Show(ansver);
            checkedListBox1.Items.Clear();
            numericUpDown1.Value = 0;
            priceLabel.Text = "0,0";

        }
    }
}
