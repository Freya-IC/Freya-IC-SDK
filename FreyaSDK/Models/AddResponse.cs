using EdjCase.ICP.Candid.Mapping;

namespace FreyaSDK.Models
{
    [Variant]
    public class AddResponse
    {
        [VariantTagProperty]
        public AddResponseTag Tag { get; set; }

        [VariantValueProperty]
        public object? Value { get; set; }

        public AddResponse(AddResponseTag tag, object? value)
        {
            this.Tag = tag;
            this.Value = value;
        }

        protected AddResponse()
        {
        }

        public static AddResponse Err(string info)
        {
            return new AddResponse(AddResponseTag.Err, info);
        }

        public static AddResponse Ok()
        {
            return new AddResponse(AddResponseTag.Ok, null);
        }

        public string AsErr()
        {
            this.ValidateTag(AddResponseTag.Err);
            return (string)this.Value!;
        }

        private void ValidateTag(AddResponseTag tag)
        {
            if (!this.Tag.Equals(tag))
            {
                throw new InvalidOperationException($"Cannot cast '{this.Tag}' to type '{tag}'");
            }
        }
    }

    public enum AddResponseTag
    {
        [CandidName("err")]
        Err,
        [CandidName("ok")]
        Ok
    }
}