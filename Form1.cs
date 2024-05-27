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
            Init();
        }

        private void Init()
        {
            // 4자리 난수 만들기
            List<int> numbers = new List<int>();

            Random random = new Random();

            numbers.Add(random.Next(1, 10));

            while (numbers.Count < 4)
            {
                int r = random.Next(0, 10);
                
                if (numbers.Find(x => x == r) == 0)
                {
                    numbers.Add(r);
                }
            }
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
