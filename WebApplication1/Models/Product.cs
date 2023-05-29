using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public List<SelectListItem> Categories { get; set; }
    }
}
