#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;
using TokenAmount = EdjCase.ICP.Candid.Models.UnboundedUInt;

namespace FreyaSDK.Models
{
    public class TokenDeltasItem
    {
        [CandidName("delta")]
        public TokenDeltasItem.DeltaInfo Delta { get; set; }

        [CandidName("field")]
        public string Field { get; set; }

        public TokenDeltasItem(TokenDeltasItem.DeltaInfo delta, string field)
        {
            this.Delta = delta;
            this.Field = field;
        }

        public TokenDeltasItem()
        {
        }

        [Variant]
        public class DeltaInfo
        {
            [VariantTagProperty]
            public TokenDeltasItem.DeltaInfoTag Tag { get; set; }

            [VariantValueProperty]
            public object? Value { get; set; }

            public DeltaInfo(TokenDeltasItem.DeltaInfoTag tag, object? value)
            {
                this.Tag = tag;
                this.Value = value;
            }

            protected DeltaInfo()
            {
            }

            public static TokenDeltasItem.DeltaInfo Add(TokenAmount info)
            {
                return new TokenDeltasItem.DeltaInfo(TokenDeltasItem.DeltaInfoTag.Add, info);
            }

            public static TokenDeltasItem.DeltaInfo Amount(TokenAmount info)
            {
                return new TokenDeltasItem.DeltaInfo(TokenDeltasItem.DeltaInfoTag.Amount, info);
            }

            public static TokenDeltasItem.DeltaInfo Bool(bool info)
            {
                return new TokenDeltasItem.DeltaInfo(TokenDeltasItem.DeltaInfoTag.Bool, info);
            }

            public static TokenDeltasItem.DeltaInfo Sub(TokenAmount info)
            {
                return new TokenDeltasItem.DeltaInfo(TokenDeltasItem.DeltaInfoTag.Sub, info);
            }

            public static TokenDeltasItem.DeltaInfo Text(string info)
            {
                return new TokenDeltasItem.DeltaInfo(TokenDeltasItem.DeltaInfoTag.Text, info);
            }

            public TokenAmount AsAdd()
            {
                this.ValidateTag(TokenDeltasItem.DeltaInfoTag.Add);
                return (TokenAmount)this.Value!;
            }

            public TokenAmount AsAmount()
            {
                this.ValidateTag(TokenDeltasItem.DeltaInfoTag.Amount);
                return (TokenAmount)this.Value!;
            }

            public bool AsBool()
            {
                this.ValidateTag(TokenDeltasItem.DeltaInfoTag.Bool);
                return (bool)this.Value!;
            }

            public TokenAmount AsSub()
            {
                this.ValidateTag(TokenDeltasItem.DeltaInfoTag.Sub);
                return (TokenAmount)this.Value!;
            }

            public string AsText()
            {
                this.ValidateTag(TokenDeltasItem.DeltaInfoTag.Text);
                return (string)this.Value!;
            }

            private void ValidateTag(TokenDeltasItem.DeltaInfoTag tag)
            {
                if (!this.Tag.Equals(tag))
                {
                    throw new InvalidOperationException($"Cannot cast '{this.Tag}' to type '{tag}'");
                }
            }
        }

        public enum DeltaInfoTag
        {
            [CandidName("add")]
            Add,
            [CandidName("amount")]
            Amount,
            [CandidName("bool")]
            Bool,
            [CandidName("sub")]
            Sub,
            [CandidName("text")]
            Text
        }
    }
}