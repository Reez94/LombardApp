using LombardApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LombardApp.Interface
{
    /// Interfaces

    public interface IFormFunctions
    {
        bool LogIn(User userLogin);

        public IQueryable<PledgedItems> GetAllItems();
        public IQueryable<Client> GetAllClients();
        void AddItem(PledgedItems item);
        void AddClient(Client client);
        void RemoveItem(PledgedItems item);
        void RemoveClient(Client client);
        void UpdateItem(PledgedItems item);
        void UpdateClient(Client client);

        void ImportClients(List<Client> clients);
        void ImportItems(List<PledgedItems> items);
    }
}
