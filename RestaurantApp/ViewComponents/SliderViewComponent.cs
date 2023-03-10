using RestaurantApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RestaurantApp.ViewComponents
{
    [ViewComponent]
    public class SliderViewComponent: ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public SliderViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View(await _context.Slider.ToListAsync());
        }
    }
}

