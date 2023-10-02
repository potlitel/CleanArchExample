namespace NorthWind.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        //Persistencia de datos de forma atómica (o todo o nada!!!)
        ValueTask SaveChanges();
    }
}