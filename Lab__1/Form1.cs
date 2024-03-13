﻿using System;
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
    }
}
