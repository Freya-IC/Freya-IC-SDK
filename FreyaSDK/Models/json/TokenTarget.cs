namespace FreyaSDK.Models
{
    public class TokenTarget
    {
        /// <summary>
        /// Token Address - Unique per entry
        /// </summary>
        public required string Id { get; set; }

        /// <summary>
        /// global last action timestamp
        /// </summary>
        public required string LastActionTimestamp { get; set; }

        /// <summary>
        /// active subscribers by channel id
        /// </summary>
        public required string[] ActiveSubscribers { get; set; }

        /// <summary>
        /// All recorded and broadcasted trades
        /// </summary>
        public required string[] RecordedTrades { get; set; }
    }
}
