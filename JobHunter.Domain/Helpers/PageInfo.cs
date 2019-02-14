using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Domain.Helpers
{
   public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; } = 5;
        public int CurrentPage { get; set; }
        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
            }
        }
    }
}
