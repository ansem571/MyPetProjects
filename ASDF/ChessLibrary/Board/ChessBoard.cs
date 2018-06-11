using ChessLibrary.Pieces;
using MathLibrary.Contracts.Positions;
using System;

namespace ChessLibrary.Board
{
    public class ChessBoard
    {
        private static readonly int MaxColumns = 8;
        private static readonly int MaxRows = 8;
        private ChessPiece[,] BoardGrid = new ChessPiece[MaxRows, MaxColumns];

        public ChessBoard()
        {
            ResetBoard();
        }

        public void ResetBoard()
        {
            //Resets all tiles to null
            Array.Clear(BoardGrid, 0, BoardGrid.Length);

            //intialize the pieces
            InitializePawns();
            InitializeRooks();
            InitializeKnights();
            InitializeBishops();
            InitializeQueens();
            InitializeKings();

            //initialize remaining tiles as empty
            var currentPos = new Vector2d();
            for (var r = 0; r < MaxRows; r++)
            {
                for (var c = 0; c < MaxColumns; c++)
                {
                    currentPos.X = c;
                    currentPos.Y = r;
                    if (BoardGrid[r, c] == null)
                    {
                        BoardGrid[r, c] = new EmptyPiece(currentPos, "-", false);
                    }
                }
            }
        }

        private void InitializePawns()
        {
            var currentPos = new Vector2d();
            for (var i = 0; i < 2; i++)
            {
                for (var c = 0; c < MaxColumns; c++)
                {
                    currentPos.X = c;
                    var isWhite = i == 0;
                    if (isWhite)
                    {
                        currentPos.Y = MaxRows - 2;
                        BoardGrid[MaxRows - 2, c] = new Pawn(currentPos, $"Pawn{c + 1}", true);
                    }
                    else
                    {
                        currentPos.Y = 1;
                        BoardGrid[1, c] = new Pawn(currentPos, $"Pawn{c + 1}", false);
                    }
                }
            }
        }

        private void InitializeRooks()
        {

        }

        private void InitializeKnights()
        {

        }

        private void InitializeBishops()
        {

        }

        private void InitializeQueens()
        {

        }

        private void InitializeKings()
        {

        }

        public void DrawBoard()
        {
            Console.WriteLine("Black side");
            Console.WriteLine("   A B C D E F G H\r\n");
            for (var r = 0; r < MaxRows; r++)
            {
                Console.Write($"{r + 1}  ");
                for (var c = 0; c < MaxColumns; c++)
                {
                    Console.Write($"{BoardGrid[r, c].DisplayPieceName()} ");
                }
                Console.WriteLine($" {r + 1}\r\n");
            }
            Console.WriteLine("   A B C D E F G H");
            Console.WriteLine("White side");
        }
    }
}
