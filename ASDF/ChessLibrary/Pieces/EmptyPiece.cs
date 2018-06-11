using MathLibrary.Contracts.Positions;

namespace ChessLibrary.Pieces
{
    public class EmptyPiece : ChessPiece
    {
        public EmptyPiece(Vector2d position, string name, bool isWhite) : base(position, name, isWhite)
        {
        }
    }
}
