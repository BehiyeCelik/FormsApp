namespace FormsApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty; //Name adlı özellik başlangıçta boş bir string ile başlar
        public decimal Price { get; set; }
        public string Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public int Categoryld { get; set; }
    }
}