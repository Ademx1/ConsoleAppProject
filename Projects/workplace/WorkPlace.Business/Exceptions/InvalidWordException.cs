﻿using System;
namespace WorkPlace.Business.Exceptions;

public class InvalidWordException:Exception
{
	public InvalidWordException(string message):base (message)
	{

	}
}
