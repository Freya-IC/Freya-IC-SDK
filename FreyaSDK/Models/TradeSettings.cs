#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;
using EdjCase.ICP.Candid.Models;
using TokenAmount = EdjCase.ICP.Candid.Models.UnboundedUInt;

namespace FreyaSDK.Models
{
    public class TradeSettings
    {
        [CandidName("slippage")]
        public OptionalValue<(TokenAmount, UnboundedUInt)> Slippage { get; set; }

        public TradeSettings(OptionalValue<(TokenAmount, UnboundedUInt)> slippage)
        {
            this.Slippage = slippage;
        }

        public TradeSettings()
        {


        }
    }
}