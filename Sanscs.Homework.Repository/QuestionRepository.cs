using Sanscs.DAL.Implementations;
using Sanscs.DAL.Contracts;
using Sanscs.Model;

namespace Sanscs.Repository
{
    public class QuestionRepository : Repository<question>, IQuestionsRepository
    {
        private SanscsHomeworkPlatformdbEntities dataContext;

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        public QuestionRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
            DatabaseFactory = databaseFactory;
        }

        protected SanscsHomeworkPlatformdbEntities DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }


    }
    public interface IQuestionsRepository : IRepository<question>
    {
    }
}
