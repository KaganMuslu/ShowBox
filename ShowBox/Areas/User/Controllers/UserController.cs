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
                Trending = _context.Series
                    .Select(s => new SerieViewModel
                    {
                        Id = s.Id,
                        Title = s.Title,
                        Type = s.Type,
                        Genre = s.Genre,
                        Score = s.Score,
                        Views = s.Views,
                        Status = s.Status,
                        ReviewCount = s.Reviews.Count, // Count Comment
                        EpisodeCount = s.Episodes.Count // Count Episode
                    })
                    .ToList(),
            };

            return View(baseMovies);
        }
    }
}
