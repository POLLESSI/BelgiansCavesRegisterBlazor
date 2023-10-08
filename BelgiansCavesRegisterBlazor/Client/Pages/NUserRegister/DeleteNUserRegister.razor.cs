using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.Components;

namespace BelgiansCavesRegisterBlazor.Client.Pages.NUserRegister
{
    public partial class DeleteNUserRegister
    {
        [Inject]
        public HttpClient Client { get; set; }
        NUserRegister NUserRegister = new NUserRegister();
        public NUserRegisterModel DeletedNUserRegister { get; set; }
        [Parameter]
        public Guid nUserRegister_Id { get; set; }
        protected override async Task OnInitializedAsync()
        {
            NUserRegister = await Http.GetFromJsonAsync<NUserRegister>("/api/nuserRegister/" + Convert.ToInt32(nUserRegister_Id));
            
        }
        protected async Task RemoveNUserRegister(Guid nUserRegister_Id)
        {
            await Http.DeleteAsync("api/NuserRegister/" + nUserRegister_Id);
            NavigationManager.NavigateTo("/fetchnuserregisterdetails");
        }
        void Cancel()
        {
            NavigationManager.NavigateTo("/fetchnuserregisterdetails");
        }
    }
}
