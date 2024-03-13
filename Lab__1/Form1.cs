using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            try
            {
                int textBoxRes = int.Parse(XTextBox.Text);
                double result = textBoxRes - (Math.Pow(textBoxRes,3)/3)+(Math.Pow(textBoxRes, 5)/5);
                ResultLabel.Text = $"Результат : {result}";
            }
            catch(Exception ex)
            {
                ResultLabel.Text = ex.Message;
            }
        }

        private void ResultButtonTab2_Click(object sender, EventArgs e)
        {
            try
            {
                int firstElement = int.Parse(firstElemTextBox.Text);
                int secondElement = int.Parse(denominatorTextBox.Text);
                int thirdElement = int.Parse(countElemTextBox.Text);

                double nElem = firstElement + secondElement * (thirdElement - 1);
                double nSum = ((firstElement + nElem)* thirdElement / 2);

                resultTab2.Text = $"Результат : {nSum}";
            }
            catch (Exception ex)
            {
                resultTab2.Text = ex.Message;
            }
        }

        private void resultTab3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(aTextBox.Text);
                int b = int.Parse(bTextBox.Text);
                int c = int.Parse(cTextBox.Text);

                if(a == b &&  b ==c)
                {
                    resultLabelTab3.Text = "Трикутник рівносторонній";
                }
                else
                {
                    resultLabelTab3.Text = "Трикутник не рівносторонній";
                }
            }
            catch (Exception ex)
            {
                resultLabelTab3.Text = ex.Message;
            }
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            try
            {
                int password = int.Parse(passwordTextBox.Text);

                switch (password)
                {
                    case 1747:
                    case 9583:
                        resultTab4.Text = "Доступні модулі : A, B, C";
                        break;
                    case 3331:
                    case 7922:
                        resultTab4.Text = "Доступні модулі : B,C";
                        break;
                    case 9455:
                    case 8997:
                        resultTab4.Text = "Доступні модулі : C";
                        break;
                }
            }
            catch (Exception ex)
            {
                resultTab4.Text = ex.Message;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.MaxLength = 10;
        }
    }
}
