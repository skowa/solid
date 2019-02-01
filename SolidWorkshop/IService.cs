using System.Collections.Generic;
using SolidWorkshop.Entities;

namespace SolidWorkshop
{
    public interface IService<TEntity> where TEntity : IEntity
    {
        TEntity Save(TEntity entity);

        List<TEntity> ReadAll();
    }
}