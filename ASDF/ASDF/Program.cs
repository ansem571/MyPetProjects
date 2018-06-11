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
        private static FramerateUpdateService update;
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
            chessBoard.DrawBoard();



            //update = new FramerateUpdateService();
            //update.Init();

            //Watcher();
            Console.ReadKey();

            chessBoard.ResetBoard();
            Console.ReadKey();
        }

        private static bool _isRunning = true;
        private static void Watcher()
        {
            while (_isRunning)
            {
                Console.SetCursorPosition(0, 2);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"FPS:{update.GetFPS()}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Frames:{update.GetFrames()}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"DeltaTime:{update.GetDeltaTime()}");

                for(var i = 0; i < 1000000; i++)
                {

                }
            }
        }
    }
}
