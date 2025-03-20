#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using TokenAmount = EdjCase.ICP.Candid.Models.UnboundedUInt;
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
        public TokenAmount balance { get; set; }
        public object image { get; set; }
        public int divisibility { get; set; }
        public int decimals { get; set; }
        public string rune_id { get; set; }
        public bool trading { get; set; }
        public bool deposits { get; set; }
        public bool withdrawals { get; set; }
    }

}
