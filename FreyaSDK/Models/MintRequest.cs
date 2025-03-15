#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;
using EdjCase.ICP.Candid.Models;
using TokenAmount = EdjCase.ICP.Candid.Models.UnboundedUInt;

namespace FreyaSDK.Models
{
    public class MintRequest
    {
        [CandidName("code")]
        public OptionalValue<string> Code { get; set; }

        [CandidName("metadata")]
        public Metadata Metadata { get; set; }

        [CandidName("prebuy_amount")]
        public MintRequest.PrebuyAmountInfo PrebuyAmount { get; set; }

        public MintRequest(OptionalValue<string> code, Metadata metadata, MintRequest.PrebuyAmountInfo prebuyAmount)
        {
            this.Code = code;
            this.Metadata = metadata;
            this.PrebuyAmount = prebuyAmount;
        }

        public MintRequest()
        {
        }

        public class PrebuyAmountInfo : OptionalValue<TokenAmount>
        {
            public PrebuyAmountInfo()
            {
            }

            public PrebuyAmountInfo(TokenAmount value) : base(value)
            {
            }
        }
    }
}