using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text;

namespace BelgiansCavesRegisterBlazor.Client.Pages.LabdaDatas
{
    public partial class CreateLambdaData
    {
        [Inject]
        public HttpClient Client { get; set; }
        public LambdaDataModel LambdaDataRegisterForm { get; set; }

        protected override void OnInitialized()
        {
            LambdaDataRegisterForm = new LambdaDataModel();
        }
        public async Task submit()
        {
            string json = JsonConvert.SerializeObject(LambdaDataRegisterForm);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage message = await Client.PostAsync("lambdaData", content))
            {
                if (!message.IsSuccessStatusCode) { Console.WriteLine(message.Content); }
            }
        }
    }
}
