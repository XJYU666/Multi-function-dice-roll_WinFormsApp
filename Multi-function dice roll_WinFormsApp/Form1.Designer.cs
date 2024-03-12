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
            progressBar1 = new ProgressBar();
            textForUserBox1_2 = new TextBox();
            textForUserBox1_1 = new TextBox();
            useString = new CheckBox();
            button1 = new Button();
            textBoxOut = new TextBox();
            Run = new Button();
            backText1_1 = new Label();
            backText1_2 = new Label();
            noRound = new CheckBox();
            label1 = new Label();
            radioButtonSw1 = new RadioButton();
            radioButtonSw2 = new RadioButton();
            textForUserBox3_1 = new TextBox();
            backText3_0 = new Label();
            groupBoxOptions = new GroupBox();
            groupBoxFastM = new GroupBox();
            textBoxSwap = new TextBox();
            labelFastM = new Label();
            checkBoxFastM = new CheckBox();
            backText2_1 = new Label();
            backText2_2 = new Label();
            textForUserBox2_1 = new TextBox();
            textForUserBox2_2 = new TextBox();
            backText2_3 = new Label();
            textForUserBox2_12 = new TextBox();
            groupBoxOptions.SuspendLayout();
            groupBoxFastM.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 310);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(293, 26);
            progressBar1.TabIndex = 0;
            // 
            // textForUserBox1_2
            // 
            textForUserBox1_2.Location = new Point(82, 71);
            textForUserBox1_2.Name = "textForUserBox1_2";
            textForUserBox1_2.Size = new Size(110, 23);
            textForUserBox1_2.TabIndex = 1;
            textForUserBox1_2.Text = "1";
            textForUserBox1_2.TextChanged += textBox1_TextChanged;
            // 
            // textForUserBox1_1
            // 
            textForUserBox1_1.Cursor = Cursors.IBeam;
            textForUserBox1_1.Location = new Point(82, 39);
            textForUserBox1_1.MaxLength = 10;
            textForUserBox1_1.Name = "textForUserBox1_1";
            textForUserBox1_1.Size = new Size(110, 23);
            textForUserBox1_1.TabIndex = 2;
            textForUserBox1_1.Text = "1";
            textForUserBox1_1.TextChanged += textBox2_TextChanged;
            // 
            // useString
            // 
            useString.AutoSize = true;
            useString.Checked = true;
            useString.CheckState = CheckState.Checked;
            useString.Enabled = false;
            useString.Location = new Point(6, 49);
            useString.Name = "useString";
            useString.Size = new Size(87, 21);
            useString.TabIndex = 3;
            useString.Text = "输出纯字符";
            useString.UseVisualStyleBackColor = true;
            useString.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(281, 342);
            button1.Name = "button1";
            button1.Size = new Size(24, 112);
            button1.TabIndex = 4;
            button1.Text = "复\r\n制";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(45, 342);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.Size = new Size(230, 112);
            textBoxOut.TabIndex = 6;
            textBoxOut.TextChanged += textBox3_TextChanged;
            // 
            // Run
            // 
            Run.Location = new Point(12, 276);
            Run.Name = "Run";
            Run.Size = new Size(293, 28);
            Run.TabIndex = 8;
            Run.Text = "Run";
            Run.UseVisualStyleBackColor = true;
            Run.Click += Run_Click;
            // 
            // backText1_1
            // 
            backText1_1.AutoSize = true;
            backText1_1.Location = new Point(32, 42);
            backText1_1.Name = "backText1_1";
            backText1_1.Size = new Size(35, 17);
            backText1_1.TabIndex = 9;
            backText1_1.Text = "面数:";
            backText1_1.Click += label1_Click;
            // 
            // backText1_2
            // 
            backText1_2.AutoSize = true;
            backText1_2.Location = new Point(32, 71);
            backText1_2.Name = "backText1_2";
            backText1_2.Size = new Size(35, 17);
            backText1_2.TabIndex = 10;
            backText1_2.Text = "次数:";
            backText1_2.Click += BackTest1_2_Click;
            // 
            // noRound
            // 
            noRound.AutoSize = true;
            noRound.Location = new Point(6, 22);
            noRound.Name = "noRound";
            noRound.Size = new Size(87, 21);
            noRound.TabIndex = 11;
            noRound.Text = "去除重复项";
            noRound.UseVisualStyleBackColor = true;
            noRound.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 368);
            label1.Name = "label1";
            label1.Size = new Size(20, 68);
            label1.TabIndex = 16;
            label1.Text = "输\r\n出\r\n结\r\n果";
            label1.Click += label1_Click_1;
            // 
            // radioButtonSw1
            // 
            radioButtonSw1.AutoSize = true;
            radioButtonSw1.Checked = true;
            radioButtonSw1.Location = new Point(12, 12);
            radioButtonSw1.Name = "radioButtonSw1";
            radioButtonSw1.Size = new Size(74, 21);
            radioButtonSw1.TabIndex = 17;
            radioButtonSw1.TabStop = true;
            radioButtonSw1.Text = "骰子模式";
            radioButtonSw1.UseVisualStyleBackColor = true;
            radioButtonSw1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonSw2
            // 
            radioButtonSw2.AutoSize = true;
            radioButtonSw2.Location = new Point(12, 100);
            radioButtonSw2.Name = "radioButtonSw2";
            radioButtonSw2.Size = new Size(100, 21);
            radioButtonSw2.TabIndex = 18;
            radioButtonSw2.Text = "random 模式";
            radioButtonSw2.UseVisualStyleBackColor = true;
            radioButtonSw2.CheckedChanged += radioButtonSw2_CheckedChanged;
            // 
            // textForUserBox3_1
            // 
            textForUserBox3_1.Location = new Point(82, 199);
            textForUserBox3_1.Name = "textForUserBox3_1";
            textForUserBox3_1.Size = new Size(110, 23);
            textForUserBox3_1.TabIndex = 19;
            textForUserBox3_1.Text = ",";
            textForUserBox3_1.TextChanged += textBox4_TextChanged_1;
            // 
            // backText3_0
            // 
            backText3_0.AutoSize = true;
            backText3_0.Location = new Point(32, 202);
            backText3_0.Name = "backText3_0";
            backText3_0.Size = new Size(47, 17);
            backText3_0.TabIndex = 20;
            backText3_0.Text = "分隔符:";
            backText3_0.Click += label2_Click;
            // 
            // groupBoxOptions
            // 
            groupBoxOptions.Controls.Add(noRound);
            groupBoxOptions.Controls.Add(useString);
            groupBoxOptions.Location = new Point(198, 12);
            groupBoxOptions.Name = "groupBoxOptions";
            groupBoxOptions.Size = new Size(107, 210);
            groupBoxOptions.TabIndex = 21;
            groupBoxOptions.TabStop = false;
            groupBoxOptions.Text = "More Options";
            // 
            // groupBoxFastM
            // 
            groupBoxFastM.Controls.Add(textBoxSwap);
            groupBoxFastM.Controls.Add(labelFastM);
            groupBoxFastM.Controls.Add(checkBoxFastM);
            groupBoxFastM.Location = new Point(12, 228);
            groupBoxFastM.Name = "groupBoxFastM";
            groupBoxFastM.Size = new Size(293, 42);
            groupBoxFastM.TabIndex = 22;
            groupBoxFastM.TabStop = false;
            groupBoxFastM.Text = "快速模式";
            // 
            // textBoxSwap
            // 
            textBoxSwap.Enabled = false;
            textBoxSwap.Location = new Point(186, 13);
            textBoxSwap.Name = "textBoxSwap";
            textBoxSwap.Size = new Size(101, 23);
            textBoxSwap.TabIndex = 23;
            textBoxSwap.TextChanged += textBoxSwap_TextChanged;
            // 
            // labelFastM
            // 
            labelFastM.AutoSize = true;
            labelFastM.Enabled = false;
            labelFastM.Location = new Point(121, 16);
            labelFastM.Name = "labelFastM";
            labelFastM.Size = new Size(59, 17);
            labelFastM.TabIndex = 1;
            labelFastM.Text = "随机程度:";
            labelFastM.Click += labelFastM_Click;
            // 
            // checkBoxFastM
            // 
            checkBoxFastM.AutoSize = true;
            checkBoxFastM.Location = new Point(6, 15);
            checkBoxFastM.Name = "checkBoxFastM";
            checkBoxFastM.Size = new Size(99, 21);
            checkBoxFastM.TabIndex = 0;
            checkBoxFastM.Text = "使用快速模式";
            checkBoxFastM.UseVisualStyleBackColor = true;
            checkBoxFastM.CheckedChanged += checkBoxFastM_CheckedChanged;
            // 
            // backText2_1
            // 
            backText2_1.AutoSize = true;
            backText2_1.Enabled = false;
            backText2_1.Location = new Point(32, 130);
            backText2_1.Name = "backText2_1";
            backText2_1.Size = new Size(35, 17);
            backText2_1.TabIndex = 23;
            backText2_1.Text = "范围:";
            backText2_1.Click += label2_Click_2;
            // 
            // backText2_2
            // 
            backText2_2.AutoSize = true;
            backText2_2.Enabled = false;
            backText2_2.Location = new Point(32, 163);
            backText2_2.Name = "backText2_2";
            backText2_2.Size = new Size(35, 17);
            backText2_2.TabIndex = 24;
            backText2_2.Text = "个数:";
            backText2_2.Click += label3_Click;
            // 
            // textForUserBox2_1
            // 
            textForUserBox2_1.Enabled = false;
            textForUserBox2_1.Location = new Point(82, 127);
            textForUserBox2_1.Name = "textForUserBox2_1";
            textForUserBox2_1.Size = new Size(45, 23);
            textForUserBox2_1.TabIndex = 25;
            // 
            // textForUserBox2_2
            // 
            textForUserBox2_2.Enabled = false;
            textForUserBox2_2.Location = new Point(82, 160);
            textForUserBox2_2.Name = "textForUserBox2_2";
            textForUserBox2_2.Size = new Size(110, 23);
            textForUserBox2_2.TabIndex = 26;
            textForUserBox2_2.TextChanged += textBox2_TextChanged_1;
            // 
            // backText2_3
            // 
            backText2_3.AutoSize = true;
            backText2_3.Enabled = false;
            backText2_3.Location = new Point(128, 130);
            backText2_3.Name = "backText2_3";
            backText2_3.Size = new Size(17, 17);
            backText2_3.TabIndex = 27;
            backText2_3.Text = "~";
            // 
            // textForUserBox2_12
            // 
            textForUserBox2_12.Enabled = false;
            textForUserBox2_12.Location = new Point(147, 127);
            textForUserBox2_12.Name = "textForUserBox2_12";
            textForUserBox2_12.Size = new Size(45, 23);
            textForUserBox2_12.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(317, 466);
            Controls.Add(textForUserBox2_12);
            Controls.Add(backText2_3);
            Controls.Add(textForUserBox2_2);
            Controls.Add(textForUserBox2_1);
            Controls.Add(backText2_2);
            Controls.Add(backText2_1);
            Controls.Add(groupBoxFastM);
            Controls.Add(groupBoxOptions);
            Controls.Add(backText3_0);
            Controls.Add(textForUserBox3_1);
            Controls.Add(radioButtonSw2);
            Controls.Add(radioButtonSw1);
            Controls.Add(label1);
            Controls.Add(backText1_2);
            Controls.Add(backText1_1);
            Controls.Add(Run);
            Controls.Add(textBoxOut);
            Controls.Add(button1);
            Controls.Add(textForUserBox1_1);
            Controls.Add(textForUserBox1_2);
            Controls.Add(progressBar1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Roll - Made by XJYU";
            Load += Form1_Load;
            groupBoxOptions.ResumeLayout(false);
            groupBoxOptions.PerformLayout();
            groupBoxFastM.ResumeLayout(false);
            groupBoxFastM.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private TextBox textForUserBox1_2;
        private TextBox textForUserBox1_1;
        private CheckBox useString;
        private Button button1;
        private TextBox textBoxOut;
        private Button Run;
        private Label backText1_1;
        private Label backText1_2;
        private CheckBox noRound;
        private Label label1;
        private RadioButton radioButtonSw1;
        private RadioButton radioButtonSw2;
        private TextBox textForUserBox3_1;
        private Label backText3_0;
        private GroupBox groupBoxOptions;
        private GroupBox groupBoxFastM;
        private TextBox textBoxSwap;
        private Label labelFastM;
        private CheckBox checkBoxFastM;
        private Label backText2_1;
        private Label backText2_2;
        private TextBox textForUserBox2_1;
        private TextBox textForUserBox2_2;
        private Label backText2_3;
        private TextBox textForUserBox2_12;
    }
}