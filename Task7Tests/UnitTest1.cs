// Unit Tests

using NUnit.Framework;
using System;

[TestFixture]
public class TetrominoTests
{
    [Test]
    public void Create_I_Tetromino()
    {
        var tetromino = Tetromino.Create(TetrominoType.I);
        Assert.That(tetromino.Color, Is.EqualTo("cyan"));
        Assert.That(tetromino.Shape.GetLength(0), Is.EqualTo(4));
        Assert.That(tetromino.Shape.GetLength(1), Is.EqualTo(1));
        Assert.That(tetromino.Shape[0, 0], Is.True);
        Assert.That(tetromino.Shape[1, 0], Is.True);
        Assert.That(tetromino.Shape[2, 0], Is.True);
        Assert.That(tetromino.Shape[3, 0], Is.True);
    }

    [Test]
    public void Create_J_Tetromino()
    {
        var tetromino = Tetromino.Create(TetrominoType.J);
        Assert.That(tetromino.Color, Is.EqualTo("blue"));
        Assert.That(tetromino.Shape.GetLength(0), Is.EqualTo(3));
        Assert.That(tetromino.Shape.GetLength(1), Is.EqualTo(3));
        Assert.That(tetromino.Shape[0, 1], Is.True);
        Assert.That(tetromino.Shape[1, 1], Is.True);
        Assert.That(tetromino.Shape[2, 0], Is.True);
        Assert.That(tetromino.Shape[2, 1], Is.True);
    }

    [Test]
    public void Create_L_Tetromino()
    {
        var tetromino = Tetromino.Create(TetrominoType.L);
        Assert.That(tetromino.Color, Is.EqualTo("orange"));
        Assert.That(tetromino.Shape.GetLength(0), Is.EqualTo(3));
        Assert.That(tetromino.Shape.GetLength(1), Is.EqualTo(3));
        Assert.That(tetromino.Shape[0, 1], Is.True);
        Assert.That(tetromino.Shape[1, 1], Is.True);
        Assert.That(tetromino.Shape[2, 1], Is.True);
        Assert.That(tetromino.Shape[2, 2], Is.True);
    }

    [Test]
    public void Create_O_Tetromino()
    {
        var tetromino = Tetromino.Create(TetrominoType.O);
        Assert.That(tetromino.Color, Is.EqualTo("yellow"));
        Assert.That(tetromino.Shape.GetLength(0), Is.EqualTo(2));
        Assert.That(tetromino.Shape.GetLength(1), Is.EqualTo(2));
        Assert.That(tetromino.Shape[0, 0], Is.True);
        Assert.That(tetromino.Shape[0, 1], Is.True);
        Assert.That(tetromino.Shape[1, 0], Is.True);
        Assert.That(tetromino.Shape[1, 1], Is.True);
    }

    [Test]
    public void Create_S_Tetromino()
    {
        var tetromino = Tetromino.Create(TetrominoType.S);
        Assert.That(tetromino.Color, Is.EqualTo("green"));
        Assert.That(tetromino.Shape.GetLength(0), Is.EqualTo(3));
        Assert.That(tetromino.Shape.GetLength(1), Is.EqualTo(3));
        Assert.That(tetromino.Shape[0, 1], Is.True);
        Assert.That(tetromino.Shape[0, 2], Is.True);
        Assert.That(tetromino.Shape[1, 0], Is.True);
        Assert.That(tetromino.Shape[1, 1], Is.True);
    }

    [Test]
    public void Create_Z_Tetromino()
    {
        var tetromino = Tetromino.Create(TetrominoType.Z);
        Assert.That(tetromino.Color, Is.EqualTo("red"));
        Assert.That(tetromino.Shape.GetLength(0), Is.EqualTo(3));
        Assert.That(tetromino.Shape.GetLength(1), Is.EqualTo(3));
        Assert.That(tetromino.Shape[0, 0], Is.True);
        Assert.That(tetromino.Shape[0, 1], Is.True);
        Assert.That(tetromino.Shape[1, 1], Is.True);
        Assert.That(tetromino.Shape[1, 2], Is.True);
    }

    [Test]
    public void Create_T_Tetromino()
    {
        var tetromino = Tetromino.Create(TetrominoType.T);
        Assert.That(tetromino.Color, Is.EqualTo("purple"));
        Assert.That(tetromino.Shape.GetLength(0), Is.EqualTo(3));
        Assert.That(tetromino.Shape.GetLength(1), Is.EqualTo(3));
        Assert.That(tetromino.Shape[0, 1], Is.True);
        Assert.That(tetromino.Shape[1, 0], Is.True);
        Assert.That(tetromino.Shape[1, 1], Is.True);
        Assert.That(tetromino.Shape[1, 2], Is.True);
    }

    [Test]
    public void Create_Invalid_TetrominoType()
    {
        Assert.Throws<ArgumentException>(() => Tetromino.Create((TetrominoType)99));
    }

    [Test]
    public void Constructor_ValidShapeAndColor()
    {
        bool[,] shape = { { true, false }, { false, true } };
        string color = "magenta";
        var tetromino = new Tetromino(shape, color);
        Assert.That(tetromino.Shape, Is.EqualTo(shape));
        Assert.That(tetromino.Color, Is.EqualTo(color));
    }

    [Test]
    public void Constructor_NullShape()
    {
        Assert.Throws<ArgumentNullException>(() => new Tetromino(null, "black"));
    }

    [Test]
    public void Constructor_EmptyShape()
    {
        Assert.Throws<ArgumentException>(() => new Tetromino(new bool[,] { }, "white"));
        Assert.Throws<ArgumentException>(() => new Tetromino(new bool[0, 1], "white"));
        Assert.Throws<ArgumentException>(() => new Tetromino(new bool[1, 0], "white"));
    }

    [Test]
    public void Constructor_NullColor()
    {
        Assert.Throws<ArgumentNullException>(() => new Tetromino(new bool[,] { { true } }, null));
    }

    [Test]
    public void Constructor_EmptyColor()
    {
        Assert.Throws<ArgumentException>(() => new Tetromino(new bool[,] { { true } }, string.Empty));
    }

    [Test]
    public void Constructor_WhitespaceColor()
    {
        Assert.Throws<ArgumentException>(() => new Tetromino(new bool[,] { { true } }, " "));
    }
}