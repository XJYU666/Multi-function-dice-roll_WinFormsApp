namespace Multi_function_dice_roll_WinFormsApp
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BackTest1_1 = new System.Windows.Forms.Label();
            this.BackTest1_2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonSw1 = new System.Windows.Forms.RadioButton();
            this.radioButtonSw2 = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BackTest1_3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 294);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(293, 26);
            this.progressBar1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Location = new System.Drawing.Point(82, 39);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(203, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 112);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(45, 326);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(230, 112);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BackTest1_1
            // 
            this.BackTest1_1.AutoSize = true;
            this.BackTest1_1.Location = new System.Drawing.Point(32, 42);
            this.BackTest1_1.Name = "BackTest1_1";
            this.BackTest1_1.Size = new System.Drawing.Size(35, 17);
            this.BackTest1_1.TabIndex = 9;
            this.BackTest1_1.Text = "面数:";
            this.BackTest1_1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BackTest1_2
            // 
            this.BackTest1_2.AutoSize = true;
            this.BackTest1_2.Location = new System.Drawing.Point(32, 71);
            this.BackTest1_2.Name = "BackTest1_2";
            this.BackTest1_2.Size = new System.Drawing.Size(35, 17);
            this.BackTest1_2.TabIndex = 10;
            this.BackTest1_2.Text = "次数:";
            this.BackTest1_2.Click += new System.EventHandler(this.BackTest1_2_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(203, 71);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 21);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // radioButtonSw1
            // 
            this.radioButtonSw1.AutoSize = true;
            this.radioButtonSw1.Checked = true;
            this.radioButtonSw1.Location = new System.Drawing.Point(12, 12);
            this.radioButtonSw1.Name = "radioButtonSw1";
            this.radioButtonSw1.Size = new System.Drawing.Size(102, 21);
            this.radioButtonSw1.TabIndex = 17;
            this.radioButtonSw1.TabStop = true;
            this.radioButtonSw1.Text = "radioButton1";
            this.radioButtonSw1.UseVisualStyleBackColor = true;
            this.radioButtonSw1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonSw2
            // 
            this.radioButtonSw2.AutoSize = true;
            this.radioButtonSw2.Location = new System.Drawing.Point(12, 126);
            this.radioButtonSw2.Name = "radioButtonSw2";
            this.radioButtonSw2.Size = new System.Drawing.Size(102, 21);
            this.radioButtonSw2.TabIndex = 18;
            this.radioButtonSw2.Text = "radioButton2";
            this.radioButtonSw2.UseVisualStyleBackColor = true;
            this.radioButtonSw2.CheckedChanged += new System.EventHandler(this.radioButtonSw2_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(82, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(110, 23);
            this.textBox4.TabIndex = 19;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // BackTest1_3
            // 
            this.BackTest1_3.AutoSize = true;
            this.BackTest1_3.Location = new System.Drawing.Point(32, 100);
            this.BackTest1_3.Name = "BackTest1_3";
            this.BackTest1_3.Size = new System.Drawing.Size(47, 17);
            this.BackTest1_3.TabIndex = 20;
            this.BackTest1_3.Text = "分隔符:";
            this.BackTest1_3.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.BackTest1_3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.radioButtonSw2);
            this.Controls.Add(this.radioButtonSw1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.BackTest1_2);
            this.Controls.Add(this.BackTest1_1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Roll - Made by XJYU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progressBar1;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox textBox3;
        private Button button2;
        private Label BackTest1_1;
        private Label BackTest1_2;
        private CheckBox checkBox2;
        private Label label1;
        private RadioButton radioButtonSw1;
        private RadioButton radioButtonSw2;
        private TextBox textBox4;
        private Label BackTest1_3;
    }
}