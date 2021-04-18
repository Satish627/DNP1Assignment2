using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Client.Data.AdultsData
{
    public interface IAdults
    {
        
            Task AddAdult(Adult adult);

            Task<IList<Adult>> GetAdults();

            Task<Adult> getAdult(int Id);

            Task Update(int id, Adult adult);

    }
}