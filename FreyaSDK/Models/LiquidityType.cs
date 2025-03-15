using EdjCase.ICP.Candid.Mapping;

namespace FreyaSDK.Models
{
    public enum LiquidityType
    {
        [CandidName("add")]
        Add,
        [CandidName("remove")]
        Remove
    }
}