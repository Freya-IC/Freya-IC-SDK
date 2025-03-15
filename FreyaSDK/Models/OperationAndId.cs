#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;
using EdjCase.ICP.Candid.Models;

namespace FreyaSDK.Models
{
    public class OperationAndId
    {
        [CandidName("id")]
        public UnboundedUInt Id { get; set; }

        [CandidName("operation")]
        public Operation Operation { get; set; }

        public OperationAndId(UnboundedUInt id, Operation operation)
        {
            this.Id = id;
            this.Operation = operation;
        }

        public OperationAndId()
        {
        }
    }
}