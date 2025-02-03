using System;

public class InvalidPropertyException : Exception
{
    public InvalidPropertyException(string message) : base(message)
    {
    }
}

