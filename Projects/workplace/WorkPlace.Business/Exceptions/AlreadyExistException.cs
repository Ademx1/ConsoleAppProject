﻿using System;
namespace WorkPlace.Business.Exceptions;

public class AlreadyExistException:Exception
{
	public AlreadyExistException(string message) : base(message)
	{

	}
}

