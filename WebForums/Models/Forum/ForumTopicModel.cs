using System.Collections.Generic;
using WebForums.Models.Post;

namespace WebForums.Models.Forum
{
    public class ForumTopicModel
    {
        public ForumListingModel Forum { get; set; }
        public IEnumerable<PostListingModel> Posts { get; set; }

        public string SearchQuery { get; set; }
    }
}
