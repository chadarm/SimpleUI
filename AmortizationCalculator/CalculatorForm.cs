namespace AmortizationCalculator
{
    public partial class CalculatorForm : Form
    {

        public Amortization Amortization { get; set; }


        private float LoanAmt => float.Parse(LoanAmtTextBox.Text);
        private int NumPayments => int.Parse(NumPaymentsTextBox.Text);
        private float InterestRate => float.Parse(InterestRateTextBox.Text);

        public CalculatorForm()
        {
            InitializeComponent();
            Amortization = new Amortization();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Amortization.LoanAmount = LoanAmt;
            Amortization.InterestRate = (InterestRate /100);
            Amortization.NumPayments = NumPayments;
            Amortization.PayFrequency = PayFrequency.Monthly;

            Amortization.CalculatePaymentSchedule();
            
            AddPaymentsToGrid(Amortization.Payments);

            //foreach ( Payment payment in Amortization.Payments )
            //{
            //    MessageBox.Show(this, payment.ToString() );
            //}
        }

        private void AddPaymentsToGrid(List<Payment> payments)
        {
            foreach(Payment payment in payments)
            {
                string[] row = { payment.Index.ToString(), payment.AmountTotal.ToString(), payment.PricipalPaid.ToString(), payment.InterestPaid.ToString(), payment.RemainingBalance.ToString() };
                PaymentGrid.Rows.Add(row);
            }
        }
    }
}
