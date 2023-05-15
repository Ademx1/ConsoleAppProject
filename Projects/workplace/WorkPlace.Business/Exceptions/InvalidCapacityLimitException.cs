using System;
namespace WorkPlace.Business.Exceptions;

public class InvalidCapacityLimitException:Exception
{
    public InvalidCapacityLimitException(string message) : base(message)
    {

    }
}

