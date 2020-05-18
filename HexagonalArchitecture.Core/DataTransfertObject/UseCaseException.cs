using System;
using System.Collections.Generic;

namespace HexagonalArchitecture.Core.DataTransfertObject
{
    public class UseCaseException : Exception
    {
        public UseCaseException(string message, IEnumerable<Error> errors)
            : base(message)
        {
            this.Errors = errors;
        }

        public IEnumerable<Error> Errors { get; set; }
    }
}
