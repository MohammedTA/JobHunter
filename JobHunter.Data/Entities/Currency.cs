﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class Currency
    {
        public Currency()
        {
            Vacancies = new List<Vacancy>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Vacancy> Vacancies { get; set; }
    }
}
