using AmazingBank.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingBank.DomainModel.Entities
{
    public class Account<EntityId> : EntityBase<EntityId>
    {
        public Client<EntityId> Client { get; set; }
    }
}
