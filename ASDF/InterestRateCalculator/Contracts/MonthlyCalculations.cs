using System;

namespace InterestRateCalculator.Contracts
{
    public class MonthlyCalculations
    {
        public DateTime Timestamp { get; set; }
        public decimal CurrentValue { get; set; }
        public decimal InterestValue { get; set; }
        public decimal CurrentInterestRate { get; set; }

        public override string ToString()
        {
            return $"Date: {Timestamp.Date}\tValue: {CurrentValue:C}\tInterest: {InterestValue:C}\tRate: {CurrentInterestRate * 100}%";
        }

        public string Join(string separator)
        {
            return string.Join(separator, Timestamp.Date, $"${CurrentValue}", $"${InterestValue}", $"{CurrentInterestRate * 100}%");
        }
    }
}
