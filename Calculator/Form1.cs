namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calTotal;
        float num1;
        float num2;
        float result;
        string option;


        private void button1_Click(object sender, EventArgs e)
        {
            numTotal.Text = numTotal.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numTotal.Text = numTotal.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numTotal.Text = numTotal.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numTotal.Text = numTotal.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numTotal.Text = numTotal.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numTotal.Text = numTotal.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numTotal.Text = numTotal.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numTotal.Text = numTotal.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numTotal.Text = numTotal.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            numTotal.Text = numTotal.Text + "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            numTotal.Text = numTotal.Text + ".";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button17_Click(object sender, EventArgs e)
        {
            numTotal.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(numTotal.Text);

            numTotal.Clear();
        }


        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = float.Parse(numTotal.Text);

            numTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = float.Parse(numTotal.Text);

            numTotal.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            option = "x";
            num1 = float.Parse(numTotal.Text);

            numTotal.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(numTotal.Text);

            if (option.Equals("+"))
            {
                result = num1 + num2;
            }

            else if (option.Equals("-"))
            {
                result = num1 - num2;
            }

            else if (option.Equals("/"))
            {
                result = num1 / num2;
            }

            else if (option.Equals("x"))
            {
                result = num1 * num2;
            }

            numTotal.Text = (result + "");
        }
    }
}