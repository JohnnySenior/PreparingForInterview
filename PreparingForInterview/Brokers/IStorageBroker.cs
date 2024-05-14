using PreparingForInterview.Models;

namespace PreparingForInterview.Brokers
{
    public interface IStorageBroker
    {
        ValueTask<Client> InsertClientAsync(Client client);
    }
}
