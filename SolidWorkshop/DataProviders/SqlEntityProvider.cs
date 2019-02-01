using System;
using System.Collections.Generic;
using System.Data;
using SolidWorkshop.Entities;

namespace SolidWorkshop.DataProviders
{
    public class SqlEntityProvider : IDataProvider<Entity>
    {
        private readonly IDbConnection _dbConnection;

        public SqlEntityProvider(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection ?? throw new ArgumentNullException($"{nameof(dbConnection)} is null");
        }

        public void Save(Entity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(entity)} is null");
            }

            _dbConnection.Open();
            //perform Save
            _dbConnection.Close();
        }

        public List<Entity> GetAll()
        {
            _dbConnection.Open();
            //perform Save
            _dbConnection.Close();

            return new List<Entity>();
        }
    }
}