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

        List<int> numbers = new List<int>();

        private void Init()
        {
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

        private void ButtonInput_OnEvene(object sender, EventArgs e)
        {
            ButtonInput.Focus();
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void ButtonInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.GetHashCode() == 13)
            {
                Check();
            }
        }

        private void Check()
        {
            Console.WriteLine("> Check");

            string text1 = TextBox1.Text;
            string text2 = TextBox2.Text;
            string text3 = TextBox3.Text;
            string text4 = TextBox4.Text;

            if(text1.Equals("") || text2.Equals("") || text3.Equals("") || text4.Equals(""))
            {
                // 입력되지 않은 값이 있음
                Console.WriteLine(">> Input Error!!!");
            }
            else
            {
                Console.WriteLine(">> Check Input...");

                List<int> input = new List<int>
                {
                    int.Parse(text1),
                    int.Parse(text2),
                    int.Parse(text3),
                    int.Parse(text4)
                };

                if (numbers.Equals(input))
                {
                    // 정답
                    Console.WriteLine(">>> Correct!!!");
                }
                else
                {
                    Console.WriteLine(">>> Wrong...");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox1.Focus();
                }
            }
        }
    }
}
