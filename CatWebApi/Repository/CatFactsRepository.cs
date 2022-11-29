using System;
using CatWebAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CatWebAPI.Repository
{
    public class CatFactsRepository : IRepository<Cat>
    {
        public async Task<Cat> GetAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://catfact.ninja/");
                //HTTP GET
                var responseTask = await client.GetAsync("fact");



                if (responseTask.IsSuccessStatusCode)
                {

                    var readTask = responseTask.Content.ReadFromJsonAsync<Cat>();
                    readTask.Wait();

                    var cat = readTask.Result;

                    return cat;
                }
                else
                {
                    return null;
                }

            }
        }
    }
}