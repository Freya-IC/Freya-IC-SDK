using EdjCase.ICP.Candid.Mapping;

namespace FreyaSDK.Models
{
    public enum WithdrawProtocol
    {
        [CandidName("btc")]
        Btc,
        [CandidName("ckbtc")]
        Ckbtc,
        [CandidName("volt")]
        Volt
    }
}