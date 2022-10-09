using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class FlowerExperts : BaseEntity
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

    }
}
