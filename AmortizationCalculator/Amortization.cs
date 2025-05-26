using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmortizationCalculator
{

    public class Amortization
    {
        public float LoanAmount { get; set; }
        public float InterestRate { get; set; }
        public int NumPayments { get; set; }
        public PayFrequency PayFrequency { get; set; }


        public List<Payment> Payments;

        public Amortization()
        {
            Payments = new List<Payment>();
        }

        public void CalculatePaymentSchedule()
        {
            if (PayFrequency == PayFrequency.Daily)
            {
            }
            else if (PayFrequency == PayFrequency.Monthly)
            {
                float monthlyPayment = CalculateMonthlyPayment();
                float runningBalance = LoanAmount;

                for (int i = 0; i < NumPayments; i++)
                {
                    float principalPayment = monthlyPayment - (runningBalance * (InterestRate / 12));
                    float interestPayment = monthlyPayment - principalPayment;
                    runningBalance -= principalPayment;

                    Payments.Add(new Payment(i, monthlyPayment, principalPayment, interestPayment, runningBalance));
                }
            }

        }


        private float CalculateMonthlyPayment()
        {
            float MonthlyPayment;

            float MonthlyInterestRate = InterestRate  / 12;
            float PositiveInterestRate = 1 + MonthlyInterestRate;
            float PosIntToPowNumPayments = MathF.Pow(PositiveInterestRate, (float)NumPayments);

            MonthlyPayment = LoanAmount * ((MonthlyInterestRate * PosIntToPowNumPayments) / (PosIntToPowNumPayments - 1));
            return MonthlyPayment;
        }
    }

    public class Payment
    {
        public int Index;
        public float AmountTotal;
        public float PricipalPaid;
        public float InterestPaid;
        public float RemainingBalance;

        public Payment() { }
        
        public Payment(int index, float amt, float pri, float intre, float bala)
        {
            Index = index;
            AmountTotal = amt;
            PricipalPaid = pri;
            InterestPaid = intre;
            RemainingBalance = bala;
        }

        public override string ToString()
        {
            return $"Payment: {Index},\t Amount Paid: {AmountTotal}\t Remaining Balance: {RemainingBalance}";
        }
    }

    public enum PayFrequency
    {
        Daily,
        Weekly,
        BiWeekly,
        Monthly,
        Annually
    }

}
