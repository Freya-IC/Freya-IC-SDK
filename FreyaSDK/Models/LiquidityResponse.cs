using EdjCase.ICP.Candid.Mapping;

namespace FreyaSDK.Models
{
    [Variant]
    public class LiquidityResponse
    {
        [VariantTagProperty]
        public LiquidityResponseTag Tag { get; set; }

        [VariantValueProperty]
        public object? Value { get; set; }

        public LiquidityResponse(LiquidityResponseTag tag, object? value)
        {
            this.Tag = tag;
            this.Value = value;
        }

        protected LiquidityResponse()
        {
        }

        public static LiquidityResponse Err(string info)
        {
            return new LiquidityResponse(LiquidityResponseTag.Err, info);
        }

        public static LiquidityResponse Ok()
        {
            return new LiquidityResponse(LiquidityResponseTag.Ok, null);
        }

        public string AsErr()
        {
            this.ValidateTag(LiquidityResponseTag.Err);
            return (string)this.Value!;
        }

        private void ValidateTag(LiquidityResponseTag tag)
        {
            if (!this.Tag.Equals(tag))
            {
                throw new InvalidOperationException($"Cannot cast '{this.Tag}' to type '{tag}'");
            }
        }
    }

    public enum LiquidityResponseTag
    {
        [CandidName("err")]
        Err,
        [CandidName("ok")]
        Ok
    }
}