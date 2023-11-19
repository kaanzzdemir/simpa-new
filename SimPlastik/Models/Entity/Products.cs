using System.ComponentModel.DataAnnotations;

namespace SimPlastik.Models.Entity
{
    public class Products
    {
        [Key]
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string product_code { get; set; }
        public string product_desc { get; set; }
        public string product_info_piece { get; set; }
        public string product_info_box_weight { get; set; }
        public string product_info_box_measurement { get; set; }
        public string product_info_shipment { get; set; }
        public string product_color { get; set; }
        public string product_img_4 { get; set; }
        public string product_img_3 { get; set; }
        public string product_img_2 { get; set; }
        public string product_img_1 { get; set; }
        public Category category { get; set; }
        public int category_id { get; set; }
    }
}
