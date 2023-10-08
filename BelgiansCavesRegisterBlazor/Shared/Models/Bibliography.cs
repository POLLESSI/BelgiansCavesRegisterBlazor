using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgiansCavesRegisterBlazor.Shared.Models
{
    public class Bibliography
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public string DataType { get; set; }
        public string Detail { get; set; }
        public bool Active { get; set; }
    }
}
