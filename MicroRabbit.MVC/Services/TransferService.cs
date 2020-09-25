using MicroRabbit.MVC.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _httpClient;

        public TransferService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task CreateTransfer(TransferDto transferDto)
        {
            var uri = "http://localhost:5000/api/Banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto), 
                System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
