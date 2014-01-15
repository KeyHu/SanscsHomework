using Sanscs.DAL.Implementations;
using Sanscs.DAL.Contracts;
using Sanscs.Model;

namespace Sanscs.Repository
{
    public class CoursRepository : Repository<cours>, ICoursRepository
    {
        private SanscsHomeworkPlatformdbEntities dataContext;

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        public CoursRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
            DatabaseFactory = databaseFactory;
        }

        protected SanscsHomeworkPlatformdbEntities DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }


    }
    public interface ICoursRepository : IRepository<cours>
    {
    }
}
