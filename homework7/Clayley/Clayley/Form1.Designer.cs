namespace Clayley
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.leftAn = new System.Windows.Forms.TextBox();
            this.rightAn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.leftRate = new System.Windows.Forms.TextBox();
            this.mainLen = new System.Windows.Forms.TextBox();
            this.rightRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cursiveDepth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(893, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "画";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "递归深度：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.leftAn);
            this.panel1.Controls.Add(this.rightAn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.leftRate);
            this.panel1.Controls.Add(this.mainLen);
            this.panel1.Controls.Add(this.rightRate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cursiveDepth);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 125);
            this.panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "蓝色",
            "红色",
            "黑色"});
            this.comboBox1.Location = new System.Drawing.Point(845, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(755, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "画笔颜色：";
            // 
            // leftAn
            // 
            this.leftAn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.leftAn.Location = new System.Drawing.Point(569, 89);
            this.leftAn.Name = "leftAn";
            this.leftAn.Size = new System.Drawing.Size(125, 27);
            this.leftAn.TabIndex = 8;
            // 
            // rightAn
            // 
            this.rightAn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rightAn.Location = new System.Drawing.Point(569, 53);
            this.rightAn.Name = "rightAn";
            this.rightAn.Size = new System.Drawing.Size(125, 27);
            this.rightAn.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "左分支角度：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "右分支角度：";
            // 
            // leftRate
            // 
            this.leftRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.leftRate.Location = new System.Drawing.Point(569, 6);
            this.leftRate.Name = "leftRate";
            this.leftRate.Size = new System.Drawing.Size(125, 27);
            this.leftRate.TabIndex = 6;
            // 
            // mainLen
            // 
            this.mainLen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mainLen.Location = new System.Drawing.Point(123, 50);
            this.mainLen.Name = "mainLen";
            this.mainLen.Size = new System.Drawing.Size(125, 27);
            this.mainLen.TabIndex = 7;
            // 
            // rightRate
            // 
            this.rightRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rightRate.Location = new System.Drawing.Point(123, 89);
            this.rightRate.Name = "rightRate";
            this.rightRate.Size = new System.Drawing.Size(125, 27);
            this.rightRate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "左分支长度比：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "右分支长度比：";
            // 
            // cursiveDepth
            // 
            this.cursiveDepth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cursiveDepth.Location = new System.Drawing.Point(123, 3);
            this.cursiveDepth.Name = "cursiveDepth";
            this.cursiveDepth.Size = new System.Drawing.Size(125, 27);
            this.cursiveDepth.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "主干长度：";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 353);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Label label1;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private TextBox mainLen;
        private Label label4;
        private Label label3;
        private TextBox cursiveDepth;
        private Label label2;
        private TextBox rightRate;
        private TextBox leftRate;
        private TextBox leftAn;
        private TextBox rightAn;
        private ComboBox comboBox1;
        private Label label7;
        private Panel panel2;
    }
}