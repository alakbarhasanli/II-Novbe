namespace Inance_MVC_tASK.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public string ClienrtName { get; set; }
        public string ClientSurname { get; set; }
        public string ClientEmail { get; set; }
        public string ClientPhoneNumber { get; set; }
        public int? ServiceId { get; set; }
        public int? MasterId { get; set; }
        public Services? Service { get; set; }
        public Masters? Master { get; set; }
        public string Problem { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}
