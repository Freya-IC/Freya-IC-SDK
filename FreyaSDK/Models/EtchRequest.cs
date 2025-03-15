#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;
using TokenID = System.String;

namespace FreyaSDK.Models
{
    public class EtchRequest
    {
        [CandidName("icrc_ledger")]
        public string IcrcLedger { get; set; }

        [CandidName("rune")]
        public string Rune { get; set; }

        [CandidName("rune_id")]
        public string RuneId { get; set; }

        [CandidName("tokenid")]
        public TokenID Tokenid { get; set; }

        public EtchRequest(string icrcLedger, string rune, string runeId, TokenID tokenid)
        {
            this.IcrcLedger = icrcLedger;
            this.Rune = rune;
            this.RuneId = runeId;
            this.Tokenid = tokenid;
        }

        public EtchRequest()
        {
        }
    }
}