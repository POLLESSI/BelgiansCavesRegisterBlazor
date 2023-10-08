using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgiansCavesRegisterBlazor.Client.Pages.NUsers
{
    public partial class CreateNUser
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NUserModel NUserLoginForm { get; set; }

        protected override void OnInitialized()
        {
            NUserLoginForm = new NUserModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(NUserLoginForm);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("nuser", content))
            {
                if (!message.IsSuccessStatusCode) { Console.WriteLine(message.Content);}
            }
        }
    }
}
