using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name="Product Id")]
        public int ProductId { get; set; }
        //[Display(Name="Product name")]
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(100)]
        public string? Name { get; set; } = string.Empty; //Name adlı özellik başlangıçta boş bir string ile başlar
        [Required]
        [Range(0, 100000)]
        //[Display(Name="Price")]
        public decimal? Price { get; set; }
        //[Display(Name="Image")]
        [Required]
        public string? Image { get; set; } = string.Empty;
        [Display(Name="Is it active?")]
        public bool IsActive { get; set; }
        [Required]
        [Display(Name="Category")]
        public int? CategoryId { get; set; }
    }
}