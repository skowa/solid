using System;
using System.Collections.Generic;
using SolidWorkshop.DataProviders;
using SolidWorkshop.Entities;

namespace SolidWorkshop
{
    public class EntityService : IService<Entity>
    {
        private readonly IDataProvider<Entity> _dataProvider;

        public EntityService(IDataProvider<Entity> dataProvider)
        {
            _dataProvider = dataProvider ?? throw new ArgumentNullException($"{nameof(dataProvider)} is null");
        }

        public Entity Save(Entity entity)
        {
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        _dataProvider.Save(entity);
                        return entity;
                    }
                    catch
                    {
                        if (i == 2)
                            throw;
                    }
                }
                throw new Exception("Ex");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Entity> ReadAll() => _dataProvider.GetAll();
    }
}
