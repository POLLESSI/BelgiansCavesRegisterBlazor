using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgiansCavesRegisterBlazor.Client.Pages.ScientificDatas
{
    public partial class ScientificDataDetails
    {
        [Inject]
        public HttpClient Client { get; set; }
        public ScientificDataModel CurrentScientificData { get; set; }
        [Parameter]
        public int scientificData_Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            await GetScientificData();
        }
        private async Task GetScientificData()
        {
            using (HttpResponseMessage message = await Client.GetAsync("scientificdata" + scientificData_Id))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CurrentScientificData = JsonConvert.DeserializeObject<ScientificDataModel>(json);
                }
            }
        }
    }
}
