using EdjCase.ICP.Candid.Mapping;

namespace FreyaSDK.Models
{
    [Variant]
    public class TradeResponse
    {
        [VariantTagProperty]
        public TradeResponseTag Tag { get; set; }

        [VariantValueProperty]
        public object? Value { get; set; }

        public TradeResponse(TradeResponseTag tag, object? value)
        {
            this.Tag = tag;
            this.Value = value;
        }

        protected TradeResponse()
        {
        }

        public static TradeResponse Err(string info)
        {
            return new TradeResponse(TradeResponseTag.Err, info);
        }

        public static TradeResponse Ok()
        {
            return new TradeResponse(TradeResponseTag.Ok, null);
        }

        public string AsErr()
        {
            this.ValidateTag(TradeResponseTag.Err);
            return (string)this.Value!;
        }

        private void ValidateTag(TradeResponseTag tag)
        {
            if (!this.Tag.Equals(tag))
            {
                throw new InvalidOperationException($"Cannot cast '{this.Tag}' to type '{tag}'");
            }
        }
    }

    public enum TradeResponseTag
    {
        [CandidName("err")]
        Err,
        [CandidName("ok")]
        Ok
    }
}