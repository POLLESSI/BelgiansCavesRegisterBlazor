using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BelgiansCavesRegisterBlazor.Client.Pages.NUserRegister
{
    public partial class DetailNUserRegister
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NUserRegisterModel CurrentNUserRegister { get; set; }
        [Parameter]
        public Guid nUserRegister_Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            await GetNUserRegister();
        }
        private async Task GetNUserRegister()
        {
            using (HttpResponseMessage message = await Client.GetAsync("nuserregister" + nUserRegister_Id))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CurrentNUserRegister = JsonConvert.DeserializeObject<NUserRegisterModel>(json);
                }
            }
        }
    }
}
