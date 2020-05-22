using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _052021s19117
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            calcNum(1, no01textBox1.Text, no02textBox2.Text);
        }
        

        private void pullButton_Click(object sender, EventArgs e)
        {
            calcNum(2, no01textBox1.Text, no02textBox2.Text);
        }

        private void pullBotton_Click(object sender, EventArgs e)
        {
            calcNum(3, no01textBox1.Text, no02textBox2.Text);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            calcNum(4, no01textBox1.Text, no02textBox2.Text);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            calcNum(5, no03textBox3.Text, no04textBox4.Text);
        }
        private void calcNum(int calcValue, string num1, string num2)
        {
            HideNum();
            int value1 = 0;
            int value2 = 0;
            int errorNum = 0;
            if(int.TryParse(num1,out value1)==true&& int.TryParse(num2, out value2) == true)
            {
                if (calcValue != 5)
                {
                    switch (calcValue)
                    {
                        case 1: resultNumLabel.Text = (value1 + value2).ToString(); break;
                        case 2: resultNumLabel.Text = (value1 - value2).ToString(); break;
                        case 3: resultNumLabel.Text = (value1 * value2).ToString(); break;
                        case 4: resultNumLabel.Text = (value1 / value2).ToString(); break;
                    }
                }
                else
                {
                    int result = value1;
                    for (int i = 1, j = value2; i < j; i++)
                    {
                        result *= value1;
                    }
                    kisuresultLabel.Text = result.ToString();
                }
            }
            else
            {
                if (calcValue == 5) errorNum = 1;
                errorMessage(errorNum,num1,num2);
            }
        }
        private void errorMessage(int errorNum,string num1,string num2)
        {
            int value1 = 0;
            int value2 = 0;
            if (errorNum == 0)
            {
                if (int.TryParse(num1, out value1) == false && int.TryParse(num2, out value2) == false)
                {
                    errorconLabel.Text = "\n"+"課題１の1つ目の数値が間違って言います" + "\n" + "\n" + "課題１の2つ目の数値が間違って言います" + "\n";
                }
                else
                {
                    if (int.TryParse(num1, out value1) == false) errorconLabel.Text = "\n" + "課題１の1つ目の数値が間違って言います" + "\n";
                    if (int.TryParse(num2, out value2) == false) errorconLabel.Text = "\n" + "課題１の2つ目の数値が間違って言います" + "\n";
                }
            }
            else
            {
                if (int.TryParse(num1, out value1) == false && int.TryParse(num2, out value2) == false)
                {
                    errorconLabel.Text = "\n" + "課題2の基数が間違って言います" + "\n" + "\n" + "課題2の指数が間違って言います" + "\n";
                }
                else
                {
                    if (int.TryParse(num1, out value1) == false) errorconLabel.Text = "\n" + "課題２の基数が間違って言います" + "\n";
                    if (int.TryParse(num2, out value2) == false) errorconLabel.Text = "\n" + "課題2の指数が間違って言います" + "\n";
                }
            }
        }

        private void HideNum()
        {
            resultNumLabel.Text = "";
            kisuresultLabel.Text = "";
            errorconLabel.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideNum();
        }
    }
}
