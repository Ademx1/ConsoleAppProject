using System;
namespace WorkPlace.Business.Exceptions;

public class EmployeeLimitException:Exception
{
    public EmployeeLimitException(string message) : base(message)
    {

    }
}

