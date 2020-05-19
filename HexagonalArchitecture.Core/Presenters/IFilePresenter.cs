using Microsoft.AspNetCore.Mvc;

namespace HexagonalArchitecture.Core.Presenters
{
    public interface IFilePresenter<TResult> : IPresenter<TResult>
    {
        FileStreamResult ContentResult { get; set; }
    }
}
