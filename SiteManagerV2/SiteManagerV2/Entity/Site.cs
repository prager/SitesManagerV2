namespace SiteManagerV2.Entity
{
    public class Site
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Type { get; set; }
        public required string Location { get; set; }
        public required string Description { get; set; }
    }
}
