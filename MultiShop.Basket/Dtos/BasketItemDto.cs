namespace MultiShop.Basket.Dtos
{
    public class BasketItemDto
    { //product: int olursa uzun vadede sıkıntı yaşarsın. Katalog mikroservisinden
      //çekeceğim ve veriler string türünden oldıgu için string olarak tanımladım
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
