#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

namespace FreyaSDK.Models.json
{
    public class AuthRequest
    {
        public string publickey { get; set; }
        public string timestamp { get; set; }

        public string signature { get; set; }

        public string referrer { get; set; }
    }
}
