using EdjCase.ICP.Candid.Mapping;
using EdjCase.ICP.Candid.Models;

namespace FreyaSDK.Models
{
    [Variant]
    public class MetadataRecord
    {
        [VariantTagProperty]
        public MetadataRecordTag Tag { get; set; }

        [VariantValueProperty]
        public object? Value { get; set; }

        public MetadataRecord(MetadataRecordTag tag, object? value)
        {
            this.Tag = tag;
            this.Value = value;
        }

        protected MetadataRecord()
        {
        }

        public static MetadataRecord Blob(List<byte> info)
        {
            return new MetadataRecord(MetadataRecordTag.Blob, info);
        }

        public static MetadataRecord Bool(bool info)
        {
            return new MetadataRecord(MetadataRecordTag.Bool, info);
        }

        public static MetadataRecord Hex(string info)
        {
            return new MetadataRecord(MetadataRecordTag.Hex, info);
        }

        public static MetadataRecord Int(UnboundedInt info)
        {
            return new MetadataRecord(MetadataRecordTag.Int, info);
        }

        public static MetadataRecord Nat(UnboundedUInt info)
        {
            return new MetadataRecord(MetadataRecordTag.Nat, info);
        }

        public static MetadataRecord Nat8(byte info)
        {
            return new MetadataRecord(MetadataRecordTag.Nat8, info);
        }

        public static MetadataRecord Principal(Principal info)
        {
            return new MetadataRecord(MetadataRecordTag.Principal, info);
        }

        public static MetadataRecord Text(string info)
        {
            return new MetadataRecord(MetadataRecordTag.Text, info);
        }

        public List<byte> AsBlob()
        {
            this.ValidateTag(MetadataRecordTag.Blob);
            return (List<byte>)this.Value!;
        }

        public bool AsBool()
        {
            this.ValidateTag(MetadataRecordTag.Bool);
            return (bool)this.Value!;
        }

        public string AsHex()
        {
            this.ValidateTag(MetadataRecordTag.Hex);
            return (string)this.Value!;
        }

        public UnboundedInt AsInt()
        {
            this.ValidateTag(MetadataRecordTag.Int);
            return (UnboundedInt)this.Value!;
        }

        public UnboundedUInt AsNat()
        {
            this.ValidateTag(MetadataRecordTag.Nat);
            return (UnboundedUInt)this.Value!;
        }

        public byte AsNat8()
        {
            this.ValidateTag(MetadataRecordTag.Nat8);
            return (byte)this.Value!;
        }

        public Principal AsPrincipal()
        {
            this.ValidateTag(MetadataRecordTag.Principal);
            return (Principal)this.Value!;
        }

        public string AsText()
        {
            this.ValidateTag(MetadataRecordTag.Text);
            return (string)this.Value!;
        }

        private void ValidateTag(MetadataRecordTag tag)
        {
            if (!this.Tag.Equals(tag))
            {
                throw new InvalidOperationException($"Cannot cast '{this.Tag}' to type '{tag}'");
            }
        }
    }

    public enum MetadataRecordTag
    {
        [CandidName("blob")]
        Blob,
        [CandidName("bool")]
        Bool,
        [CandidName("hex")]
        Hex,
        [CandidName("int")]
        Int,
        [CandidName("nat")]
        Nat,
        [CandidName("nat8")]
        Nat8,
        [CandidName("principal")]
        Principal,
        [CandidName("text")]
        Text
    }
}