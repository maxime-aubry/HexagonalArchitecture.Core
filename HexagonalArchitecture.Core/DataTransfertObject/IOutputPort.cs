namespace HexagonalArchitecture.Core.DataTransfertObject
{
    public interface IOutputPort<in TUseCaseResponse>
    {
        void Handle(TUseCaseResponse response);
    }
}
