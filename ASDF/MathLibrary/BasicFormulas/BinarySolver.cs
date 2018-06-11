using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.BasicFormulas
{
    public class BinarySolver
    {
        private int _value;
        private Random _random;
        private int _lowValue = 0;
        private int _highValue = 100;
        
        public void ResetValue()
        {
            _random = new Random();
            _value = _random.Next(int.MaxValue);
        }

        public void DiscoverValue()
        {
            _value = 100;
            var numberOfRecursionsRequired = 0;
            var currentValue = _random.Next(100);
            while(currentValue != _value)
            {
                numberOfRecursionsRequired++;
                if (currentValue < _value)
                {
                    long temp = (long)Math.Round((_highValue + currentValue) / 2d, MidpointRounding.AwayFromZero);
                    currentValue = (int)temp;
                    _lowValue = currentValue;
                    Console.WriteLine(currentValue);
                }
                else
                {
                    currentValue = (int)Math.Round((_lowValue + currentValue) / 2d, MidpointRounding.AwayFromZero);
                    _highValue = currentValue;
                    Console.WriteLine(currentValue);
                }
            }

            Console.WriteLine($"Recursions: {numberOfRecursionsRequired}");
        }
    }
}
