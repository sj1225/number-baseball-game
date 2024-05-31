using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            InitializeGame();
        }

        List<int> answer = new List<int>();
        int count = 0;

        private void InitializeGame()
        {
            /* 화면 구성 요소 초기화 */
            TextBox1.Enabled = true;
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            TextBox4.Enabled = true;
            ButtonInput.Enabled = true;

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

            TextBox1.Focus();

            lbInform.Text = "4자리 숫자를 입력해주세요.";
            lbResults.Text = "";

            answer.Clear();

            /* 4자리 랜덤 숫자 생성 */
            Random random = new Random();

            answer.Add(random.Next(1, 10));

            while (answer.Count < 4)
            {
                int r = random.Next(0, 10);
                
                if (answer.Find(x => x == r) == 0)
                {
                    answer.Add(r);
                }
            }
        }

        private void Check()
        {
            string text1 = TextBox1.Text;
            string text2 = TextBox2.Text;
            string text3 = TextBox3.Text;
            string text4 = TextBox4.Text;

            if(!int.TryParse(text1, out _) || !int.TryParse(text2, out _) || !int.TryParse(text3, out _) || !int.TryParse(text4, out _))
            {
                lbInform.Text = "입력한 값이 올바르지 않습니다.";
            }
            else
            {
                List<int> input = new List<int>
                {
                    int.Parse(text1),
                    int.Parse(text2),
                    int.Parse(text3),
                    int.Parse(text4)
                };

                if ((answer[0] == input[0]) && (answer[1] == input[1]) && (answer[2] == input[2]) && (answer[3] == input[3]))
                {
                    lbInform.Text = "정답입니다!!!";
                    TextBox1.Enabled = false;
                    TextBox2.Enabled = false;
                    TextBox3.Enabled = false;
                    TextBox4.Enabled = false;
                    ButtonInput.Enabled = false;
                }
                else
                {
                    List<int> result = new List<int>
                    {
                        0, 0, 0
                    }; // S B O

                    for (int i = 0; i < 4; i++)
                    {
                        if (input[i] == answer[i])
                        {
                            result[0]++;
                        }
                        else if (answer.Count(n => n == input[i]) > 0)
                        {
                            result[1]++;
                        }
                        else
                        {
                            result[2]++;
                        }
                    }

                    count++;

                    lbResults.Text = count + "회 | " + input[0] + " " + input[1] + " " + input[2] + " " + input[3] + " | "
                                + result[0] + "S " + result[1] + "B " + result[2] + "O" + "\n"
                        + lbResults.Text;

                    if (count == 20)
                    {
                        lbInform.Text = "게임이 종료되었습니다.";
                        TextBox1.Enabled = false;
                        TextBox2.Enabled = false;
                        TextBox3.Enabled = false;
                        TextBox4.Enabled = false;
                        ButtonInput.Enabled = false;
                    } else
                    {
                        lbInform.Text = "틀렸습니다. 다시 입력하세요.";
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox1.Focus();
                    }
                }
            }
        }

        /* Events */
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 1) TextBox2.Focus();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (TextBox2.Text.Length == 1) TextBox3.Focus();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (TextBox3.Text.Length == 1) TextBox4.Focus();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (TextBox4.Text.Length == 1) ButtonInput.Focus();
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void ButtonInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.GetHashCode() == 13) Check();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }
    }
}
