#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;

namespace FreyaSDK.Models
{
    public class BondingCurveSettings
    {
        [CandidName("a")]
        public double A { get; set; }

        [CandidName("b")]
        public double B { get; set; }

        [CandidName("c")]
        public double C { get; set; }

        [CandidName("name")]
        public string Name { get; set; }

        public BondingCurveSettings(double a, double b, double c, string name)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.Name = name;
        }

        public BondingCurveSettings()
        {
        }
    }
}