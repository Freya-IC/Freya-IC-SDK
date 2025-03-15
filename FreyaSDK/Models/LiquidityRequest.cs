#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;
using TokenAmount = EdjCase.ICP.Candid.Models.UnboundedUInt;
using TokenID = System.String;

namespace FreyaSDK.Models
{
    public class LiquidityRequest
    {
        [CandidName("amount")]
        public TokenAmount Amount { get; set; }

        [CandidName("tokenid")]
        public TokenID Tokenid { get; set; }

        [CandidName("typeof")]
        public LiquidityType Typeof { get; set; }

        public LiquidityRequest(TokenAmount amount, TokenID tokenid, LiquidityType @typeof)
        {
            this.Amount = amount;
            this.Tokenid = tokenid;
            this.Typeof = @typeof;
        }

        public LiquidityRequest()
        {
        }
    }
}