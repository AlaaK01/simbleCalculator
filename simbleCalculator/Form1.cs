namespace simbleCalculator
{
    public partial class Form1 : Form
    {
        double number1;
        double number2;
        double result;
        string operationResult;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (label4.Text == "0")
            {
                label4.Text = "";
                label4.Text = label4.Text + btn.Text;
                
            }
            else
            {
                label4.Text = label4.Text + btn.Text;
                
            }
            if(label3.Text != "")
            {
                label3.Text = label3.Text + btn.Text;
            }
            else
            {
                label3.Text = label4.Text;
            }
        }

        private void operationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            number1 = Convert.ToDouble(label4.Text);
            operationResult = button.Text;
            if(label3.Text != "")
            {
            label3.Text = label3.Text + operationResult;
            }
            else
            {
                label3.Text = label4.Text + operationResult;
            }
            label4.Text = "";
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(label4.Text);
            if(operationResult == "+")
            {
                result = number1 + number2;
                label4.Text = Convert.ToString(result);
            }
            else if (operationResult == "-")
            {
                result = number1 - number2;
                label4.Text = Convert.ToString(result);
            }
            else if (operationResult == "*")
            {
                result = number1 * number2;
                label4.Text = Convert.ToString(result);
            }
            else if (operationResult == "/")
            {
                result = number1 / number2;
                label4.Text = Convert.ToString(result);
            }
            label3.Text = "";
        }
    }
}