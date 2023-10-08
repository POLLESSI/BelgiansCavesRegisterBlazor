using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text; 

namespace BelgiansCavesRegisterBlazor.Client.Pages.NPersons
{
    public partial class CreatePerson
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NPersonModel NPersonForm { get; set; }
        protected override void OnInitialized()
        {
            NPersonForm = new NPersonModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(NPersonForm);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("nperson", content))
            {
                if (!message.IsSuccessStatusCode) { Console.WriteLine(message.Content);}
            }
        }
    }
}
