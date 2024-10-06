using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShowBox.Areas.User.Models;
using ShowBox.Data;

namespace ShowBox.Areas.User.Controllers
{
    [Area("User")]
    public class UserController : UserBaseController
    {
        public UserController(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public IActionResult Index()
        {
            var baseMovies = new UserViewModel
            {
                Trending = _context.Series.Include(x => x.Reviews).ToList(),
            };

            return View(baseMovies);
        }
    }
}
