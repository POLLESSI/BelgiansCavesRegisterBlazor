using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgiansCavesRegisterBlazor.Client.Pages.NUserRegister
{
    public partial class CreateNUserRegister
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NUserRegisterModel NUserRegisterForm { get; set; }
        protected override void OnInitialized()
        {
            NUserRegisterForm = new NUserRegisterModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(NUserRegisterForm);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("nuserregister", content))
            {
                if (!message.IsSuccessStatusCode)
                { Console.WriteLine(message.Content); }}
            }
        }
    }
}
