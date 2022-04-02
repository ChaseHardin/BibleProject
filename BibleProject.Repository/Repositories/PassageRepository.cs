using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BibleProject.Repository.Models;

namespace BibleProject.Repository.Repositories
{
    public class PassageRepository
    {
        public async Task<IEnumerable<Passage>> GetPassages()
        {
            using var client = new HttpClient();
            
            client.DefaultRequestHeaders.Add("Authorization", "Token <add_token>");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync("https://api.esv.org/v3/passage/html/?q=John,Luke,Romans");
            var passages = await response.Content.ReadFromJsonAsync<Passage>();

            return new List<Passage> { passages };
        }
    }
}