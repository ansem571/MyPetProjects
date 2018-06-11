﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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