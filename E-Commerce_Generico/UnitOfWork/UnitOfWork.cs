namespace E_Commerce_Generico.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ECommerce_GenericoContext context;

        public UnitOfWork(ECommerce_GenericoContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
