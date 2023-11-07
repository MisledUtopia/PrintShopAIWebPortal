using AuthSystem.Areas.Identity.Data;

namespace AuthSystem.Models
{
    public class Key
    {
        public int Id { get; set; }
        public string APIKey { get; set; }
        public bool StoreId { get; set; }
        public bool Active { get; set; }

        public ApplicationUser User { get; set; }
    }
}