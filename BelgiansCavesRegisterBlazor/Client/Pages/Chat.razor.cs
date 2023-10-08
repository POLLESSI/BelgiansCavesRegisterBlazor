using BelgiansCavesRegisterBlazor.Client.Models;
using Microsoft.AspNetCore.SignalR.Client;

namespace BelgiansCavesRegisterBlazor.Client.Pages
{
    public partial class Chat
    {
        public List<Message> ListeMessages { get; set; }
        public string newMessage { get; set; }
        public string Author { get; set; }
        public HubConnection HubConnection { get; set; }

        protected override async Task OnInitializeAsync()
        {
            ListeMessages = new List<Message>();
            HubConnection = new HubConnectionBuilder().WithUrl(new Uri("https://localhost:7090/chat")).Build();
            await HubConnection.StartAsync();
            HubConnection.On("receiveMessage",
                (Message mesage) =>
                {
                    ListeMessages.Add(mesage);
                    StateHasChanged();
                });
        }
    }
}
