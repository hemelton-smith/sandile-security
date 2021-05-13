using System;
using System.Collections.Generic;
using System.Text;

namespace SandileSecurity.Domain.Output
{
    public class PresenterException : Exception
    {
        public PresenterException(string message) : base(message)
        {
        }
    }
}
