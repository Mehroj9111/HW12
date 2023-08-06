using Crm.Entities;

namespace Crm.Services;

class ClientService
{
    private List<Client> clients = new List<Client>();

    public void CreateClient(Client client)
    {
        clients.Add(client);
    }

    public Client GetClientByName(string firstName, string lastName)
    {
        return clients.FirstOrDefault(c => c.FirstName == firstName && c.LastName == lastName);
    }
}

   