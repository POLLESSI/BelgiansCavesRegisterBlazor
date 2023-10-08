using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgiansCavesRegisterBlazor.Shared.Models
{
    public class NUser
    {
        public string Pseudo { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string Email { get; set; }
        public int NPerson_Id { get; set; }
        public bool IsAdmin { get; set; } = false;
        public bool Active { get; set; } = true;
    }
}
