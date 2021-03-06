﻿using System.Collections.Generic;

namespace JobHunter.Domain.Models.PaginationModels
{
   public class PaginationOutPutModel<T> where T : class
    {
        public List<T> PaginatedList { get; set; }
        public Helpers.PageInfo PageInfo { get; set; }
    }
}
