using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class ContactModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
        public Guid Guid { get; set; }
    }
}
