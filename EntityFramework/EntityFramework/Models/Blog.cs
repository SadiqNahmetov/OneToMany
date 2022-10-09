using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Blog : BaseEntity
    {
        public string Header { get; set; }
       
        public string Image { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }


    }
}
