using AmazingBank.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingBank.DomainModel.Entities
{
    public class Account : EntityBase<Guid>
    {
        public Client Client { get; set; }
    }
}
