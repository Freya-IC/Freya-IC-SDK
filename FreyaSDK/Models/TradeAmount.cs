using EdjCase.ICP.Candid.Mapping;
using TokenAmount = EdjCase.ICP.Candid.Models.UnboundedUInt;

namespace FreyaSDK.Models
{
    [Variant]
    public class TradeAmount
    {
        [VariantTagProperty]
        public TradeAmountTag Tag { get; set; }

        [VariantValueProperty]
        public object? Value { get; set; }

        public TradeAmount(TradeAmountTag tag, object? value)
        {
            this.Tag = tag;
            this.Value = value;
        }

        protected TradeAmount()
        {
        }

        public static TradeAmount Btc(TokenAmount info)
        {
            return new TradeAmount(TradeAmountTag.Btc, info);
        }

        public static TradeAmount Token(TokenAmount info)
        {
            return new TradeAmount(TradeAmountTag.Token, info);
        }

        public TokenAmount AsBtc()
        {
            this.ValidateTag(TradeAmountTag.Btc);
            return (TokenAmount)this.Value!;
        }

        public TokenAmount AsToken()
        {
            this.ValidateTag(TradeAmountTag.Token);
            return (TokenAmount)this.Value!;
        }

        private void ValidateTag(TradeAmountTag tag)
        {
            if (!this.Tag.Equals(tag))
            {
                throw new InvalidOperationException($"Cannot cast '{this.Tag}' to type '{tag}'");
            }
        }
    }

    public enum TradeAmountTag
    {
        [CandidName("btc")]
        Btc,
        [CandidName("token")]
        Token
    }
}