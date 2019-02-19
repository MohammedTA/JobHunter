using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class FavoriteResume
    {
        public int Id { get; set; }
        public DateTime AddDate { get; set; }
        public Boolean IsActive { get; set; }
        public int ResumeId { get; set; }
        public int EmployerId { get; set; }


        public virtual Resume Resume { get; set; }
        public virtual Employer Employer { get; set; }

    }
}
