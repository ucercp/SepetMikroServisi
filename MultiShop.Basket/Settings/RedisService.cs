using StackExchange.Redis;

namespace MultiShop.Basket.Settings
{
    public class RedisService
    {
        public string _host { get; set; }
        public int _port { get; set; }

        private ConnectionMultiplexer _connectionMultiplexer;//redis e bağlanmak için "ConnectionMultiplexer" köprü görevi görür
        public RedisService(string host, int port)
        {
            _host = host;
            _port = port;
        }

        public void Connect() => _connectionMultiplexer = ConnectionMultiplexer.Connect($"{_host}:{_port}");//connetc metodu ile host ve port numarasına erişim sağlıyorum
        public IDatabase GetDb(int db = 1) => _connectionMultiplexer.GetDatabase(0);// Bu kod, _connectionMultiplexer adında bir ConnectionMultiplexer nesnesine
                                                                                    // erişir ve bu nesne üzerinden Redis veritabanına bağlanır.
                                                                                    // GetDatabase metodu, belirli bir veritabanını seçmek için kullanılır.
    }
}