#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using TokenAmount = EdjCase.ICP.Candid.Models.UnboundedUInt;
namespace FreyaSDK.Models.json
{

    public class OdinUser
    {
        public string principal { get; set; }
        public string username { get; set; }
        public object bio { get; set; }
        public string image { get; set; }
        public object referrer { get; set; }
        public bool admin { get; set; }
        public string ref_code { get; set; }
        public object profit { get; set; }
        public object total_asset_value { get; set; }
        public TokenAmount referral_earnings { get; set; }
        public int referral_count { get; set; }
        public bool access_allowed { get; set; }
        public string beta_access_codes { get; set; }
        public string btc_deposit_address { get; set; }
        public string btc_wallet_address { get; set; }
        public string blife_id { get; set; }
        public DateTime created_at { get; set; }
        public string rune_deposit_address { get; set; }
    }

}
