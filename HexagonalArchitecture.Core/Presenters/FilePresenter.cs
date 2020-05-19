using HexagonalArchitecture.Core.DataTransfertObject;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace HexagonalArchitecture.Core.Presenters
{
    public class FilePresenter : IFilePresenter<Tuple<string, byte[]>>
    {
        public FileStreamResult ContentResult { get; set; }

        public void Handle(UseCaseResponseMessage<Tuple<string, byte[]>> response)
        {
            //MemoryStream ms = new MemoryStream(response.Result.Item2);
            //StreamContent sc = new StreamContent(ms);
            //sc.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
            //sc.Headers.ContentDisposition.FileName = response.Result.Item1;
            //sc.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            //sc.Headers.ContentLength = ms.Length;

            MemoryStream ms = new MemoryStream(response.Result.Item2);
            this.ContentResult = new FileStreamResult(ms, "application/octet-stream")
            {
                FileDownloadName = response.Result.Item1
            };
        }
    }
}
