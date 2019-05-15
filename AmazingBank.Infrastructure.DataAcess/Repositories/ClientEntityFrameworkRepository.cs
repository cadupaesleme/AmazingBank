using AmazingBank.DomainModel.Entities;
using AmazingBank.DomainModel.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingBank.Infrastructure.DataAcess.Repositories
{
    public class ClientEntityFrameworkRepository : IClientRepository
    {
        public void Create(Client entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Client Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
