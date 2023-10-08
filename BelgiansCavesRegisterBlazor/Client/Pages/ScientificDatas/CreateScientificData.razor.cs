using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgiansCavesRegisterBlazor.Client.Pages.ScientificDatas
{
    public partial class CreateScientificData
    {
        [Inject]
        public HttpClient Client { get; set; }
        public ScientificDataModel ScientificDataRegisterForm { get; set; }
        protected override void OnInitialized()
        {
            ScientificDataRegisterForm = new ScientificDataModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(ScientificDataRegisterForm);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("scientificData", content))
            {
                if (!message.IsSuccessStatusCode) { Console.WriteLine(message.Content); }
            }
        }
    }
}
