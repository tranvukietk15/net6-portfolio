using System;

namespace Domain.Entities
{
    public class Aggregrator
    {
        protected Aggregrator(Guid id)
        {
            Id = id;
            CreatedOn = DateTime.Now;
        }

        protected DateTime CreatedOn { get; private set; }
        protected Guid Id { get; private set; }
    }
}
