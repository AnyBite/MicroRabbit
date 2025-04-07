using System.Text.Json.Serialization;
using MicroRabbit.MVC.Models.DTO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;
        private readonly string _bankingApiUrl;

        public TransferService(HttpClient apiClient, IOptions<ServiceUrls> serviceUrls)
        {
            _apiClient = apiClient;
            _bankingApiUrl = serviceUrls.Value.BankingApi;
        }
        public async Task Transfer(TransferDto transferDto)
        {
            var uri = _bankingApiUrl;
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto),
                                            System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
