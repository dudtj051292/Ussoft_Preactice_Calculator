using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ussoft_Preactice_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            drawAnim();
        }


       private void drawAnim()
        {

            
            Point startpoint = new Point(0, panel1.Height / 2);
            int rad = panel1.Height / 8;
            double deg = 0.0;
            int cen = 10;
            
            Graphics g = panel1.CreateGraphics();

            g.Clear(panel1.BackColor);
            System.Threading.Thread.Sleep(300);
            int nx = (int)Math.Cos(deg) + rad + cen;
            int ny = (int)Math.Sin(deg) + rad + cen;
            Rectangle rect = new Rectangle(nx, ny, 20, 20);
            deg++;
            cen++;
            g.FillRectangle(Brushes.Red, rect);
            g.Dispose();
      

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void numpad_1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void numpad_2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void numpad_3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void numpad_7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void numpad_9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void numpad_5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void numpad_6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void numpad_0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void numpad_8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void numpad_4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void button_ClearAll_Click(object sender, EventArgs e)
        {
            textBox1.Text.Replace(textBox1.Text, "");
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                if(textBox1.Text.ToCharArray()[textBox1.TextLength-1] == ')')
                {
                    
                    textBox1.Text = textBox1.Text.Replace("ABS(", "");

                }
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                char c = textBox1.Text.Substring(textBox1.TextLength - 1).ToCharArray()[0];
                if ('0' <= c && '9' >= c)
                {
                    textBox1.Text += "²";
                }
            }
        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                char c = textBox1.Text.Substring(textBox1.TextLength - 1).ToCharArray()[0];
                if ('0' <= c && '9' >= c)
                {
                    Button btn = (Button)sender;
                    textBox1.Text += btn.Text;
                }
            }
            
        }

        private void button_Multifly_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                char c = textBox1.Text.Substring(textBox1.TextLength - 1).ToCharArray()[0];
                if ('0' <= c && '9' >= c)
                {
                    Button btn = (Button)sender;
                    textBox1.Text += btn.Text;
                }
            }
        }

        private void button_Minus_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                char c = textBox1.Text.Substring(textBox1.TextLength - 1).ToCharArray()[0];
                if ('0' <= c && '9' >= c)
                {
                    Button btn = (Button)sender;
                    textBox1.Text += btn.Text;
                }
            }
        }

        private void button_Plus_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                char c = textBox1.Text.Substring(textBox1.TextLength - 1).ToCharArray()[0];
                if (('0' <= c && '9' >= c) || c.ToString().Equals("²"))
                {
                    Button btn = (Button)sender;
                    textBox1.Text += btn.Text;
                }
            }
        }

        private void button_ABS_Click(object sender, EventArgs e)
        {
            char c = textBox1.Text.Substring(textBox1.TextLength - 1).ToCharArray()[0];
            if ('0' <= c && '9' >= c)
            {
                textBox1.Text = "ABS(" + textBox1.Text + ")";

            }

        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            double result = 0;
            int count = isAllNumber(textBox1.Text);

            for (int i =0; i < count; i++)
            {
                if (textBox1.Text.Contains("²"))
                {
                    String a = returnPrev(textBox1.Text, "²");
                    result = calculator(double.Parse(a), 0, 5);
                    textBox1.Text = textBox1.Text.Replace(a + "²", result.ToString());
                    continue;
                }else if (textBox1.Text.Contains("*")){
                    String a = returnPrev(textBox1.Text, "*");
                    String b = returnBack(textBox1.Text, "*");
                    result = calculator(double.Parse(a), double.Parse(b), 3);
                    textBox1.Text = textBox1.Text.Replace(a + "*" + b, result.ToString());
                    continue;
                }
                else if (textBox1.Text.Contains("/")){
                    String a = returnPrev(textBox1.Text, "/");
                    String b = returnBack(textBox1.Text, "/");
                    result = calculator(double.Parse(a), double.Parse(b), 2);
                    textBox1.Text = textBox1.Text.Replace(a + "/" + b, result.ToString());
                    continue;
                }
                else if (textBox1.Text.Contains("+")){
                    String a = returnPrev(textBox1.Text, "+");
                    String b = returnBack(textBox1.Text, "+");
                    result = calculator(double.Parse(a), double.Parse(b), 1);
                    textBox1.Text = textBox1.Text.Replace(a + "+" + b, result.ToString());
                    continue;
                }
                else if (textBox1.Text.Contains("-")){
                    String a = returnPrev(textBox1.Text, "-");
                    String b = returnBack(textBox1.Text, "-");
                    if (!a.Equals(""))
                    {
                        result = calculator(double.Parse(a), double.Parse(b), 2);
                        textBox1.Text = textBox1.Text.Replace(a + "-" + b, result.ToString());
                        continue;
                    }
                }
            }
                       
        }
        private int isAllNumber(String s)
        {
            int num = 0;
            char[] carr = s.ToCharArray();
            foreach(char c in carr)
            {
                if(!('0' <= c && '9' >= c|| c == '.'))
                {
                    num++;
                }
            }

            return num;
        }
        
        private string returnPrev(String str, String chk)
        {
            string temp = str.Substring(0, str.IndexOf(chk));
            char[] c = temp.ToCharArray();
            string a = "";
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                if ('0' <= c[i] && '9' >= c[i])
                {
                    a = temp.Substring(i);
                }
                else
                {
                    break;
                }
            }
                    return a;
        }
        private string returnBack(String str, String chk)
        {
            string temp = str.Substring(str.IndexOf(chk)+1);

            char[] c = temp.ToCharArray();
            string a = "";
            //MessageBox.Show("길이는 : "+c.Length.ToString()+"이고 \n 문자열은 "+temp+"입니다");

            if (c.Length > 1)
            {
                for (int i = 0; i < c.Length; i++)
                {
                    if ('0' <= c[i] && '9' >= c[i])
                    {
                        a += c[i].ToString();

                    }
                    else
                    {

                        break;
                    }

                }
            }
            else
            {
                a = temp;
            }
            

            return a;
        }


      

        private double calculator(double a, double b , int i)
        {
            switch (i)
            {
                case 1:
                    return a + b;
                case 2:
                    return a - b;
                case 3:
                    return a * b;
                case 4:
                    return a / b;
                case 5:
                   
                    return a * a;
                default:
                    return 0.0;
            }

        }

        private void button_Dot_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }
    }
}
