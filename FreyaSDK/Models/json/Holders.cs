#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using TokenAmount = EdjCase.ICP.Candid.Models.UnboundedUInt;
namespace FreyaSDK.Models.json
{
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
        public TokenAmount balance { get; set; }
        public string user_username { get; set; }
        public string user_image { get; set; }
    }
}
