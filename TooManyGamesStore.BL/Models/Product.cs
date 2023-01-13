namespace TooManyGamesStore.BL.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public Category ProductCategory { get; set; }
        public Platform ProductPlatform { get; set; }
        public Image ProductImage { get; set; }
    }
}