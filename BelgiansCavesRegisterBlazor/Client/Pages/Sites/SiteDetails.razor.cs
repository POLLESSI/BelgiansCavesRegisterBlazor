using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BelgiansCavesRegisterBlazor.Client.Pages.Sites
{
    public partial class SiteDetails
    {
        [Inject]
        public HttpClient Client { get; set; }
        public SiteModel CurrentSite { get; set; }

        [Parameter]
        public int site_Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            await GetSite();
        }
        private async Task GetSite()
        {
            using (HttpResponseMessage message = await Client.GetAsync("site" + site_Id))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CurrentSite = JsonConvert.DeserializeObject<SiteModel>(json);
                }
            }
        }
    }
}
