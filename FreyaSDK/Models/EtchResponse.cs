using EdjCase.ICP.Candid.Mapping;

namespace FreyaSDK.Models
{
    [Variant]
    public class EtchResponse
    {
        [VariantTagProperty]
        public EtchResponseTag Tag { get; set; }

        [VariantValueProperty]
        public object? Value { get; set; }

        public EtchResponse(EtchResponseTag tag, object? value)
        {
            this.Tag = tag;
            this.Value = value;
        }

        protected EtchResponse()
        {
        }

        public static EtchResponse Err(string info)
        {
            return new EtchResponse(EtchResponseTag.Err, info);
        }

        public static EtchResponse Ok()
        {
            return new EtchResponse(EtchResponseTag.Ok, null);
        }

        public string AsErr()
        {
            this.ValidateTag(EtchResponseTag.Err);
            return (string)this.Value!;
        }

        private void ValidateTag(EtchResponseTag tag)
        {
            if (!this.Tag.Equals(tag))
            {
                throw new InvalidOperationException($"Cannot cast '{this.Tag}' to type '{tag}'");
            }
        }
    }

    public enum EtchResponseTag
    {
        [CandidName("err")]
        Err,
        [CandidName("ok")]
        Ok
    }
}