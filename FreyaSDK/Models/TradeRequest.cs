#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;
using EdjCase.ICP.Candid.Models;
using TokenID = System.String;

namespace FreyaSDK.Models
{
    public class TradeRequest
    {
        [CandidName("tokenid")]
        public TokenID Tokenid { get; set; }

        [CandidName("typeof")]
        public TradeType Typeof { get; set; }

        [CandidName("settings")]
        public OptionalValue<TradeSettings> Settings { get; set; }

        [CandidName("amount")]
        public TradeAmount Amount { get; set; }

        public TradeRequest(TradeAmount amount, OptionalValue<TradeSettings> settings, TokenID tokenid, TradeType @typeof)
        {
            this.Amount = amount;
            //this.Settings = settings;
            this.Tokenid = tokenid;
            this.Typeof = @typeof;
        }

        public TradeRequest()
        {
        }
    }
}