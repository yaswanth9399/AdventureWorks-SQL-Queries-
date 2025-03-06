public class Color
{
    public int Red { get; private set; }
    public int Green { get; private set; }
    public int Blue { get; private set; }
    public int Alpha { get; private set; } = 255; 

    public Color(int red, int green, int blue, int alpha = 255)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    public double GetGrayScale()
    {
        return (Red + Green + Blue) / 3.0;
    }
}

public class Ball
{
    public int Size { get; private set; }
    public Color BallColor { get; private set; }
    private int throwCount = 0;

    public Ball(int size, Color color)
    {
        Size = size;
        BallColor = color;
    }

    public void Pop()
    {
        Size = 0;
    }

    public void Throw()
    {
        if (Size > 0)
            throwCount++;
    }

    public int GetThrowCount()
    {
        return throwCount;
    }
}
