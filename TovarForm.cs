using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_AcademyTOP
{
    public partial class TovarForm : Form
    {
        Tovar NewTovar;
        RadioButton[] radioButtons;
        public TovarForm(Tovar tovar)
        {
            InitializeComponent();
            NewTovar = tovar;
            radioButtons = new RadioButton[] { radioButton2, radioButton1, radioButton3, radioButton4};

            if (NewTovar != null )
            {
                nameTextBox.Text = NewTovar.Name;
                numericUpDown1.Value = NewTovar.ValueInSclad;
                numericUpDown2.Value = NewTovar.Price;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            NewTovar.Name = nameTextBox.Text;
            foreach(RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    NewTovar.Proisvoditel = radioButton.Text;
                }
            }
            NewTovar.Price = numericUpDown2.Value;
            NewTovar.ValueInSclad = (int)numericUpDown1.Value;
            this.DialogResult = DialogResult.OK;
        }
    }
}
