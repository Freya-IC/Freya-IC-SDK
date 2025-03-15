using EdjCase.ICP.Candid.Mapping;

namespace FreyaSDK.Models
{
    public enum TradeType
    {
        [CandidName("buy")]
        Buy,
        [CandidName("sell")]
        Sell
    }
}