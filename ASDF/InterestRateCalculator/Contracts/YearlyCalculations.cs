namespace InterestRateCalculator.Contracts
{
    public class YearlyCalculations
    {
        public decimal PaymentPerCheck { get; set; }
        /// <summary>
        /// Payment Per Check, 2 checks per month, 12 months in a year, ~1/3 of salary
        /// </summary>
        public decimal ExpectedIncome
        {
            get
            {
                return PaymentPerCheck * 2 * 12 * 3;
            }
        }
        public decimal InterestForYear { get; set; }

        public YearlyCalculations(decimal paymentPerCheck)
        {
            PaymentPerCheck = paymentPerCheck;
        }

        public override string ToString()
        {
            return $"Payment per check: {PaymentPerCheck:C}\tExpected minumum income: {ExpectedIncome:C}\tExpected interest for year: {InterestForYear:C}";
        }

        public string Join(string separator)
        {
            return string.Join(separator, $"${PaymentPerCheck}", $"${ExpectedIncome}", $"${InterestForYear}");
        }
    }
}
