using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name="Product Id")]
        public int ProductId { get; set; }
        //[Display(Name="Product name")]
        public string Name { get; set; } = string.Empty; //Name adlı özellik başlangıçta boş bir string ile başlar
        //[Display(Name="Price")]
        public decimal Price { get; set; }
        //[Display(Name="Image")]
        public string Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
    }
}