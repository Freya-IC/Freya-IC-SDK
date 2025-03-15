#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
namespace FreyaSDK.Models
{
    public class OdinFunTokens
    {
        public TokenData[] data { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
        public int count { get; set; }
    }

    public class TokenData
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string creator { get; set; }
        public string created_time { get; set; }
        public long volume { get; set; }
        public bool bonded { get; set; }
        public string icrc_ledger { get; set; }
        public int price { get; set; }
        public long marketcap { get; set; }
        public string rune { get; set; }
        public bool featured { get; set; }
        public int holder_count { get; set; }
        public int holder_top { get; set; }
        public long holder_dev { get; set; }
        public int comment_count { get; set; }
        public long sold { get; set; }
        public string twitter { get; set; }
        public string website { get; set; }
        public string telegram { get; set; }
        public string? last_comment_time { get; set; }
        public int sell_count { get; set; }
        public int buy_count { get; set; }
        public string ticker { get; set; }
        public long btc_liquidity { get; set; }
        public long token_liquidity { get; set; }
        public long user_btc_liquidity { get; set; }
        public long user_token_liquidity { get; set; }
        public long user_lp_tokens { get; set; }
        public long total_supply { get; set; }
        public int swap_fees { get; set; }
        public int swap_fees_24 { get; set; }
        public long swap_volume { get; set; }
        public long swap_volume_24 { get; set; }
        public long threshold { get; set; }
        public int txn_count { get; set; }
        public int divisibility { get; set; }
        public int decimals { get; set; }
        public bool withdrawals { get; set; }
        public bool deposits { get; set; }
        public bool trading { get; set; }
        public bool external { get; set; }
        public int price_5m { get; set; }
        public int price_1h { get; set; }
        public int price_6h { get; set; }
        public int price_1d { get; set; }
        public string rune_id { get; set; }
        public string last_action_time { get; set; }
    }

}
