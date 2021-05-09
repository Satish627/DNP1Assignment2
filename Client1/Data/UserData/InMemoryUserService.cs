using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Data.UsersData;
using Family_Management.Models;

namespace Client.Data.UsersData
{
    public class InMemoryUserService : IUserService
    {
        private HttpClient client;
        public InMemoryUserService()
        {
            client = new HttpClient();
        }
        

        public async Task<User> ValidateUser(string username, string password)
        {
            HttpResponseMessage userAsync =
                await client.GetAsync(  $"http://localhost:5000/users?username={username}&password={password}");
            if (userAsync.IsSuccessStatusCode)
            {
                string userAsJson = await userAsync.Content.ReadAsStringAsync();
                User first = JsonSerializer.Deserialize<User>(userAsJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                Console.WriteLine("Successfully logged in");
                return first;
            }
            throw new Exception("User Not Found");
        }
    }
    }
