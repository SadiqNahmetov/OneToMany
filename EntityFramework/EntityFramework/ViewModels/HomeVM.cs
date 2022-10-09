using EntityFramework.Models;

using System.Collections.Generic;


namespace EntityFramework.ViewModels
{
    public class HomeVM
    {
       

        public IEnumerable<Slider> Sliders { get; internal set; }

        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<Product> Products { get; set; }


        public IEnumerable<AboutText> AboutTexts { get; set; }

        public IEnumerable<FlowerExperts> FlowerExperts { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }


        public AboutImage AboutImage { get; set; }

        public SliderDetail SliderDetail { get; set; }

    }
}
