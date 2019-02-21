using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public Boolean IsMain { get; set; }

        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
