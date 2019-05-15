using AmazingBank.DomainModel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingBank.DomainModel.Entities
{
    public class Transaction<EntityId> : EntityBase<EntityId>
    {
        public DateTime DateTime { get; set; }
        public Account<EntityId> Origin { get; set; }
        public Account<EntityId> Destiny { get; set; }
        public Amount Amount { get; set; }
    }
}
