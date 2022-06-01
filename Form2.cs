using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ButtonYesClick(object sender, EventArgs e)
        {
            if (GamePer.getTag == "form1")
            {
                Form1 yesButton = new Form1();
                yesButton.Show();
                Hide();
            }
            if (GamePer.getTag == "form3")
            {
                Form3 yesButton = new Form3();
                yesButton.Show();
                Hide();
            }
        }

        private void ButtonNoClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClosedForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
