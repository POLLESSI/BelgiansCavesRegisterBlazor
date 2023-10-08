using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BelgiansCavesRegisterBlazor.Client.Pages.Bibliographies
{
    public partial class BibliographyDetails
    {
        [Inject]
        public HttpClient Client { get; set; }
        public BibliographyModel CurrentBibliography { get; set; }
        [Parameter]
        public int bibliography_Id { get; set;}
        protected override async Task OnParametersSetAsync()
        {
            await GetBibliography();
        }
        private async Task GetBibliography()
        {
            using (HttpResponseMessage message = await Client.GetAsync("bibliography" + bibliography_Id))
            {
                if (message.IsSuccessStatusCode)
                {
                    string json = await message.Content.ReadAsStringAsync();
                    CurrentBibliography = JsonConvert.DeserializeObject<BibliographyModel>(json);
                }
            }
        }
    }
}