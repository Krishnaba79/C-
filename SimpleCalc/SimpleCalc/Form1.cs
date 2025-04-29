namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the numbers from the input fields
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);

                // Get the selected operator from the dropdown
                string operation = cmbOperator.SelectedItem.ToString();

                double result = 0;

                // Perform the operation based on the selected operator
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            MessageBox.Show("Cannot divide by zero!");
                        break;
                    default:
                        MessageBox.Show("Please select a valid operator.");
                        break;
                }

                // Display the result
                lblResult.Text = $"Result: {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear all inputs and results
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            cmbOperator.SelectedIndex = -1;
            lblResult.Text = "Result: ";
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
