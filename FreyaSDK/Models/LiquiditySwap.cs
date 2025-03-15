#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;
using TokenAmount = EdjCase.ICP.Candid.Models.UnboundedUInt;

namespace FreyaSDK.Models
{
    public class LiquiditySwap
    {
        [CandidName("btc")]
        public TokenAmount Btc { get; set; }

        [CandidName("token")]
        public TokenAmount Token { get; set; }

        public LiquiditySwap(TokenAmount btc, TokenAmount token)
        {
            this.Btc = btc;
            this.Token = token;
        }

        public LiquiditySwap()
        {
        }
    }
}