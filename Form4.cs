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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            //var m = new MessageBox();
            MessageBox.Show("Добро пожаловать в игру! Игра заключается в том, чтобы собрать как можно больше очков-алмазов. " +
                "Чтобы пройти на следующий уровень, нужно пройти через дверь, но чтобы это сдлеать, сначала нужно отыскать сокровище!");
        }

        private void lvl1Click(object sender, EventArgs e)
        {
            Form1 level1 = new Form1();
            level1.Show();
            Hide();
        }

        private void lvl2Clicl(object sender, EventArgs e)
        {
            Form3 level2 = new Form3();
            level2.Show();
            Hide();
        }
    }
}
