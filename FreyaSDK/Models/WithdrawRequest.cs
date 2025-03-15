#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;
using TokenAmount = EdjCase.ICP.Candid.Models.UnboundedUInt;
using TokenID = System.String;

namespace FreyaSDK.Models
{
    public class WithdrawRequest
    {
        [CandidName("address")]
        public string Address { get; set; }

        [CandidName("amount")]
        public TokenAmount Amount { get; set; }

        [CandidName("protocol")]
        public WithdrawProtocol Protocol { get; set; }

        [CandidName("tokenid")]
        public TokenID Tokenid { get; set; }

        public WithdrawRequest(string address, TokenAmount amount, WithdrawProtocol protocol, TokenID tokenid)
        {
            this.Address = address;
            this.Amount = amount;
            this.Protocol = protocol;
            this.Tokenid = tokenid;
        }

        public WithdrawRequest()
        {
        }
    }
}