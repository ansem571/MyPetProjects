using MathLibrary.Contracts.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary.Pieces
{
    public class ChessPiece
    {
        protected Vector2d Position { get; set; }
        protected string Name { get; }
        protected char DisplayName { get; set; }
        protected bool IsWhite { get; }

        public ChessPiece(Vector2d position, string name, bool isWhite)
        {
            Position = position;
            Name = name;
            IsWhite = isWhite;
            SetDisplayName();
        }

        public char DisplayPieceName()
        {
            return IsWhite ? 
                Char.ToUpper(DisplayName) : 
                Char.ToLower(DisplayName);
        }

        private void SetDisplayName()
        {
            if (Name.Contains("King"))
            {
                DisplayName = 'K';
            }
            else if (Name.Contains("Queen"))
            {
                DisplayName = 'Q';
            }
            else if (Name.Contains("Bishop"))
            {
                DisplayName = 'B';
            }
            else if (Name.Contains("Knight"))
            {
                DisplayName = 'N';
            }
            else if (Name.Contains("Rook") || Name.Contains("Castle"))
            {
                DisplayName = 'R';
            }
            else if (Name.Contains("Pawn"))
            {
                DisplayName = 'P';
            }
            else if(Name.Equals("-") || Name.Equals("*"))
            {
                DisplayName = Name[0];
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(Name), "Cannot build a DisplayName from current Piece name");
            }
        }

        public virtual bool CanMoveToDestination(Vector2d destination)
        {
            return true;
        }

        public virtual bool CanAttackLocation(Vector2d destination)
        {
            return true;
        }
    }
}
