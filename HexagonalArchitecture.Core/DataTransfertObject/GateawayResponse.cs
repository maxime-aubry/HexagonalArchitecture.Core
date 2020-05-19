using System.Collections.Generic;

namespace HexagonalArchitecture.Core.DataTransfertObject
{
    public class GateawayResponse<TResult>
    {
        public GateawayResponse(TResult data, bool success = false, IEnumerable<Error> errors = null)
        {
            this.Success = success;
            this.Errors = errors;
            this.Data = data;
        }

        public bool Success { get; set; }
        public IEnumerable<Error> Errors { get; set; }
        public TResult Data { get; set; }
    }
}
