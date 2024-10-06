using ShowBox.Models;

namespace ShowBox.Areas.User.Models
{
    public class SerieViewModel : Serie
    {
        public int ReviewCount { get; set; }
        public int EpisodeCount { get; set; }
    }
}
