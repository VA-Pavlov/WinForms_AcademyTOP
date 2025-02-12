using System;

namespace WinForms_AcademyTOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Width = 100;
            label1.Height = 50;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = e.X + ":" + e.Y;
            label3.Text = label1.Left + ":" + label1.Top + "\n " + label1.Left + ":" + (label1.Top+50);

            var bufer = 25;
            if(e.X>=label1.Left-bufer && e.X <= label1.Right + bufer && e.Y>= label1.Top-bufer && e.Y<=label1.Bottom + bufer)
            {
                label1.BackColor = Color.Red;

                var obshDlinna = (label1.Right + bufer) - (label1.Left - bufer);
                var leftDlinna = e.X - (label1.Left - bufer);
                var rightDlinna = (label1.Right + bufer) - e.X;

                if (obshDlinna - leftDlinna > obshDlinna - rightDlinna)
                {
                    label1.Left = label1.Left + 10;
                }
                else
                    label1.Left = label1.Left - 10;

                var obshVisota = (label1.Bottom + bufer) - (label1.Top - bufer);
                var topVisota = e.Y - (label1.Top - bufer);
                var buttomVisota = (label1.Bottom + bufer) - e.Y;

                if(obshVisota-topVisota > obshVisota - buttomVisota)
                {
                    label1.Top = label1.Top + 10;
                }
                else
                    label1.Top= label1.Top - 10;
            }
            else
                label1.BackColor = Color.Green;

            //if (label1.Left + label1.Width > this.ClientSize.Width)
            //    label1.Left = this.ClientSize.Width - label1.Width;

            //if (label1.Top + label1.Height > this.ClientSize.Height)
            //    label1.Top = this.ClientSize.Height - label1.Height;
           

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Left = e.X; label1.Top = e.Y;
        }
    }
}
