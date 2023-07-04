﻿using Newtonsoft.Json;
using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Sizes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ApiIntegration
{
    public class SizesApiClient : ISizesApiClient
    {
        public async Task<List<SizeVm>> GetAll()
        {
            var httpClient = new HttpClient();
            string apiURL = "https://localhost:5000/api/Sizes/";

            var response = await httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<SizeVm>>(apiData);
            return result;
        }

        public async Task<SizeVm> GetById(Guid id)
        {
            var httpClient = new HttpClient();

            string apiURL = $"https://localhost:5000/api/Sizes/{id}";
            var response = await httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<SizeVm>(apiData);
            return result;
        }
    }
}