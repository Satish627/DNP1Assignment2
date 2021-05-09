using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Family.Data.AdultsData
{
    public interface IAdults
    {
        
            Task<Adult> AddAdult(Adult adult);

            Task<IList<Adult>> GetAdults();

            Task<Adult> getAdult(int Id);

            Task<Adult> Update(int Id,Adult adult);
            Task<Adult> Remove(int adultid);

    }
}