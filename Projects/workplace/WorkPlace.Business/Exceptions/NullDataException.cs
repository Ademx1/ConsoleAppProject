using System;
namespace WorkPlace.Business.Exceptions;

public class NullDataException : Exception
{
    public NullDataException(string message) : base(message)
    {

    }
}

