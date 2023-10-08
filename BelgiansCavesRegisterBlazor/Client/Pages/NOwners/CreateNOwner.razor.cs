using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgiansCavesRegisterBlazor.Client.Pages.NOwners
{
    public partial class CreateNOwner
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NOwnerModel NOwnerRegisterForm { get; set; }
        protected override void OnInitialized()
        {
            NOwnerRegisterForm = new NOwnerModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(NOwnerRegisterForm);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("nowner", content))
            {
                if (!message.IsSuccessStatusCode) { Console.WriteLine(message.Content); }
            }
        }
    }
}
