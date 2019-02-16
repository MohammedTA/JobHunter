using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class Messenger
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Number { get; set; }

        public UserProfile Profile { get; set; }
    }
}
