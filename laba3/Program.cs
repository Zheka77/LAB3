using System;
using System.Collections.Generic;


namespace Lab3
{
    class ChessPiece
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int b { get; set; }
        public int d { get; set; }

        public ChessPiece(string name, string color, int b, int d)
        {
            this.Name = name;
            this.Color = color;
            this.b = b;
            this.d = d;
        }
    }

    class ChessBoard
    {
        private List<ChessPiece> _pieces;

        public ChessBoard()
        {
            _pieces = new List<ChessPiece>();
        }

        public void AddPiece(ChessPiece piece)
        {
            _pieces.Add(piece);
        }

        public List<ChessPiece> GetPieces()
        {
            return _pieces;
        }

        public bool IsMoveValid(ChessPiece piece, int newX, int newY)
        {
            // TODO: реалізувати перевірку валідності ходу
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            ChessBoard board = new ChessBoard();

            // Створюємо фігури
            ChessPiece whitePawn = new ChessPiece("Пішак", "Білий", 1, 1);
            ChessPiece blackPawn = new ChessPiece("Пішак", "Чорний", 6, 1);
            ChessPiece whiteRook = new ChessPiece("Рок", "Білий", 0, 0);
            ChessPiece blackRook = new ChessPiece("Рок", "Чорний", 7, 0);

            // Додаємо фігури на шахівницю
            board.AddPiece(whitePawn);
            board.AddPiece(blackPawn);
            board.AddPiece(whiteRook);
            board.AddPiece(blackRook);

            // Друкуємо шахівницю
            foreach (ChessPiece piece in board.GetPieces())
            {
                Console.WriteLine("{0} {1} {2} {3}", piece.Name, piece.Color, piece.b, piece.d);
            }

            // Перевіряємо валідність ходу
            bool validMove = board.IsMoveValid(whitePawn, 2, 2);
            Console.WriteLine("Валідність ходу: {0}", validMove);
        }
    }
}