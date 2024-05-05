using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace number_baseball_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox2.Focus();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox3.Focus();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox4.Focus();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            ButtonInput.Focus();
        }
    }
}
