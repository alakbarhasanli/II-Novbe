namespace Inance_MVC_tASK.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Masters>? Master { get; set; }
        public ICollection<Orders>? order1 { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
