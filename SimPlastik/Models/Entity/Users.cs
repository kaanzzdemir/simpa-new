using System.ComponentModel.DataAnnotations;

namespace SimPlastik.Models.Entity
{
    public class Users
    {
        [Key]
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string user_password { get; set; }
        public bool is_admin { get; set; }
    }
}
