using MathLibrary.Contracts.Positions;
using System;

namespace ChessLibrary.Pieces
{
    public class Pawn : ChessPiece
    {
        private bool _isFirstMove = false;
        public Pawn(Vector2d position, string name, bool isWhite) : base(position, name, isWhite)
        {
            _isFirstMove = true;
        }

        public override bool CanMoveToDestination(Vector2d destination)
        {
            var moveUp = IsWhite;
            if (destination.Y < 0 || destination.Y > 7) //cannot move outside of border
            {
                return false;
            }

            var distance = destination - Position;
            if (_isFirstMove)
            {
                if (IsWhite)
                {
                    return distance.Y == -1 || distance.Y == -2;
                }
                else
                {
                    return distance.Y == 1 || distance.Y == 2;
                }
            }
            else
            {
                if (IsWhite)
                {
                    return distance.Y == -1;
                }
                else
                {
                    return distance.Y == 1;
                }
            }
        }

        public override bool CanAttackLocation(Vector2d destination)
        {
            var moveUp = IsWhite;

            if (destination.X < 0 || destination.X > 7) //cannot move outside of border
            {
                return false;
            }

            var distance = destination - Position;
            return IsWhite ?
                    distance.X == -1 :
                    distance.X == 1;
        }
    }
}
