﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.BusinessLayer.Exceptions
{
    public class ReservationException : ApplicationException
    {
        public ReservationException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
