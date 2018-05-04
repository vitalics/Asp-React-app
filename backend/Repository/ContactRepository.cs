using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Repository
{
    public class ContactRepository
    {
        public IEnumerable<ContactModel> getContacts()
        {
            return new ContactModel[] {
                new ContactModel() { Name = "chewbacca", Phone = "123456", Image = "img/chewbacca.gif", Guid = Guid.NewGuid() },
                new ContactModel() { Name = "darth", Phone = "123456", Image = "img/darth.gif", Guid = Guid.NewGuid() },
                new ContactModel() { Name = "leia", Phone = "123456", Image = "img/leia.gif", Guid = Guid.NewGuid() },
                new ContactModel() { Name = "luke", Phone = "123456", Image = "img/luke.gif", Guid = Guid.NewGuid() }
            };
        }
    }
}
