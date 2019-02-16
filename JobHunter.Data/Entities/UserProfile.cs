using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JobHunter.Data.Entities
{
    public class UserProfile
    {
        public UserProfile()
        {
            Messengers = new Collection<Messenger>();
            Phones = new Collection<PhoneNumber>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ThirdName { get; set; }

        public Collection<Messenger> Messengers { get; }
        public Collection<PhoneNumber> Phones { get; }
    }
}
