using System;
namespace WorkPlace.Business.Exceptions;

public class IsEmptyException:Exception
{
	public IsEmptyException(string message):base (message)
	{

	}
}

