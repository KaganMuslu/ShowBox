using ShowBox.Models;

namespace ShowBox.Areas.User.Models
{
    public class UserViewModel
    {
        public List<SerieViewModel>? MainSeries { get; set; }
        public List<SerieViewModel>? Trending { get; set; }
        public List<SerieViewModel>? Popular { get; set; }
        public List<SerieViewModel>? NewSeries { get; set; }
        public List<SerieViewModel>? TopViews { get; set; }
        public List<SerieViewModel>? NewEpisode { get; set; }
    }
}
