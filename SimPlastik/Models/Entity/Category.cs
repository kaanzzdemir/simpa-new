using System.ComponentModel.DataAnnotations;

namespace SimPlastik.Models.Entity
{
    public class Category
    {
        [Key]
        public int category_id { get; set; }
        public string category_name { get; set; }
        public TopCategory topCategory { get; set; }
        public int top_category_id { get; set; }
    }
}
