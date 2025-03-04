using NUnit.Framework;
using System;

[TestFixture]
public class TetrominoTests
{
    [Test]
    public void Create_ITetromino_ReturnsCorrectShapeAndColor()
    {
        Tetromino tetromino = Tetromino.Create(Tetromino.TetrominoType.I);
        Assert.That(tetromino.Color, Is.EqualTo("cyan"));
        Assert.That(tetromino.Shape.GetLength(0), Is.EqualTo(4));
        Assert.That(tetromino.Shape.GetLength(1), Is.EqualTo(1));
        Assert.That(tetromino.Shape[0, 0], Is.True);
        Assert.That(tetromino.Shape[1, 0], Is.True);
        Assert.That(tetromino.Shape[2, 0], Is.True);
        Assert.That(tetromino.Shape[3, 0], Is.True);
    }

    [Test]
    public void Create_JTetromino_ReturnsCorrectShapeAndColor()
    {
        Tetromino tetromino = Tetromino.Create(Tetromino.TetrominoType.J);
        Assert.That(tetromino.Color, Is.EqualTo("blue"));
        Assert.That(tetromino.Shape.GetLength(0), Is.EqualTo(3));
        Assert.That(tetromino.Shape.GetLength(1), Is.EqualTo(2));
        Assert.That(tetromino.Shape[0, 0], Is.False);
        Assert.That(tetromino.Shape[0, 1], Is.True);
        Assert.That(tetromino.Shape[1, 0], Is.False);
        Assert.That(tetromino.Shape[1, 1], Is.True);
        Assert.That(tetromino.Shape[2, 0], Is.True);
        Assert.That(tetromino.Shape[2, 1], Is.True);
    }

    [Test]
    public void Create_LTetromino_ReturnsCorrectShapeAndColor()
    {
        Tetromino tetromino = Tetromino.Create(Tetromino.TetrominoType.L);
        Assert.That(tetromino.Color, Is.EqualTo("orange"));
        Assert.That(tetromino.Shape.GetLength(0), Is.EqualTo(3));
        Assert.That(tetromino.Shape.GetLength(1), Is.EqualTo(2));
        Assert.That(tetromino.Shape[0, 0], Is.True);
        Assert.That(tetromino.Shape[0, 1], Is.False);
        Assert.That(tetromino.Shape[1, 0], Is.True);
        Assert.That(tetromino.Shape[1, 1], Is.False);
        Assert.That(tetromino.Shape[2, 0], Is.True);
        Assert.That(tetromino.Shape[2, 1], Is.True);
    }

    [Test]
    public void Create_OTetromino_ReturnsCorrectShapeAndColor()
    {
        Tetromino tetromino = Tetromino.Create(Tetromino.TetrominoType.O);
        Assert.That(tetromino.Color, Is.EqualTo("yellow"));
        Assert.That(tetromino.Shape.GetLength(0), Is.EqualTo(2));
        Assert.That(tetromino.Shape.GetLength(1), Is.EqualTo(2));
        Assert.That(tetromino.Shape[0, 0], Is.True);
        Assert.That(tetromino.Shape[0, 1], Is.True);
        Assert.That(tetromino.Shape[1, 0], Is.True);
        Assert.That(tetromino.Shape[1, 1], Is.True);
    }

    [Test]
    public void Create_STetromino_ReturnsCorrectShapeAndColor()
    {
        Tetromino tetromino = Tetromino.Create(Tetromino.TetrominoType.S);
        Assert.That(tetromino.Color, Is.EqualTo("green"));
        Assert.That(tetromino.Shape.GetLength(0), Is.EqualTo(2));
        Assert.That(tetromino.Shape.GetLength(1), Is.EqualTo(3));
        Assert.That(tetromino.Shape[0, 0], Is.False);
        Assert.That(tetromino.Shape[0, 1], Is.True);
        Assert.That(tetromino.Shape[0, 2], Is.True);
        Assert.That(tetromino.Shape[1, 0], Is.True);
        Assert.That(tetromino.Shape[1, 1], Is.True);
        Assert.That(tetromino.Shape[1, 2], Is.False);
    }

    [Test]
    public void Create_ZTetromino_ReturnsCorrectShapeAndColor()
    {
        Tetromino tetromino = Tetromino.Create(Tetromino.TetrominoType.Z);
        Assert.That(tetromino.Color, Is.EqualTo("red"));
        Assert.That(tetromino.Shape.GetLength(0), Is.EqualTo(2));
        Assert.That(tetromino.Shape.GetLength(1), Is.EqualTo(3));
        Assert.That(tetromino.Shape[0, 0], Is.True);
        Assert.That(tetromino.Shape[0, 1], Is.True);
        Assert.That(tetromino.Shape[0, 2], Is.False);
        Assert.That(tetromino.Shape[1, 0], Is.False);
        Assert.That(tetromino.Shape[1, 1], Is.True);
        Assert.That(tetromino.Shape[1, 2], Is.True);
    }

    [Test]
    public void Create_TTetromino_ReturnsCorrectShapeAndColor()
    {
        Tetromino tetromino = Tetromino.Create(Tetromino.TetrominoType.T);
        Assert.That(tetromino.Color, Is.EqualTo("purple"));
        Assert.That(tetromino.Shape.GetLength(0), Is.EqualTo(2));
        Assert.That(tetromino.Shape.GetLength(1), Is.EqualTo(3));
        Assert.That(tetromino.Shape[0, 0], Is.False);
        Assert.That(tetromino.Shape[0, 1], Is.True);
        Assert.That(tetromino.Shape[0, 2], Is.False);
        Assert.That(tetromino.Shape[1, 0], Is.True);
        Assert.That(tetromino.Shape[1, 1], Is.True);
        Assert.That(tetromino.Shape[1, 2], Is.True);
    }

    [Test]
    public void Create_InvalidTetrominoType_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => Tetromino.Create((Tetromino.TetrominoType)99));
    }

    [Test]
    public void Constructor_NullShape_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => new Tetromino(null, "red"));
    }

    [Test]
    public void Constructor_EmptyShape_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Tetromino(new bool[0, 0], "red"));
        Assert.Throws<ArgumentException>(() => new Tetromino(new bool[1, 0], "red"));
        Assert.Throws<ArgumentException>(() => new Tetromino(new bool[0, 1], "red"));
    }

    [Test]
    public void Constructor_NullColor_ThrowsArgumentNullException()
    {
        bool[,] shape = { { true } };
        Assert.Throws<ArgumentNullException>(() => new Tetromino(shape, null));
    }

    [Test]
    public void Constructor_EmptyColor_ThrowsArgumentException()
    {
        bool[,] shape = { { true } };
        Assert.Throws<ArgumentException>(() => new Tetromino(shape, ""));
    }

    [Test]
    public void Constructor_WhitespaceColor_ThrowsArgumentException()
    {
        bool[,] shape = { { true } };
        Assert.Throws<ArgumentException>(() => new Tetromino(shape, " "));
    }

    [Test]
    public void Constructor_ValidShapeAndColor_CreatesInstance()
    {
        bool[,] shape = { { true, false }, { false, true } };
        Tetromino tetromino = new Tetromino(shape, "green");
        Assert.That(tetromino.Shape, Is.EqualTo(shape));
        Assert.That(tetromino.Color, Is.EqualTo("green"));
    }
}