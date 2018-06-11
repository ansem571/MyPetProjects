using InterestRateCalculator.Contracts;
using InterestRateCalculator.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace InterestRateCalculator.Services.Implementations
{
    public class CalculateInterestService : ICalculateInterestService
    {
        private readonly List<int> _checkDates = new List<int> { 1, 15 };
        private readonly int _accrualDate = 25;
        private decimal _expectedMinimumIncome;
        private readonly int _checksPerMonth;
        private readonly int _monthsPerYear = 12;
        private readonly int _approximatePercentageOfCheck = 3; // 1/3 of check
        private readonly ILogger _logger;

        public CalculateInterestService(ILogger logger, List<int> checkDates = null)
        {
            _logger = logger;
            _checkDates = checkDates ?? _checkDates;
            _checksPerMonth = _checkDates.Count;
        }
        //Example values: 4024.84m, 0.016m, 200, 500, DateTime.Today
        public decimal CalculateInterestByMonths(decimal currentValue, decimal rate, int months, decimal paymentPerCheck, DateTime startDate)
        {
            var total = currentValue;
            var currentDate = startDate.AddDays(1);
            var interest = 0.00m;
            var month = 0;
            _expectedMinimumIncome = currentValue * _checksPerMonth * _monthsPerYear * _approximatePercentageOfCheck;
            var yearlyData = new YearlyCalculations(paymentPerCheck);
            var monthlyData = new MonthlyCalculations();
            var interestForYear = 0.00m;

            _logger?.LogInformation($"{startDate},,,,{yearlyData.Join(",")}");
            while (month < months)
            {
                interest += Math.Round(total * rate / 365, 2);
                if (_checkDates.Contains(currentDate.Day))
                {
                    total += paymentPerCheck;
                }
                if (currentDate.Day == _accrualDate)
                {
                    if (currentDate.Month % 2 == 1)
                    {
                        rate += 0.001m;
                        if (rate > 0.0225m)
                            rate = 0.0225m;
                    }
                    total += interest;
                    interestForYear += interest;
                    monthlyData.Timestamp = currentDate;
                    monthlyData.CurrentValue = total;
                    monthlyData.InterestValue = interest;
                    monthlyData.CurrentInterestRate = rate;

                    _logger?.LogInformation(monthlyData.Join(","));
                    interest = 0;
                    month++;
                }
                currentDate = currentDate.AddDays(1);

                if (currentDate.DayOfYear == startDate.DayOfYear)
                {
                    paymentPerCheck += 100;
                    _expectedMinimumIncome = currentValue * _checksPerMonth * _monthsPerYear * _approximatePercentageOfCheck;
                    yearlyData.PaymentPerCheck = paymentPerCheck;
                    yearlyData.InterestForYear = interestForYear;
                    _logger?.LogInformation($"{currentDate},,,,{yearlyData.Join(",")}");
                    interestForYear = 0;
                }
            }
            return total;
        }

        public decimal CalculateInterestByYears(decimal currentValue, decimal rate, int years, decimal paymentPerCheck, DateTime startDate)
        {
            var total = currentValue;
            var currentDate = startDate.AddDays(1);
            var interest = 0.00m;
            var year = 0;
            _expectedMinimumIncome = currentValue * _checksPerMonth * _monthsPerYear * _approximatePercentageOfCheck;
            var yearlyData = new YearlyCalculations(paymentPerCheck);
            var monthlyData = new MonthlyCalculations();
            var interestForYear = 0.00m;

            _logger?.LogInformation($"{startDate},,,,{yearlyData.Join(",")}");
            while (year < years)
            {
                while (true)
                {
                    interest += Math.Round(total * rate / 365, 2);
                    if (_checkDates.Contains(currentDate.Day))
                    {
                        total += paymentPerCheck;
                    }
                    if (currentDate.Day == _accrualDate)
                    {
                        if (currentDate.Month % 2 == 1)
                        {
                            rate += 0.001m;
                            if (rate > 0.0225m)
                                rate = 0.0225m;
                        }
                        total += interest;
                        interestForYear += interest;
                        monthlyData.Timestamp = currentDate;
                        monthlyData.CurrentValue = total;
                        monthlyData.InterestValue = interest;
                        monthlyData.CurrentInterestRate = rate;

                        _logger?.LogInformation(monthlyData.Join(","));
                        interest = 0;
                    }
                    currentDate = currentDate.AddDays(1);
                    if (currentDate.DayOfYear == startDate.DayOfYear)
                    {
                        break;
                    }
                }
                year++;
                paymentPerCheck += 100;
                _expectedMinimumIncome = currentValue * _checksPerMonth * _monthsPerYear * _approximatePercentageOfCheck;
                yearlyData.PaymentPerCheck = paymentPerCheck;
                yearlyData.InterestForYear = interestForYear;
                _logger?.LogInformation($"{currentDate},,,,{yearlyData.Join(",")}");
                interestForYear = 0;
            }
            return total;
        }
    }
}
