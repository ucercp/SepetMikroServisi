namespace MultiShop.Basket.LoginServices
{
    public class LoginService : ILoginService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public LoginService(IHttpContextAccessor contextAccessor)
        {
            _httpContextAccessor = contextAccessor;
        }

        public string GetUserId => _httpContextAccessor.HttpContext.User.FindFirst("sub").Value;//kullanıcı kimliğini almak için kullanılır. Kod, _httpContextAccessor üzerinden geçerli HTTP isteğinin HttpContext nesnesine erişir
                                                                                                //ve bu nesne üzerinden kullanıcının kimlik bilgilerini temsil eden ClaimsPrincipal nesnesine erişir.
                                                                                                //Ardından, "sub" iddiasının değerini döndürür.
    }
}