using Sanscs.Model;
using System;

namespace Sanscs.DAL.Contracts
{
    public interface IDatabaseFactory : IDisposable
    {
        SanscsHomeworkPlatformdbEntities Get();
    }
}
