using System;
namespace WorkPlace.Business.Exceptions
{
	public class CapacityIsFullException:Exception
	{
		public CapacityIsFullException (string message): base(message)
		{

		}
	}
}

