﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork7
{
    internal class WrongLoginException : Exception
    {
        public WrongLoginException(string message) : base(message)
        {
        }
        
        public WrongLoginException() { }
    }
}
