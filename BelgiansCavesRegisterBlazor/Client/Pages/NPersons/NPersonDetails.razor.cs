using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BelgiansCavesRegisterBlazor.Client.Pages.NPersons
{
    public partial class PersonDetails
    {
        [Inject]
        public HttpClient Client { get; set; }
        public NPersonModel CurrentNPerson { get; set; }
        [Parameter]
        public int nPerson_Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            await GetNPerson();
        }
        private async Task GetNPerson()
        {
            using (HttpResponseMessage message = await Client.GetAsync("nperson" +  nPerson_Id))
            {
                if (message.IsSuccessStatusCode )
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CurrentNPerson = JsonConvert.DeserializeObject<NPersonModel>(json);
                }
            }
        }
    }
}
