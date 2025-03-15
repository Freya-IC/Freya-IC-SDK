#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
namespace FreyaSDK.Models
{
    public class TokenTrades
    {
        public TradeData[] data { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
        public int count { get; set; }
    }

    public class TradeData
    {
        public string id { get; set; }
        public string user { get; set; }
        public string token { get; set; }
        public string time { get; set; }
        public bool buy { get; set; }
        public long amount_btc { get; set; }
        public long amount_token { get; set; }
        public int price { get; set; }
        public bool bonded { get; set; }
        public string user_username { get; set; }
        public string user_image { get; set; }
        public int decimals { get; set; }
        public int divisibility { get; set; }
    }

}
