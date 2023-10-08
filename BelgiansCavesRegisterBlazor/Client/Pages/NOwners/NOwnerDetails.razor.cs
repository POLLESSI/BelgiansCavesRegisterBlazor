using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BelgiansCavesRegisterBlazor.Client.Pages.NOwners
{
    public partial class NOwnerDetails
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NOwnerModel CurrentNOwner { get; set; }
        [Parameter]
        public int nOwner_Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            await GetNOwner();
        }
        private async Task GetNOwner()
        {
            using (HttpResponseMessage message = await Client.GetAsync("nowner" +  nOwner_Id))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CurrentNOwner = JsonConvert.DeserializeObject<NOwnerModel>(json);
                }
            }
        }
    }
}
