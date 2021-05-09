using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Client1.Data.AdultsData;
using Models;

namespace Client1.Data.AdultsData
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

            await client.PostAsync($"http://localhost:5000/adults" , content);
        }

        public async Task<IList<Adult>> GetAdults()
        {
            Task<string> stringAsync = client.GetStringAsync( $"http://localhost:5000/adults");
            string message = await stringAsync;
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;        }

        public async Task<Adult> getAdult(int Id)
        {
            Task<string> stringAsync = client.GetStringAsync( $"http://localhost:5000/adults/{Id}");
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

            await client.PatchAsync($"http://localhost:5000/adults/{id}", content);
        }
    }
    }
