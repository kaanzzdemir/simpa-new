using System.ComponentModel.DataAnnotations;

namespace SimPlastik.Models.Entity
{
    public class Contact
    {
        [Key]
        public int contact_id { get; set; }
        public string? number { get; set; }
        public string? mail { get; set; }
        public string? address { get; set; }
        public string? other_number_3 { get; set; }
        public string? other_number_2 { get; set; }
        public string? other_number_1 { get; set; }
    }
}
