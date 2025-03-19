#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;
using TokenID = System.String;

namespace FreyaSDK.Models
{
    public class LockedTokenState
    {
        [CandidName("liquidity")]
        public LiquidityInfo Liquidity { get; set; }

        [CandidName("trade")]
        public TradeInfo Trade { get; set; }

        [CandidName("withdraw")]
        public WithdrawInfo Withdraw { get; set; }

        public LockedTokenState(LiquidityInfo liquidity, TradeInfo trade, WithdrawInfo withdraw)
        {
            this.Liquidity = liquidity;
            this.Trade = trade;
            this.Withdraw = withdraw;
        }

        public LockedTokenState()
        {

        }
    }
    public class LiquidityInfo : List<TokenID>
    {
        public LiquidityInfo()
        {
        }
    }

    public class TradeInfo : List<TokenID>
    {
        public TradeInfo()
        {
        }
    }

    public class WithdrawInfo : List<TokenID>
    {
        public WithdrawInfo()
        {
        }
    }
}

