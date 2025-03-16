using EdjCase.ICP.Candid.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
}
