using System;
namespace WorkPlace.Business.Helpers
{
	public static class Helpers
	{
		public static Dictionary<string, string> Errors = new Dictionary<string, string>()
		{
			{"AlreadyExistException","This object already exists." },
			{"SizeException","Size doesn't match." },
			{"InvalidWordException","This word is not valid. Cracters can only be letters!" },
			{"CapacityIsFullException","Not enough space left." },
			{"InvalidNumberException","This ID doesn't exists." }

		};
	}
}

