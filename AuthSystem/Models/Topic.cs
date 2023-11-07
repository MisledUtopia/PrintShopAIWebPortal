using AuthSystem.Areas.Identity.Data;

namespace AuthSystem.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Trending { get; set; }
        public bool Active { get; set; }

        public ApplicationUser User { get; set; }
    }
}