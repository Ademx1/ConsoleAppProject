using System;
namespace WorkPlace.Business.Exceptions;

public class MinimumSalaryException:Exception
{
    public MinimumSalaryException(string message) : base(message)
    {

    }
}

