#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Candid.Mapping;

namespace FreyaSDK.Models
{
    public class Rune
    {
        [CandidName("id")]
        public string Id { get; set; }

        [CandidName("name")]
        public string Name { get; set; }

        [CandidName("ticker")]
        public string Ticker { get; set; }

        public Rune(string id, string name, string ticker)
        {
            this.Id = id;
            this.Name = name;
            this.Ticker = ticker;
        }

        public Rune()
        {
        }
    }
}