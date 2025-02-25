using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Models
{
    public interface IClient
    {
        void Add(ClientModel model);
        void Update(ClientModel model);
        void Delete(ClientModel model);
        IEnumerable<ClientModel> GetAll();
        IEnumerable<ClientModel> GetByValue(string id);
    }
}
