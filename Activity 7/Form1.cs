namespace Activity_7
{
    public partial class ApproxPiForm : Form
    {

        private const double VAL = 4.0;

        public ApproxPiForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //initialize odd counter
            double odd = 1.0;

            //get amount of iterations
            int iter = (int) iterationInputControl.Value;

            double piApprox = 0.0;

            for (int i = 1; i <= iter; i++)
            {
                if (i == 1)
                {
                    piApprox = VAL / odd;
                }
                else if (i % 2 == 0)
                {
                    piApprox -= VAL / odd;
                }
                else
                {
                    piApprox += VAL / odd;
                }

                odd += 2;
                
            }

            answerBox.Text = "Approx Pi after " + iter + " Iterations";
            answerTextBox.Text = " =  " + piApprox;

        }
    }
}