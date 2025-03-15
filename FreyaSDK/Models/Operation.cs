#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;
using Time = EdjCase.ICP.Candid.Models.UnboundedInt;

namespace FreyaSDK.Models
{
    public class Operation
    {
        [CandidName("time")]
        public Time Time { get; set; }

        [CandidName("typeof")]
        public OperationType Typeof { get; set; }

        public Operation(Time time, OperationType @typeof)
        {
            this.Time = time;
            this.Typeof = @typeof;
        }

        public Operation()
        {
        }
    }
}