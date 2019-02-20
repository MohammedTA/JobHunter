using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class Profile
    {

        public Profile()
        {
            Messengers = new List<Messenger>();
            Resumes = new List<Resume>();
            Emails = new List<Email>();
            PhoneNumbers = new List<PhoneNumber>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string MiddleName { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Messenger> Messengers { get; set; }
        public virtual ICollection<Resume> Resumes { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}
