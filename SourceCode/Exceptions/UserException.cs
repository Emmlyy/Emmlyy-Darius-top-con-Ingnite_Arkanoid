﻿using System;

namespace proyectoPOO.Exceptions
{
    public class UserException: Exception
    {
        public UserException(string message) : base(message)
        {
        }
    }
}