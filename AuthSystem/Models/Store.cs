namespace AuthSystem.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string KnowledgeBaseLink { get; set; }
        public bool Active { get; set; }
    }
}