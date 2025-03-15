#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;
using TokenAmount = EdjCase.ICP.Candid.Models.UnboundedUInt;
using TokenDeltas = System.Collections.Generic.List<FreyaSDK.Models.TokenDeltasItem>;
using TokenID = System.String;

namespace FreyaSDK.Models
{
    [Variant]
    public class OperationType
    {
        [VariantTagProperty]
        public OperationTypeTag Tag { get; set; }

        [VariantValueProperty]
        public object? Value { get; set; }

        public OperationType(OperationTypeTag tag, object? value)
        {
            this.Tag = tag;
            this.Value = value;
        }

        protected OperationType()
        {
        }

        public static OperationType Access(OperationType.AccessInfo info)
        {
            return new OperationType(OperationTypeTag.Access, info);
        }

        public static OperationType Mint(OperationType.MintInfo info)
        {
            return new OperationType(OperationTypeTag.Mint, info);
        }

        public static OperationType Other(OperationType.OtherInfo info)
        {
            return new OperationType(OperationTypeTag.Other, info);
        }

        public static OperationType Token(OperationType.TokenInfo info)
        {
            return new OperationType(OperationTypeTag.Token, info);
        }

        public static OperationType Trade(OperationType.TradeInfo info)
        {
            return new OperationType(OperationTypeTag.Trade, info);
        }

        public static OperationType Transaction(OperationType.TransactionInfo info)
        {
            return new OperationType(OperationTypeTag.Transaction, info);
        }

        public OperationType.AccessInfo AsAccess()
        {
            this.ValidateTag(OperationTypeTag.Access);
            return (OperationType.AccessInfo)this.Value!;
        }

        public OperationType.MintInfo AsMint()
        {
            this.ValidateTag(OperationTypeTag.Mint);
            return (OperationType.MintInfo)this.Value!;
        }

        public OperationType.OtherInfo AsOther()
        {
            this.ValidateTag(OperationTypeTag.Other);
            return (OperationType.OtherInfo)this.Value!;
        }

        public OperationType.TokenInfo AsToken()
        {
            this.ValidateTag(OperationTypeTag.Token);
            return (OperationType.TokenInfo)this.Value!;
        }

        public OperationType.TradeInfo AsTrade()
        {
            this.ValidateTag(OperationTypeTag.Trade);
            return (OperationType.TradeInfo)this.Value!;
        }

        public OperationType.TransactionInfo AsTransaction()
        {
            this.ValidateTag(OperationTypeTag.Transaction);
            return (OperationType.TransactionInfo)this.Value!;
        }

        private void ValidateTag(OperationTypeTag tag)
        {
            if (!this.Tag.Equals(tag))
            {
                throw new InvalidOperationException($"Cannot cast '{this.Tag}' to type '{tag}'");
            }
        }

        public class AccessInfo
        {
            [CandidName("user")]
            public string User { get; set; }

            public AccessInfo(string user)
            {
                this.User = user;
            }

            public AccessInfo()
            {
            }
        }

        public class MintInfo
        {
            [CandidName("data")]
            public Metadata Data { get; set; }

            [CandidName("tokenid")]
            public TokenID Tokenid { get; set; }

            public MintInfo(Metadata data, TokenID tokenid)
            {
                this.Data = data;
                this.Tokenid = tokenid;
            }

            public MintInfo()
            {
            }
        }

        public class OtherInfo
        {
            [CandidName("data")]
            public Metadata Data { get; set; }

            [CandidName("name")]
            public string Name { get; set; }

            public OtherInfo(Metadata data, string name)
            {
                this.Data = data;
                this.Name = name;
            }

            public OtherInfo()
            {
            }
        }

        public class TokenInfo
        {
            [CandidName("deltas")]
            public TokenDeltas Deltas { get; set; }

            [CandidName("tokenid")]
            public TokenID Tokenid { get; set; }

            public TokenInfo(TokenDeltas deltas, TokenID tokenid)
            {
                this.Deltas = deltas;
                this.Tokenid = tokenid;
            }

            public TokenInfo()

            {
            }
        }

        public class TradeInfo
        {
            [CandidName("amount_btc")]
            public TokenAmount AmountBtc { get; set; }

            [CandidName("amount_token")]
            public TokenAmount AmountToken { get; set; }

            [CandidName("bonded")]
            public bool Bonded { get; set; }

            [CandidName("price")]
            public TokenAmount Price { get; set; }

            [CandidName("tokenid")]
            public TokenID Tokenid { get; set; }

            [CandidName("typeof")]
            public TradeType Typeof { get; set; }

            [CandidName("user")]
            public string User { get; set; }

            public TradeInfo(TokenAmount amountBtc, TokenAmount amountToken, bool bonded, TokenAmount price, TokenID tokenid, TradeType @typeof, string user)
            {
                this.AmountBtc = amountBtc;
                this.AmountToken = amountToken;
                this.Bonded = bonded;
                this.Price = price;
                this.Tokenid = tokenid;
                this.Typeof = @typeof;
                this.User = user;
            }

            public TradeInfo()
            {
            }
        }

        public class TransactionInfo
        {
            [CandidName("amount")]
            public TokenAmount Amount { get; set; }

            [CandidName("balance")]
            public TokenAmount Balance { get; set; }

            [CandidName("description")]
            public string Description { get; set; }

            [CandidName("metadata")]
            public Metadata Metadata { get; set; }

            [CandidName("tokenid")]
            public TokenID Tokenid { get; set; }

            [CandidName("typeof")]
            public OperationType.TransactionInfo.TypeofInfo Typeof { get; set; }

            [CandidName("user")]
            public string User { get; set; }

            public TransactionInfo(TokenAmount amount, TokenAmount balance, string description, Metadata metadata, TokenID tokenid, OperationType.TransactionInfo.TypeofInfo @typeof, string user)
            {
                this.Amount = amount;
                this.Balance = balance;
                this.Description = description;
                this.Metadata = metadata;
                this.Tokenid = tokenid;
                this.Typeof = @typeof;
                this.User = user;
            }

            public TransactionInfo()
            {
            }

            public enum TypeofInfo
            {
                [CandidName("add")]
                Add,
                [CandidName("sub")]
                Sub
            }
        }
    }

    public enum OperationTypeTag
    {
        [CandidName("access")]
        Access,
        [CandidName("mint")]
        Mint,
        [CandidName("other")]
        Other,
        [CandidName("token")]
        Token,
        [CandidName("trade")]
        Trade,
        [CandidName("transaction")]
        Transaction
    }
}