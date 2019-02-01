using System.Collections.Generic;
using SolidWorkshop.Entities;

namespace SolidWorkshop.DataProviders
{
    public interface IDataProvider<TEntity> where TEntity : IEntity
    {
        void Save(TEntity entity);

        List<TEntity> GetAll();
    }
}