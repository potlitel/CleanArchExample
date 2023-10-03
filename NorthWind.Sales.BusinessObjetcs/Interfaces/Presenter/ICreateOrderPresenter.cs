namespace NorthWind.Sales.BusinessObjetcs.Interfaces.Presenter
{
    public interface ICreateOrderPresenter : ICreateOrderOutputPort
    {
        int OrderId { get; }
    }
}