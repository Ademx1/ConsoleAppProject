﻿using System;
namespace WorkPlace.Business.Exceptions;

public class SizeException:Exception
{
	public SizeException(string message): base(message)
	{

	}
}

