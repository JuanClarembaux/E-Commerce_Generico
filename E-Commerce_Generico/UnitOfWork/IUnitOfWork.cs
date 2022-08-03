namespace E_Commerce_Generico.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
