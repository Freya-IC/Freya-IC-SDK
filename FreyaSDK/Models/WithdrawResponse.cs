using EdjCase.ICP.Candid.Mapping;

namespace FreyaSDK.Models
{
    [Variant]
    public class WithdrawResponse
    {
        [VariantTagProperty]
        public WithdrawResponseTag Tag { get; set; }

        [VariantValueProperty]
        public object? Value { get; set; }

        public WithdrawResponse(WithdrawResponseTag tag, object? value)
        {
            this.Tag = tag;
            this.Value = value;
        }

        protected WithdrawResponse()
        {
        }

        public static WithdrawResponse Err(string info)
        {
            return new WithdrawResponse(WithdrawResponseTag.Err, info);
        }

        public static WithdrawResponse Ok(bool info)
        {
            return new WithdrawResponse(WithdrawResponseTag.Ok, info);
        }

        public string AsErr()
        {
            this.ValidateTag(WithdrawResponseTag.Err);
            return (string)this.Value!;
        }

        public bool AsOk()
        {
            this.ValidateTag(WithdrawResponseTag.Ok);
            return (bool)this.Value!;
        }

        private void ValidateTag(WithdrawResponseTag tag)
        {
            if (!this.Tag.Equals(tag))
            {
                throw new InvalidOperationException($"Cannot cast '{this.Tag}' to type '{tag}'");
            }
        }
    }

    public enum WithdrawResponseTag
    {
        [CandidName("err")]
        Err,
        [CandidName("ok")]
        Ok
    }
}