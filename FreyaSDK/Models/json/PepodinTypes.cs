#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
namespace FreyaSDK.Models
{
    public class BundleCheck
    {
        public string bundle { get; set; }
    }
    public class BTCPriceResponse
    {
        public BTCPrice data { get; set; }
    }
    public class BTCPrice
    {
        public Bitcoin bitcoin { get; set; }
    }
    public class Bitcoin
    {
        public int usd { get; set; }
    }

    public class Holders
    {
        public HolderData[] data { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
        public int count { get; set; }
    }

    public class HolderData
    {
        public string user { get; set; }
        public string token { get; set; }
        public long balance { get; set; }
        public string user_username { get; set; }
        public string user_image { get; set; }
    }

}
