using System;
namespace WorkPlace.Business.Exceptions
{
	public class InvalidNumberException:Exception
	{
		public InvalidNumberException(string message):base (message)
		{
		}
	}
}

