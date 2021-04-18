using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Data.AdultsData;
using Models;

namespace Family_Management.Data.AdultsData
{
    public class ManageAdults: IAdults
    {
        private HttpClient client;
        
        public ManageAdults()
        {
            client = new HttpClient();
        }
        public async Task AddAdult(Adult adult)
        {
            string serialized = JsonSerializer.Serialize(adult);

            StringContent content = new StringContent(
                serialized,
                Encoding.UTF8,
                "application/json"
            );

            await client.PostAsync($"https://localhost:5002/adults" , content);
        }

        public async Task<IList<Adult>> GetAdults()
        {
            Task<string> stringAsync = client.GetStringAsync( $"https://localhost:5002/adults");
            string message = await stringAsync;
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;        }

        public async Task<Adult> getAdult(int Id)
        {
            Task<string> stringAsync = client.GetStringAsync( $"https://localhost:5002/adults/{Id}");
            string message = await stringAsync; 
            Adult result = JsonSerializer.Deserialize<Adult>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;            }

        public async Task Update(int id, Adult adult)
        {
            string serialized = JsonSerializer.Serialize(adult, new JsonSerializerOptions
                {PropertyNameCaseInsensitive = true});

            StringContent content = new StringContent(
                serialized,
                Encoding.UTF8,
                "application/json"
            );

            await client.PatchAsync($"https://localhost:5002/adults/{id}", content);
        }
    }
    }
