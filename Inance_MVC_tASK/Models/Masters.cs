namespace Inance_MVC_tASK.Models
{
    public class Masters
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public int ExperienceYear { get; set; }
        public bool IsActive { get; set; }
        public int? ServiceId { get; set; }
        public Services? Service { get; set; }
        public ICollection<Orders>? order { get; set; }



    }
}
