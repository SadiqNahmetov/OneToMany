using System.Collections.Generic;


namespace EntityFramework.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Product> Products{ get; set; }

    }
}
