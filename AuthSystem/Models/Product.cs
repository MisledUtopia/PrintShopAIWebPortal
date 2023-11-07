using AuthSystem.Areas.Identity.Data;

namespace AuthSystem.Models
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ImageId { get; set; }
        public string Name { get; set; }
        public string Story { get; set; }
        public DateTime Created { get; set; }     
        public bool Active { get; set; }

        public ApplicationUser User { get; set; }
        public List<Style> Styles { get; set; }
        public List<Topic> Topics { get; set; }
    }
}