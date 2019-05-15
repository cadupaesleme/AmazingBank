using AmazingBank.DomainModel.Entities;
using AmazingBank.DomainModel.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingBank.Infrastructure.DataAcess.Repositories
{
    public class ClientMemDbRepository : IRepositoryClient
    {
        private static List<Client> _set = new List<Client>();

        public void Create(Client entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Client entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> Read()
        {
            throw new NotImplementedException();
        }

        public Client ReadAll(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
