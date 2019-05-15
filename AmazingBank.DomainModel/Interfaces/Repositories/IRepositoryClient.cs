using AmazingBank.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingBank.DomainModel.Interfaces.Repositories
{
    public interface IRepositoryClient : IRepository<Client,Guid>
    {
    }
}
