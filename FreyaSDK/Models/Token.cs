#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;
using EdjCase.ICP.Candid.Models;
using TokenAmount = EdjCase.ICP.Candid.Models.UnboundedUInt;

namespace FreyaSDK.Models
{
    public class Token
    {
        [CandidName("bonded_btc")]
        public TokenAmount BondedBtc { get; set; }

        [CandidName("bonding_curve")]
        public OptionalValue<BondingCurveSettings> BondingCurve { get; set; }

        [CandidName("bonding_threshold")]
        public TokenAmount BondingThreshold { get; set; }

        [CandidName("bonding_threshold_fee")]
        public TokenAmount BondingThresholdFee { get; set; }

        [CandidName("bonding_threshold_reward")]
        public TokenAmount BondingThresholdReward { get; set; }

        [CandidName("creator")]
        public Principal Creator { get; set; }

        [CandidName("icrc_canister")]
        public OptionalValue<Principal> IcrcCanister { get; set; }

        [CandidName("lp_supply")]
        public TokenAmount LpSupply { get; set; }

        [CandidName("max_supply")]
        public TokenAmount MaxSupply { get; set; }

        [CandidName("pool")]
        public LiquidityPool Pool { get; set; }

        [CandidName("rune")]
        public OptionalValue<Rune> Rune { get; set; }

        [CandidName("supply")]
        public TokenAmount Supply { get; set; }

        public Token(TokenAmount bondedBtc, OptionalValue<BondingCurveSettings> bondingCurve, TokenAmount bondingThreshold, TokenAmount bondingThresholdFee, TokenAmount bondingThresholdReward, Principal creator, OptionalValue<Principal> icrcCanister, TokenAmount lpSupply, TokenAmount maxSupply, LiquidityPool pool, OptionalValue<Rune> rune, TokenAmount supply)
        {
            this.BondedBtc = bondedBtc;
            this.BondingCurve = bondingCurve;
            this.BondingThreshold = bondingThreshold;
            this.BondingThresholdFee = bondingThresholdFee;
            this.BondingThresholdReward = bondingThresholdReward;
            this.Creator = creator;
            this.IcrcCanister = icrcCanister;
            this.LpSupply = lpSupply;
            this.MaxSupply = maxSupply;
            this.Pool = pool;
            this.Rune = rune;
            this.Supply = supply;
        }

        public Token()
        {
        }
    }
}