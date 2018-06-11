using MathLibrary.BasicFormulas;
using MathLibrary.Contracts.Positions;
using MathLibrary.SpecialFormulas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASDF
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceCalculator = new DistanceCalculator();
            var test = new TransformCalculator(distanceCalculator);
            var vec1 = new Vector3d(0, 0, 0);
            var vec2 = new Vector3d(2, 3, 1);

            var normalized = test.GetDirectional(vec1, vec2);

            Console.Read();
        }
    }
}
