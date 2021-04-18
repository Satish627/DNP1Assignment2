using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileData;
using ManagingFamily.Data.AdultsData;
using Models;

namespace ManagingFamily.Data.AdultsData
{
    public class ManageAdults: IAdults
    {
        private FileContext fileContext;

        public ManageAdults(FileContext file)
        {
            fileContext = file;
        }
        public async Task<Adult> AddAdult(Adult adult)
        
        {
            int max;
            if (fileContext.Adults.Count==0)
            {
                max = 1;
                adult.Id = max;
            }
            else
            {
                max = fileContext.Adults.Max(a => a.Id);
                adult.Id = (++max);
            }
             
            fileContext.Adults.Add(adult);
            fileContext.SaveChanges();
            return adult;
        }

        public async Task<IList<Adult>> GetAdults()
        {
            return fileContext.Adults;
        }

        public async Task<Adult> getAdult(int Id)
        {
            return fileContext.Adults.FirstOrDefault(t => t.Id == Id);
        }

        public async Task<Adult> Update(int Id,Adult adult)
        {
            Adult adu =await getAdult(adult.Id);
            adult.FirstName = adu.FirstName;
            fileContext.SaveChanges();
            return adu;
        }
        
    }
    }
