using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text

namespace BelgiansCavesRegisterBlazor.Client.Pages.Bibliographies
{
    public partial class CreateBibliogrraphy
    {
        [Inject]
        public HttpClient Client { get; set; }
        public BibliographyModel BibliographyRegisterForm { get; set; }

        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(BibliographyRegisterForm);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("bibliography", content))
            {
                if (!message.IsSuccessStatusCode) { Console.WriteLine(message.Content); }
            }
        }  
    }
}
