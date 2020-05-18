namespace HexagonalArchitecture.Core.Presenters
{
    public interface IJsonPresenter<TResult> : IPresenter<TResult>
    {
        JsonContentResult ContentResult { get; set; }
    }
}
