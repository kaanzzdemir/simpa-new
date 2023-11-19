using SimPlastik.Models.Entity;

namespace SimPlastik.Models.ViewModels
{
    public class LayoutViewModel
    {
        public LayoutViewModel()
        {
            Contacts = new List<Contact>();
            Abouts = new List<About>();
            Categories = new List<Category>();
            TopCategories = new List<TopCategory>();
            Products = new List<Products>();
        }
        public List<Contact> Contacts { get; set; }
        public List<About> Abouts { get; set; }
        public List<Category> Categories { get; set; }
        public List<TopCategory> TopCategories { get; set; }
        public List<Products> Products { get; set; }
    }
}
