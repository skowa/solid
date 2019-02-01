using System;

namespace SolidWorkshop.Entities
{
    public class Entity : IEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
