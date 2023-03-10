using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ViaCep
{
    public class Cep
    {
        private readonly RestClient _restClient;

        public Cep()
        {
            const string cepApiBaseUrl = "https://viacep.com.br/";
            _restClient = new RestClient(cepApiBaseUrl);
        }

        string endpoint;

        public void ConsultarCEP()
        {
            Console.WriteLine("Digite o CEP");
            endpoint = Console.ReadLine();
        }

        public ViaCepModel GetCeps()
        {
            var request = new RestRequest(resource: $"ws/{endpoint}/json/");

            string cepsJson = _restClient.Get(request).Content;
            
            ViaCepModel ceps = JsonConvert.DeserializeObject<ViaCepModel>(cepsJson);

            return ceps;
        }

    }
}
