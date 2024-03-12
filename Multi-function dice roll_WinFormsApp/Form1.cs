namespace Multi_function_dice_roll_WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackTest1_2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            backText1_1.Enabled = true;
            backText1_2.Enabled = true;
            textForUserBox1_1.Enabled = true;
            textForUserBox1_2.Enabled = true;
            backText2_1.Enabled = false;
            backText2_2.Enabled = false;
            backText2_3.Enabled = false;
            textForUserBox2_1.Enabled = false;
            textForUserBox2_12.Enabled = false;
            textForUserBox2_2.Enabled = false;
        }

        private void radioButtonSw2_CheckedChanged(object sender, EventArgs e)
        {
            backText1_1.Enabled = false;
            backText1_2.Enabled = false;
            textForUserBox1_1.Enabled = false;
            textForUserBox1_2.Enabled = false;
            backText2_1.Enabled = true;
            backText2_2.Enabled = true;
            backText2_3.Enabled = true;
            textForUserBox2_1.Enabled = true;
            textForUserBox2_12.Enabled = true;
            textForUserBox2_2.Enabled = true;
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBoxFastM_CheckedChanged(object sender, EventArgs e)
        {
            labelFastM.Enabled = checkBoxFastM.Checked;
            textBoxSwap.Enabled = checkBoxFastM.Checked;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void labelFastM_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Run_Click(object sender, EventArgs e)
        {
            string mode;
            Run Run1 = new();
            if (radioButtonSw1.Checked)
            {
                mode = "Ro";
            }
            else
            {
                mode = "Ra";
            }

            int code = Run1.Main(mode, checkBoxFastM.Checked, noRound.Checked, true, textBoxSwap.Text, textForUserBox1_1.Text, textForUserBox1_2.Text, textForUserBox2_1.Text, textForUserBox2_12.Text, textForUserBox2_2.Text, textForUserBox3_1.Text);

            switch (code)
            {
                case 0:
                    textBoxOut.Text = Run1.Output;
                    break;
                case -1:
                    textBoxOut.Text = "-1";
                    break;
                case -2:
                    textBoxOut.Text = "-2";
                    break;
                case -3:
                    textBoxOut.Text = "-3";
                    break;
                case -4:
                    textBoxOut.Text = "-4";
                    break;
                case -5:
                    textBoxOut.Text = "-5";
                    break;
                case -6:
                    textBoxOut.Text = "-6";
                    break;
                case -7:
                    textBoxOut.Text = "-7";
                    break;
            }

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void textBoxSwap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}