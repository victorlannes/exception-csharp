using System;

namespace exception.Entities.Exceptions {
     class DomainException : ApplicationException
     {
        public DomainException(string message) : base(message) 
        {

        }
     }
}
