#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;

namespace FreyaSDK.Models
{
    public class LiquidityPool
    {
        [CandidName("current")]
        public LiquiditySwap Current { get; set; }

        [CandidName("locked")]
        public LiquiditySwap Locked { get; set; }

        public LiquidityPool(LiquiditySwap current, LiquiditySwap locked)
        {
            this.Current = current;
            this.Locked = locked;
        }

        public LiquidityPool()
        {
        }
    }
}