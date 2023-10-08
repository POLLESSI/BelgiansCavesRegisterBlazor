using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgiansCavesRegisterBlazor.Client.Pages.Sites
{
    public partial class CreateSite
    {
        [Inject]
        public HttpClient Client { get; set; }
        public SiteModel SiteRegisterForm { get; set; }
        protected override void OnInitialized()
        {
            SiteRegisterForm = new SiteModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(SiteRegisterForm);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("site", content))
            {
                if (!message.IsSuccessStatusCode) { Console.WriteLine(message.Content); }
            }
        }
    }
}
