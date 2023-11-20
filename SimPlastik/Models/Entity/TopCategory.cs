using System.ComponentModel.DataAnnotations;

namespace SimPlastik.Models.Entity
{
    public class TopCategory
    {
        [Key]
        public int top_category_id { get; set; }
        public string? top_category_name { get; set; }
        public string? top_category_name_en { get; set; }
        public string? top_category_name_ar { get; set; }
    }
}
