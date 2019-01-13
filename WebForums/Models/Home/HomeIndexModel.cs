using System.Collections.Generic;
using WebForums.Models.Post;

namespace WebForums.Models.Home
{
    public class HomeIndexModel
    {
        public string SearchQuery { get; set; }
        public IEnumerable<PostListingModel> LatestPosts { get; set; }

    }
}
