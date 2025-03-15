#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;
using EdjCase.ICP.Candid.Models;

namespace FreyaSDK.Models
{
    public class ExternalMintRequest
    {
        [CandidName("amount")]
        public ulong Amount { get; set; }

        [CandidName("txid")]
        public string Txid { get; set; }

        [CandidName("user")]
        public Principal User { get; set; }

        public ExternalMintRequest(ulong amount, string txid, Principal user)
        {
            this.Amount = amount;
            this.Txid = txid;
            this.User = user;
        }

        public ExternalMintRequest()
        {
        }
    }
}