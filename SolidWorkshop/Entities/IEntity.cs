using System;

namespace SolidWorkshop.Entities
{
    public interface IEntity
    {
        int Id { get; set; }

        DateTime CreatedDate { get; set; }
    }
}