#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;
using EdjCase.ICP.Candid.Models;
using TokenAmount = EdjCase.ICP.Candid.Models.UnboundedUInt;

namespace FreyaSDK.Models
{
    public class AddRequest
    {
        [CandidName("divisibility")]
        public UnboundedUInt Divisibility { get; set; }

        [CandidName("icrc_canister")]
        public Principal IcrcCanister { get; set; }

        [CandidName("liquidity_threshold")]
        public TokenAmount LiquidityThreshold { get; set; }

        [CandidName("metadata")]
        public Metadata Metadata { get; set; }

        [CandidName("price")]
        public TokenAmount Price { get; set; }

        [CandidName("rune")]
        public Rune Rune { get; set; }

        [CandidName("supply")]
        public TokenAmount Supply { get; set; }

        public AddRequest(UnboundedUInt divisibility, Principal icrcCanister, TokenAmount liquidityThreshold, Metadata metadata, TokenAmount price, Rune rune, TokenAmount supply)
        {
            this.Divisibility = divisibility;
            this.IcrcCanister = icrcCanister;
            this.LiquidityThreshold = liquidityThreshold;
            this.Metadata = metadata;
            this.Price = price;
            this.Rune = rune;
            this.Supply = supply;
        }

        public AddRequest()
        {
        }
    }
}