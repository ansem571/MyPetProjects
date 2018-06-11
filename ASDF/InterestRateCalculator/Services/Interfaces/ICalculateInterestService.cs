using System;

namespace InterestRateCalculator.Services.Interfaces
{
    public interface ICalculateInterestService
    {
        /// <summary>
        /// Calculate Interest for a set number of months
        /// </summary>
        /// <param name="currentValue">Current account value</param>
        /// <param name="rate">Rate of interest as a decimal</param>
        /// <param name="months">Number of months to pass</param>
        /// <param name="paymentPerCheck">Value added when each check is received</param>
        /// <param name="startDate">Initial date of calculation</param>
        /// <param name="logger">Logging Service</param>
        /// <returns></returns>
        decimal CalculateInterestByMonths(decimal currentValue, decimal rate, int months, decimal paymentPerCheck, DateTime startDate);
        /// <summary>
        /// Calculate Interest for a set number of years
        /// </summary>
        /// <param name="currentValue">Current account value</param>
        /// <param name="rate">Rate of interest as a decimal</param>
        /// <param name="years">Number of years to pass</param>
        /// <param name="paymentPerCheck">Value added when each check is received</param>
        /// <param name="startDate">Initial date of calculation</param>
        /// <param name="logger">Logging Service</param>
        /// <returns></returns>
        decimal CalculateInterestByYears(decimal currentValue, decimal rate, int years, decimal paymentPerCheck, DateTime startDate);
    }
}
