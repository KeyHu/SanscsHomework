using Sanscs.DAL.Contracts;
using Sanscs.Model;

namespace Sanscs.DAL.Implementations
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private SanscsHomeworkPlatformdbEntities dataContext;
        public SanscsHomeworkPlatformdbEntities Get()
        {
            return dataContext ?? (dataContext = new SanscsHomeworkPlatformdbEntities());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
