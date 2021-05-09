using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Family.Data.AdultsData;
using Family.Persistance;
using Models;

namespace Family.Data.AdultsData
{
    public class ManageAdults : IAdults
    {
        public async Task<Adult> AddAdult(Adult adult)
        {
            using (DAO dbContext = new DAO())
            {
                await dbContext.Adults.AddAsync(adult);
                await dbContext.SaveChangesAsync();
                return adult;
            }        }

        public async Task<IList<Adult>> GetAdults()
        {
            using (DAO dbContext = new DAO())
            {
                IList<Adult> adults = dbContext.Adults.ToList();
                return adults;
            }        }

        public async Task<Adult> getAdult(int Id)
        {
            using (DAO dbContext = new DAO())
            {
                IList<Adult> adults = await GetAdults();
                Adult adult = adults.FirstOrDefault(f => f.Id==(Id));
                return adult;
            }        }

        public async Task<Adult> Update(int Id, Adult adult)
        {
            using (DAO dbContext = new DAO())
            {
                Adult adu = await getAdult(Id);
                Console.WriteLine(adu.ToString());
                adu.Height = adult.Height;
                adu.Weight = adult.Weight;
                adu.HairColor = adult.HairColor;
                adu.Age = adult.Age;
                dbContext.Update(adu);
                await dbContext.SaveChangesAsync();
                Console.WriteLine(adu.ToString());
                return adu;
            }        
        }

        public async Task<Adult> Remove(int adultid)
        {
            using (DAO dbContext = new DAO())
            {
                Adult adu = await getAdult(adultid);
                dbContext.Adults.Remove(adu);
                await dbContext.SaveChangesAsync();
                return adu;
            }        }
    }
}
