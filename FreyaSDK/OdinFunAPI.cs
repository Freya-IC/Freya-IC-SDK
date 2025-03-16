using EdjCase.ICP.Agent.Identities;
using FreyaSDK.Models.json;
using Newtonsoft.Json;
using System.Text;

namespace FreyaSDK
{
    public static class OdinFunAPI
    {
        /// <summary>
        /// One-time account registration for Odin.fun - Used to initialize new identities in the odin.fun system
        /// </summary>
        /// <param name="identity"></param>
        /// <returns></returns>
        public static async Task<string> AuthIdentity(Ed25519Identity identity)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    DateTimeOffset now = DateTimeOffset.UtcNow;
                    long unixTimestamp = now.ToUnixTimeMilliseconds();
                    string _timestamp = unixTimestamp.ToString();
                    AuthRequest auth = new AuthRequest()
                    {
                        publickey = Convert.ToBase64String(identity.GetPublicKey().ToDerEncoding()),
                        timestamp = _timestamp,
                        signature = Convert.ToBase64String(identity.Sign(Encoding.UTF8.GetBytes(_timestamp))),
                        referrer = ""
                    };

                    string jsonData = JsonConvert.SerializeObject(auth);
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("https://api.odin.fun/v1/auth", content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("Response received: " + responseBody);
                        return responseBody;
                    }
                    else
                    {
                        string errorBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Error: {response.StatusCode}, Body: {errorBody}");
                        return "ERROR";
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred: " + ex.Message);
                    return "ERROR";
                }
            }
        }
    }
}
