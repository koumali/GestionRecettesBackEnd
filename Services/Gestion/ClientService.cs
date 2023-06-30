using automotiveApi.DAL;
using automotiveApi.Models;

namespace automotiveApi.Services.Gestion
{
    public class ClientService : IClient
    {
        private readonly AppDbContext _context;

        public ClientService(AppDbContext context)
        {
            _context = context;
        }

        public Client? add(Client Client)
        {
            try
            {
                _context.Clients.Add(Client);
                _context.SaveChanges();
                return Client;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        

        public Client? findById(int id)
        {
            var Client = _context.Clients.Where(u => u.id == id).FirstOrDefault();
            return Client;
        
    
        }


        public IEnumerable<Client> getClients()
        {
            return _context.Clients.ToList();
        }
        public void delete(int id)
        {
            var Client = _context.Clients.Find(id);
            if (Client != null)
            {
                _context.Clients.Remove(Client);
                _context.SaveChanges();
            }
        }
        public Client update(Client updatedClient)
        {
            try
            {
                _context.Clients.Update(updatedClient);
                _context.SaveChanges();
                return updatedClient;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

}