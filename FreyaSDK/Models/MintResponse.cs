using EdjCase.ICP.Candid.Mapping;

namespace FreyaSDK.Models
{
    [Variant]
    public class MintResponse
    {
        [VariantTagProperty]
        public MintResponseTag Tag { get; set; }

        [VariantValueProperty]
        public object? Value { get; set; }

        public MintResponse(MintResponseTag tag, object? value)
        {
            this.Tag = tag;
            this.Value = value;
        }

        protected MintResponse()
        {
        }

        public static MintResponse Err(string info)
        {
            return new MintResponse(MintResponseTag.Err, info);
        }

        public static MintResponse Ok()
        {
            return new MintResponse(MintResponseTag.Ok, null);
        }

        public string AsErr()
        {
            this.ValidateTag(MintResponseTag.Err);
            return (string)this.Value!;
        }

        private void ValidateTag(MintResponseTag tag)
        {
            if (!this.Tag.Equals(tag))
            {
                throw new InvalidOperationException($"Cannot cast '{this.Tag}' to type '{tag}'");
            }
        }
    }

    public enum MintResponseTag
    {
        [CandidName("err")]
        Err,
        [CandidName("ok")]
        Ok
    }
}