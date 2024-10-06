using Microsoft.AspNetCore.Mvc;
using ShowBox.Data;

namespace ShowBox.Areas.User.Controllers
{
    public abstract class UserBaseController : Controller
    {
        protected readonly AppDbContext _context;

        public UserBaseController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

    }
}
