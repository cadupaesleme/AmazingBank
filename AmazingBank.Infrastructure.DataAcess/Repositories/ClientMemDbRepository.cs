using AmazingBank.DomainModel.Entities;
using AmazingBank.DomainModel.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingBank.Infrastructure.DataAcess.Repositories
{
    public class ClientMemDbRepository : IClientRepository
    {
        private static List<Client> _set = new List<Client>();

        public void Create(Client entity)
        {
            _set.Add(entity);
        }

        public void Delete(Guid id)
        {
            _set.Remove(Read(id));
        }

        public Client Read(Guid id)
        {
            return _set.Find(c => c.Id == id);
        }

        public IEnumerable<Client> ReadAll()
        {
            return _set;
        }

        public void Update(Client entity)
        {
            this.Delete(entity.Id);
            this.Create(entity);
        }
    }
}
