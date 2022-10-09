using EntityFramework.Data;
using EntityFramework.Models;
using EntityFramework.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
       

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Slider> sliders =  await _context.Sliders.ToListAsync();


            SliderDetail sliderDetail = await _context.SliderDetails.FirstOrDefaultAsync();

            IEnumerable<Category> categories = await _context.Categories.Where(m => m.IsDeleted == false).ToListAsync();
            IEnumerable<Product> products = await _context.Products
                .Where(m => m.IsDeleted == false)
                .Include(m => m.Category).Include(m => m.ProductImages).Take(8)?.ToListAsync();

            IEnumerable<AboutText> aboutTexts = await _context.AboutTexts.Where(m => m.IsDeleted == false).ToListAsync();

            IEnumerable<FlowerExperts> flowerExperts = await _context.FlowerExperts.Where(m => m.IsDeleted == false).ToListAsync();
            IEnumerable<Blog> blogs = await _context.Blogs.Where(m => m.IsDeleted == false).ToListAsync();

            AboutImage aboutImage = await _context.AboutImages.Where(m => m.IsDeleted == false).FirstOrDefaultAsync();


            HomeVM model = new HomeVM
            {
                Sliders = sliders,
                SliderDetail = sliderDetail,
                Categories = categories,
                Products = products,
                AboutTexts = aboutTexts,
                AboutImage = aboutImage,
                FlowerExperts = flowerExperts,
                Blogs = blogs
              

                

            };
            return View(model);
        }

      

     
    }
}
