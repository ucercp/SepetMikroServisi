namespace MultiShop.Basket.Dtos
{
    public class BasketTotalDto
    {
        public string UserId { get; set; } //sepeti kullanıcının ıd sine göre  (kullanıcıları Identity serverde tuıtuyoruz 
        public string DiscountCode { get; set; }//indirim kodu kullanılırsa
        public int DiscountRate { get; set; }//indirim kodunu her zaman kullanmak zorunda degilsin
        public List<BasketItemDto> BasketItems { get; set; }//ürünleri listele
        public decimal TotalPrice { get => BasketItems.Sum(x => x.Price * x.Quantity); }//toplam maliyet
    }
}
