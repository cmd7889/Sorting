namespace lab_0.Exceptions;

public class MinValueNotInValidRangeException : Exception
{
    public MinValueNotInValidRangeException()
    {
    }

    public MinValueNotInValidRangeException(string message)
        : base(message)
    {
    }

    public MinValueNotInValidRangeException(string message, Exception inner)
        : base(message, inner)
    {
    }
}