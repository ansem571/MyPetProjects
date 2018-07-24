using ChessLibrary.Board;
using InterestRateCalculator.Services.Implementations;
using MathLibrary.BasicFormulas;
using MathLibrary.Contracts.Matrices;
using MathLibrary.Contracts.Positions;
using MathLibrary.SpecialFormulas;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading;

namespace ASDF
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fileName = @"C:\Users\MRMacDonnell\Desktop\NotepadDocs\SavingsCalc.csv";
            bool inUse = false;
            do
            {
                try
                {
                    if (!File.Exists(fileName))
                    {
                        File.Create(fileName).Dispose();
                    }
                    var writerService = new WriterService(fileName);

                    var interestCalculator = new CalculateInterestService(writerService);
                    var header = string.Join(",", "Timestamp", "Expected Value", "Interest Value", "InterestRate", "Payment/Check",
                            "Estimated Income", "Estimated Yearly Interest");
                    var footer = string.Join(",", "My Age", "Final Result");

                    writerService.LogInformation(header);
                    var startDate = new DateTime(2018, 6, 30);
                    interestCalculator.CalculateInterestByMonths(4030.02m, 0.0175m, 250, 500, startDate);
                    //writerService.LogInformation(footer);
                    writerService.DisposeWriter();
                    inUse = false;
                }
                catch (Exception ex)
                {
                    inUse = true;
                    Console.WriteLine(ex);
                    Thread.Sleep(10000);
                }
            }
            while (inUse);
        }
    }
}
