// Implementation

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

        if (shape.GetLength(0) == 0 || shape.GetLength(1) == 0)
        {
            throw new ArgumentException("Shape cannot be empty.", nameof(shape));
        }

        if (color == null)
        {
            throw new ArgumentNullException(nameof(color));
        }

        if (string.IsNullOrWhiteSpace(color))
        {
            throw new ArgumentException("Color cannot be null or whitespace.", nameof(color));
        }

        Shape = shape;
        Color = color;
    }

    public static Tetromino Create(TetrominoType type)
    {
        switch (type)
        {
            case TetrominoType.I:
                return new Tetromino(new bool[,] { { true }, { true }, { true }, { true } }, "cyan");
            case TetrominoType.J:
                return new Tetromino(new bool[,] { { false, true, false }, { false, true, false }, { true, true, false } }, "blue");
            case TetrominoType.L:
                return new Tetromino(new bool[,] { { false, true, false }, { false, true, false }, { false, true, true } }, "orange");
            case TetrominoType.O:
                return new Tetromino(new bool[,] { { true, true }, { true, true } }, "yellow");
            case TetrominoType.S:
                return new Tetromino(new bool[,] { { false, true, true }, { true, true, false }, { false, false, false } }, "green");
            case TetrominoType.Z:
                return new Tetromino(new bool[,] { { true, true, false }, { false, true, true }, { false, false, false } }, "red");
            case TetrominoType.T:
                return new Tetromino(new bool[,] { { false, true, false }, { true, true, true }, { false, false, false } }, "purple");
            default:
                throw new ArgumentException($"Invalid Tetromino type: {type}", nameof(type));
        }
    }
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
        var tetromino = Tetromino.Create(TetrominoType.O);
        tetromino.Print();
    }
}