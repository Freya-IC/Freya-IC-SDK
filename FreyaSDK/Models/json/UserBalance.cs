namespace FreyaSDK.Models.json
{

    public class UserBalances
    {
        public UserBalance[] data { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
        public int count { get; set; }
    }

    public class UserBalance
    {
        public string id { get; set; }
        public string ticker { get; set; }
        public string rune { get; set; }
        public string name { get; set; }
        public int balance { get; set; }
        public object image { get; set; }
        public int divisibility { get; set; }
        public int decimals { get; set; }
        public string rune_id { get; set; }
        public bool trading { get; set; }
        public bool deposits { get; set; }
        public bool withdrawals { get; set; }
    }

}
