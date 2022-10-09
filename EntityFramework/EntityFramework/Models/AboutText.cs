using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class AboutText :BaseEntity
    {
         public string Header { get; set; }
        public string Description { get; set; }
        public string Heart { get; set; }


        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }




    }
}
