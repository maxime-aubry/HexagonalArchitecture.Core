using Microsoft.AspNetCore.Mvc;

namespace HexagonalArchitecture.Core.Presenters
{
    public class JsonContentResult : ContentResult
    {
        public JsonContentResult()
        {
            this.ContentType = "application/json";
        }
    }
}
