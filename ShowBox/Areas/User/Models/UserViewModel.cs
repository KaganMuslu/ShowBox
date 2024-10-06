using ShowBox.Models;

namespace ShowBox.Areas.User.Models
{
    public class UserViewModel
    {
        public List<Serie>? MainSeries { get; set; }
        public List<Serie>? Trending { get; set; }
        public List<Serie>? Popular { get; set; }
        public List<Serie>? NewSeries { get; set; }
        public List<Serie>? TopViews { get; set; }
        public List<Serie>? NewEpisode { get; set; }
    }
}
