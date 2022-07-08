using LombardApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LombardApp.Interface
{
    public class MockFormFunctions : IFormFunctions
    {
        private readonly DataBaseContext _context;
        public MockFormFunctions(DataBaseContext context)
        {
            _context = context;
        }

        /// Login & password check

        public bool LogIn(User user)
        {
            if (user.Email == "admin" && user.Password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IQueryable<PledgedItems> GetAllItems()
        {
            return _context.Items;
        }
        public IQueryable<Client> GetAllClients()
        {
            return _context.Client;
        }

        public void AddItem(PledgedItems item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }
        public void AddClient(Client client)
        {
            _context.Add(client);
            _context.SaveChanges();
        }

        public void RemoveItem(PledgedItems item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }
        public void RemoveClient(Client client)
        {
            _context.Remove(client);
            _context.SaveChanges();
        }

        public void UpdateItem(PledgedItems item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
        public void UpdateClient(Client client)
        {
            _context.Update(client);
            _context.SaveChanges();
        }

        public void ImportClients(List<Client> clients)
        {
            _context.AddRange(clients);
            _context.SaveChanges();
        }

        public void ImportItems(List<PledgedItems> items)
        {
            _context.AddRange(items);
            _context.SaveChanges();
        }
    }
}
