using System;

public class Tetromino
{
    public bool[,] Shape { get; }
    public string Color { get; }

    public Tetromino(bool[,] shape, string color)
    {
        if (shape == null)
        {
            throw new ArgumentNullException(nameof(shape));
        }

        int rows = shape.GetLength(0);
        int cols = shape.GetLength(1);

        if (rows == 0 || cols == 0)
        {
            throw new ArgumentException("Shape cannot have zero rows or columns.", nameof(shape));
        }

        if (color == null)
        {
            throw new ArgumentNullException(nameof(color));
        }

        if (string.IsNullOrWhiteSpace(color))
        {
            throw new ArgumentException("Color cannot be null, empty, or whitespace.", nameof(color));
        }

        Shape = shape;
        Color = color;
    }

    public enum TetrominoType
    {
        I,
        J,
        L,
        O,
        S,
        Z,
        T
    }

    public static Tetromino Create(TetrominoType type)
    {
        switch (type)
        {
            case TetrominoType.I:
                return new Tetromino(new bool[,] { { true }, { true }, { true }, { true } }, "cyan");
            case TetrominoType.J:
                return new Tetromino(new bool[,] { { false, true }, { false, true }, { true, true } }, "blue");
            case TetrominoType.L:
                return new Tetromino(new bool[,] { { true, false }, { true, false }, { true, true } }, "orange");
            case TetrominoType.O:
                return new Tetromino(new bool[,] { { true, true }, { true, true } }, "yellow");
            case TetrominoType.S:
                return new Tetromino(new bool[,] { { false, true, true }, { true, true, false } }, "green");
            case TetrominoType.Z:
                return new Tetromino(new bool[,] { { true, true, false }, { false, true, true } }, "red");
            case TetrominoType.T:
                return new Tetromino(new bool[,] { { false, true, false }, { true, true, true } }, "purple");
            default:
                throw new ArgumentException("Invalid Tetromino type.", nameof(type));
        }
    }
}

public static class TetrominoExtensions
{
    public static void Print(this Tetromino self)
    {
        for (int i = 0; i < self.Shape.GetLength(0); i++)
        {
            for (int j = 0; j < self.Shape.GetLength(1); j++)
            {
                if (self.Shape[i, j])
                    Console.Write('-');
                else
                    Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var tetromino = Tetromino.Create(Tetromino.TetrominoType.O);
        tetromino.Print();
    }
}