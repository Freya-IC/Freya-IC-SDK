using EdjCase.ICP.Agent.Identities;
using FreyaSDK.Models;
using FreyaSDK.Models.json;
using Newtonsoft.Json;
using System.Text;

namespace FreyaSDK
{
    public static class OdinFunAPI
    {
        /// <summary>
        /// Auth token & identity registration request
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

        /// <summary>
        /// Change your username using Auth token
        /// </summary>
        /// <param name="identity"></param>
        /// <returns></returns>
        public static async Task<string> ChangeUsername(string username, string principal_id, string auth_token)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var boundary = "----WebKitFormBoundaryjW7X11NmhWkQGgWH";
                    var body = new StringBuilder();
                    body.AppendLine($"--{boundary}");
                    body.AppendLine("Content-Disposition: form-data; name=\"username\"");
                    body.AppendLine();
                    body.AppendLine(username);
                    body.AppendLine($"--{boundary}--"); // Final boundary
                    var content = new StringContent(body.ToString(), Encoding.UTF8);
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", auth_token);
                    content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("multipart/form-data")
                    {
                        Parameters = { new System.Net.Http.Headers.NameValueHeaderValue("boundary", boundary) }
                    };
                    HttpResponseMessage response = await client.PostAsync("https://api.odin.fun/v1/user/profile?user=" + principal_id, content);

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
        /// <summary>
        /// Get recently traded Odin.fun tokens
        /// </summary>
        /// <returns></returns>
        public static async Task<OdinFunTokens?> GetOdinFunTokens()
        {
            string url = "https://api.odin.fun/v1/tokens?sort=last_action_time%3Adesc&page=1&limit=100";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                OdinFunTokens? odinFunTokens = JsonConvert.DeserializeObject<OdinFunTokens>(responseBody);
                if (odinFunTokens != null)
                {
                    return odinFunTokens;
                }
                else
                {
                    return null;
                }
            }

        }

        /// <summary>
        /// Get recently traded Odin.fun tokens
        /// </summary>
        /// <returns></returns>
        public static async Task<Holders?> GetHolders(string id)
        {
            string url = "https://api.odin.fun/v1/token/" + id + "/owners?page=1&limit=10";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Holders? holders = JsonConvert.DeserializeObject<Holders>(responseBody);
                if (holders != null)
                {
                    return holders;
                }
                else
                {
                    return null;
                }
            }

        }
        /// <summary>
        /// Get recently traded Odin.fun tokens
        /// </summary>
        /// <returns></returns>
        public static async Task<TokenData?> GetOdinFunToken(string id)
        {
            string url = "https://api.odin.fun/v1/token/" + id;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                TokenData? odinFunToken = JsonConvert.DeserializeObject<TokenData>(responseBody);
                if (odinFunToken != null)
                {
                    return odinFunToken;
                }
                else
                {
                    return null;
                }
            }

        }
        /// <summary>
        /// Get Odin.fun user
        /// </summary>
        /// <returns></returns>
        public static async Task<OdinUser?> GetOdinFunUser(string principal_id)
        {
            string url = "https://api.odin.fun/v1/user/" + principal_id;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                OdinUser? odinFunUser = JsonConvert.DeserializeObject<OdinUser>(responseBody);
                if (odinFunUser != null)
                {
                    return odinFunUser;
                }
                else
                {
                    return null;
                }
            }

        }
        /// <summary>
        /// Get Odin.fun user
        /// </summary>
        /// <returns></returns>
        public static async Task<UserBalances?> GetUserBalances(string principal_id)
        {
            string url = "https://api.odin.fun/v1/user/" + principal_id + "/balances";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                UserBalances? balances = JsonConvert.DeserializeObject<UserBalances>(responseBody);
                if (balances != null)
                {
                    return balances;
                }
                else
                {
                    return null;
                }
            }

        }
        /// <summary>
        /// Get Odin.fun user
        /// </summary>
        /// <returns></returns>
        public static async Task<UserBalance?> GetUserTokenBalance(string principal_id, string token_id)
        {
            string url = "https://api.odin.fun/v1/user/" + principal_id + "/balances";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                UserBalances? balances = JsonConvert.DeserializeObject<UserBalances>(responseBody);
                if (balances != null)
                {
                    foreach (var userbalance in balances.data)
                    {
                        if (userbalance.id == token_id)
                        {
                            return userbalance;
                        }
                    }
                    return null;
                }
                else
                {
                    return null;
                }
            }

        }
        /// <summary>
        /// Retrieve Odin.fun trades for a specific token
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static async Task<TokenTrades?> GetOdinFunTrades(TokenTarget target)
        {
            string url = "https://api.odin.fun/v1/token/" + target.Id + "/trades?page=1&limit=9999&time_min=" + target.LastActionTimestamp;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                TokenTrades? tokenTrades = JsonConvert.DeserializeObject<TokenTrades>(responseBody);
                if (tokenTrades != null)
                {
                    return tokenTrades;
                }
                else
                {
                    return null;
                }
            }

        }
    }
}
