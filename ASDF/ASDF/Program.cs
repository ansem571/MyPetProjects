using ChessLibrary.Board;
using MathLibrary.BasicFormulas;
using MathLibrary.Contracts.Matrices;
using MathLibrary.Contracts.Positions;
using MathLibrary.SpecialFormulas;
using System;

namespace ASDF
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceCalculator = new DistanceCalculator();
            var test = new TransformCalculator(distanceCalculator);
            var vec1 = new Vector3d(0, 0, 0);
            var vec2 = new Vector3d(1, 0, 0);

            var normalized = test.GetDirectional(vec1, vec2);

            var scale = new Transform();

            //Console.Read();

            var chessBoard = new ChessBoard();
            //chessBoard.DrawBoard();

            Console.ReadKey();

            chessBoard.ResetBoard();
            Console.ReadKey();

            var binarySolver = new BinarySolver();
            binarySolver.ResetValue();
            binarySolver.DiscoverValue();
        }
    }
}
