using HexagonalArchitecture.Core.DataTransfertObject;

namespace HexagonalArchitecture.Core.Presenters
{
    public interface IPresenter<TResult> : IOutputPort<UseCaseResponseMessage<TResult>>
    {
    }
}
