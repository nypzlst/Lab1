namespace Lab__1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.ResultButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.countElemTextBox = new System.Windows.Forms.TextBox();
            this.denominatorTextBox = new System.Windows.Forms.TextBox();
            this.firstElemTextBox = new System.Windows.Forms.TextBox();
            this.firstElem = new System.Windows.Forms.Label();
            this.denominator = new System.Windows.Forms.Label();
            this.countElem = new System.Windows.Forms.Label();
            this.ResultButtonTab2 = new System.Windows.Forms.Button();
            this.resultTab2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.resultTab3 = new System.Windows.Forms.Button();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.resultLabelTab3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.passwordButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.resultTab4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ResultLabel);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.XTextBox);
            this.tabPage1.Controls.Add(this.ResultButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(161, 217);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(59, 13);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Результат";
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(99, 158);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(121, 20);
            this.XTextBox.TabIndex = 2;
            this.XTextBox.TextChanged += new System.EventHandler(this.XTextBox_TextChanged);
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(51, 212);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(95, 23);
            this.ResultButton.TabIndex = 1;
            this.ResultButton.Text = "Визначити Х";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.resultTab2);
            this.tabPage2.Controls.Add(this.ResultButtonTab2);
            this.tabPage2.Controls.Add(this.countElem);
            this.tabPage2.Controls.Add(this.denominator);
            this.tabPage2.Controls.Add(this.firstElem);
            this.tabPage2.Controls.Add(this.firstElemTextBox);
            this.tabPage2.Controls.Add(this.denominatorTextBox);
            this.tabPage2.Controls.Add(this.countElemTextBox);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // countElemTextBox
            // 
            this.countElemTextBox.Location = new System.Drawing.Point(174, 178);
            this.countElemTextBox.Name = "countElemTextBox";
            this.countElemTextBox.Size = new System.Drawing.Size(77, 20);
            this.countElemTextBox.TabIndex = 1;
            // 
            // denominatorTextBox
            // 
            this.denominatorTextBox.Location = new System.Drawing.Point(173, 152);
            this.denominatorTextBox.Name = "denominatorTextBox";
            this.denominatorTextBox.Size = new System.Drawing.Size(78, 20);
            this.denominatorTextBox.TabIndex = 2;
            // 
            // firstElemTextBox
            // 
            this.firstElemTextBox.Location = new System.Drawing.Point(174, 126);
            this.firstElemTextBox.Name = "firstElemTextBox";
            this.firstElemTextBox.Size = new System.Drawing.Size(77, 20);
            this.firstElemTextBox.TabIndex = 3;
            // 
            // firstElem
            // 
            this.firstElem.AutoSize = true;
            this.firstElem.Location = new System.Drawing.Point(61, 132);
            this.firstElem.Name = "firstElem";
            this.firstElem.Size = new System.Drawing.Size(73, 13);
            this.firstElem.TabIndex = 4;
            this.firstElem.Text = "Перший член";
            // 
            // denominator
            // 
            this.denominator.AutoSize = true;
            this.denominator.Location = new System.Drawing.Point(61, 158);
            this.denominator.Name = "denominator";
            this.denominator.Size = new System.Drawing.Size(64, 13);
            this.denominator.TabIndex = 5;
            this.denominator.Text = "Знаменник";
            // 
            // countElem
            // 
            this.countElem.AutoSize = true;
            this.countElem.Location = new System.Drawing.Point(61, 184);
            this.countElem.Name = "countElem";
            this.countElem.Size = new System.Drawing.Size(73, 13);
            this.countElem.TabIndex = 6;
            this.countElem.Text = "Число членів";
            // 
            // ResultButtonTab2
            // 
            this.ResultButtonTab2.Location = new System.Drawing.Point(61, 232);
            this.ResultButtonTab2.Name = "ResultButtonTab2";
            this.ResultButtonTab2.Size = new System.Drawing.Size(126, 23);
            this.ResultButtonTab2.TabIndex = 7;
            this.ResultButtonTab2.Text = "Знайти суму";
            this.ResultButtonTab2.UseVisualStyleBackColor = true;
            this.ResultButtonTab2.Click += new System.EventHandler(this.ResultButtonTab2_Click);
            // 
            // resultTab2
            // 
            this.resultTab2.AutoSize = true;
            this.resultTab2.Location = new System.Drawing.Point(211, 232);
            this.resultTab2.Name = "resultTab2";
            this.resultTab2.Size = new System.Drawing.Size(65, 13);
            this.resultTab2.TabIndex = 8;
            this.resultTab2.Text = "Результат :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.resultLabelTab3);
            this.tabPage3.Controls.Add(this.cLabel);
            this.tabPage3.Controls.Add(this.bLabel);
            this.tabPage3.Controls.Add(this.aLabel);
            this.tabPage3.Controls.Add(this.aTextBox);
            this.tabPage3.Controls.Add(this.cTextBox);
            this.tabPage3.Controls.Add(this.bTextBox);
            this.tabPage3.Controls.Add(this.resultTab3);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.resultTab4);
            this.tabPage4.Controls.Add(this.passLabel);
            this.tabPage4.Controls.Add(this.passwordTextBox);
            this.tabPage4.Controls.Add(this.passwordButton);
            this.tabPage4.Controls.Add(this.pictureBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(768, 400);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // resultTab3
            // 
            this.resultTab3.Location = new System.Drawing.Point(40, 221);
            this.resultTab3.Name = "resultTab3";
            this.resultTab3.Size = new System.Drawing.Size(90, 23);
            this.resultTab3.TabIndex = 1;
            this.resultTab3.Text = "Розрохувати";
            this.resultTab3.UseVisualStyleBackColor = true;
            this.resultTab3.Click += new System.EventHandler(this.resultTab3_Click);
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(119, 150);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(143, 20);
            this.bTextBox.TabIndex = 2;
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(119, 176);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(143, 20);
            this.cTextBox.TabIndex = 3;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(119, 124);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(143, 20);
            this.aTextBox.TabIndex = 4;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(37, 127);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(14, 13);
            this.aLabel.TabIndex = 5;
            this.aLabel.Text = "A";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(37, 150);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(14, 13);
            this.bLabel.TabIndex = 6;
            this.bLabel.Text = "B";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(37, 179);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(14, 13);
            this.cLabel.TabIndex = 7;
            this.cLabel.Text = "C";
            // 
            // resultLabelTab3
            // 
            this.resultLabelTab3.AutoSize = true;
            this.resultLabelTab3.Location = new System.Drawing.Point(152, 226);
            this.resultLabelTab3.Name = "resultLabelTab3";
            this.resultLabelTab3.Size = new System.Drawing.Size(65, 13);
            this.resultLabelTab3.TabIndex = 8;
            this.resultLabelTab3.Text = "Результат :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab__1.Properties.Resources.Снимок_экрана_2024_03_08_114343;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(51, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(651, 116);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab__1.Properties.Resources.Снимок_экрана_2024_03_13_111645;
            this.pictureBox2.Location = new System.Drawing.Point(61, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(663, 52);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Lab__1.Properties.Resources.Снимок_экрана_2024_03_13_115025;
            this.pictureBox3.Location = new System.Drawing.Point(40, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(707, 74);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Lab__1.Properties.Resources.Снимок_экрана_2024_03_13_120034;
            this.pictureBox4.Location = new System.Drawing.Point(67, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(655, 121);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // passwordButton
            // 
            this.passwordButton.Location = new System.Drawing.Point(67, 223);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(75, 23);
            this.passwordButton.TabIndex = 1;
            this.passwordButton.Text = "Увійти";
            this.passwordButton.UseVisualStyleBackColor = true;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(210, 161);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(64, 168);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(84, 13);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Введіть пароль";
            // 
            // resultTab4
            // 
            this.resultTab4.AutoSize = true;
            this.resultTab4.Location = new System.Drawing.Point(207, 228);
            this.resultTab4.Name = "resultTab4";
            this.resultTab4.Size = new System.Drawing.Size(94, 13);
            this.resultTab4.TabIndex = 4;
            this.resultTab4.Text = "Доступні модулі :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ResultButtonTab2;
        private System.Windows.Forms.Label countElem;
        private System.Windows.Forms.Label denominator;
        private System.Windows.Forms.Label firstElem;
        private System.Windows.Forms.TextBox firstElemTextBox;
        private System.Windows.Forms.TextBox denominatorTextBox;
        private System.Windows.Forms.TextBox countElemTextBox;
        private System.Windows.Forms.Label resultTab2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label resultLabelTab3;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Button resultTab3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label resultTab4;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button passwordButton;
    }
}

