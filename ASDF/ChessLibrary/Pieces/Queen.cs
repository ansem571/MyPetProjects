﻿using System;
using MathLibrary.Contracts.Positions;

namespace ChessLibrary.Pieces
{
    public class Queen : ChessPiece
    {
        public Queen(Vector2d position, string name, bool isWhite) : base(position, name, isWhite)
        {
        }

        public override bool CanMoveToDestination(Vector2d destination)
        {
            throw new NotImplementedException();
        }

        public override bool CanAttackLocation(Vector2d destination)
        {
            throw new NotImplementedException();
        }
    }
}
