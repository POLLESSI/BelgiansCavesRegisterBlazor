using BelgiansCavesRegisterBlazor.Client.Models;

namespace BelgiansCavesRegisterBlazor.Client.Models
{
    public class NUserModel
    {
        public string Pseudo { get; set; }
        public byte PasswordHash { get; set; }
        public Guid SecurityStamp { get; set; }
        public string Email { get; set; }
        public NPerson NPerson_Id { get; set; }
        public bool IsAdmin { get; set; }
        public bool Active { get; set; }
    }
}
