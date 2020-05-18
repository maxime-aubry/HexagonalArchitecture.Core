using HexagonalArchitecture.Core.DataTransfertObject;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Reflection;

namespace HexagonalArchitecture.Core.Presenters
{
    public class JsonPresenter<TResult> : IJsonPresenter<TResult>
    {
        public JsonPresenter()
        {
            this.ContentResult = new JsonContentResult();
        }

        public JsonContentResult ContentResult { get; set; }

        public void Handle(UseCaseResponseMessage<TResult> response)
        {
            Type currentResultType = typeof(TResult);
            ClientResultAttribute attribute = currentResultType.GetCustomAttribute<ClientResultAttribute>();

            if (attribute == null && !currentResultType.IsPrimitive)
                throw new Exception("Data format is not allowed. Only primitive types and objects with ClientResult attribute are allowed.");

            this.ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
            ContentResult.Content = JsonConvert.SerializeObject(response);
        }
    }
}
