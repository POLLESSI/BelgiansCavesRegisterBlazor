using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgiansCavesRegisterBlazor.Shared.Models
{
    public class NPerson
    {
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Address_Streett { get; set; }
        public int Address_Nbr { get; set; }
        public int PostalCode { get; set; }
        public string Address_City { get; set;}
        public string Address_Country { get; set;}

        public int Telephone { get; set;}
        public int Gsm { get; set;}
    }
}
