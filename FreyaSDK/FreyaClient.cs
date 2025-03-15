#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using EdjCase.ICP.Agent.Agents;
using EdjCase.ICP.Agent.Responses;
using EdjCase.ICP.Candid;
using EdjCase.ICP.Candid.Mapping;
using EdjCase.ICP.Candid.Models;
using FreyaSDK.Models;
using Newtonsoft.Json;
using TokenAmount = EdjCase.ICP.Candid.Models.UnboundedUInt;
using TokenID = System.String;

namespace FreyaSDK
{
    public class FreyaClient
    {
        public IAgent Agent { get; }
        public Principal CanisterId { get; }
        public CandidConverter? Converter { get; }

        public FreyaClient(IAgent agent, Principal canisterId, CandidConverter? converter = default)
        {
            this.Agent = agent;
            this.CanisterId = canisterId;
            this.Converter = converter;
        }

        public async Task<TokenAmount> GetBalance(string arg0, string arg1, TokenID arg2)
        {
            CandidArg arg = CandidArg.FromCandid(CandidTypedValue.FromObject(arg0, this.Converter), CandidTypedValue.FromObject(arg1, this.Converter), CandidTypedValue.FromObject(arg2, this.Converter));
            QueryResponse response = await this.Agent.QueryAsync(this.CanisterId, "getBalance", arg);
            CandidArg reply = response.ThrowOrGetReply();
            return reply.ToObjects<TokenAmount>(this.Converter);
        }

        public async Task<GetLockedTokensReturnArg0> GetLockedTokens(string arg0)
        {
            CandidArg arg = CandidArg.FromCandid(CandidTypedValue.FromObject(arg0, this.Converter));
            QueryResponse response = await this.Agent.QueryAsync(this.CanisterId, "getLockedTokens", arg);
            CandidArg reply = response.ThrowOrGetReply();
            return reply.ToObjects<GetLockedTokensReturnArg0>(this.Converter);
        }

        public async Task<OptionalValue<Operation>> GetOperation(string arg0, TokenAmount arg1)
        {
            CandidArg arg = CandidArg.FromCandid(CandidTypedValue.FromObject(arg0, this.Converter), CandidTypedValue.FromObject(arg1, this.Converter));
            QueryResponse response = await this.Agent.QueryAsync(this.CanisterId, "getOperation", arg);
            CandidArg reply = response.ThrowOrGetReply();
            return reply.ToObjects<OptionalValue<Operation>>(this.Converter);
        }

        public async Task<List<OperationAndId>> GetOperations(TokenAmount arg0, TokenAmount arg1)
        {
            CandidArg arg = CandidArg.FromCandid(CandidTypedValue.FromObject(arg0, this.Converter), CandidTypedValue.FromObject(arg1, this.Converter));
            QueryResponse response = await this.Agent.QueryAsync(this.CanisterId, "getOperations", arg);
            CandidArg reply = response.ThrowOrGetReply();
            return reply.ToObjects<List<OperationAndId>>(this.Converter);
        }

        public async Task<Dictionary<string, string>> GetStats(string arg0)
        {
            CandidArg arg = CandidArg.FromCandid(CandidTypedValue.FromObject(arg0, this.Converter));
            QueryResponse response = await this.Agent.QueryAsync(this.CanisterId, "getStats", arg);
            CandidArg reply = response.ThrowOrGetReply();
            return reply.ToObjects<Dictionary<string, string>>(this.Converter);
        }

        public async Task<OptionalValue<Token>> GetToken(string arg0, TokenID tokenID)
        {
            CandidArg arg = CandidArg.FromCandid(CandidTypedValue.FromObject(arg0, this.Converter), CandidTypedValue.FromObject(tokenID, this.Converter));
            QueryResponse response = await this.Agent.QueryAsync(this.CanisterId, "getToken", arg);
            CandidArg reply = response.ThrowOrGetReply();
            return reply.ToObjects<OptionalValue<Token>>(this.Converter);
        }

        public async Task<TokenAmount> GetTokenIndex(TokenID tokenID)
        {
            CandidArg arg = CandidArg.FromCandid(CandidTypedValue.FromObject(tokenID, this.Converter));
            QueryResponse response = await this.Agent.QueryAsync(this.CanisterId, "getTokenIndex", arg);
            CandidArg reply = response.ThrowOrGetReply();
            return reply.ToObjects<TokenAmount>(this.Converter);
        }

        public async Task<AddResponse> TokenAdd(AddRequest arg0)
        {
            CandidArg arg = CandidArg.FromCandid(CandidTypedValue.FromObject(arg0, this.Converter));
            CandidArg reply = await this.Agent.CallAsync(this.CanisterId, "token_add", arg);
            return reply.ToObjects<AddResponse>(this.Converter);
        }

        public async Task<TokenAmount> TokenDeposit(TokenID tokenID, TokenAmount tokenAmount)
        {
            CandidArg arg = CandidArg.FromCandid(CandidTypedValue.FromObject(tokenID, this.Converter), CandidTypedValue.FromObject(tokenAmount, this.Converter));
            CandidArg reply = await this.Agent.CallAsync(this.CanisterId, "token_deposit", arg);
            return reply.ToObjects<TokenAmount>(this.Converter);
        }

        public async Task<EtchResponse> TokenEtch(EtchRequest arg0)
        {
            CandidArg arg = CandidArg.FromCandid(CandidTypedValue.FromObject(arg0, this.Converter));
            CandidArg reply = await this.Agent.CallAsync(this.CanisterId, "token_etch", arg);
            return reply.ToObjects<EtchResponse>(this.Converter);
        }

        public async Task<LiquidityResponse> TokenLiquidity(LiquidityRequest arg0)
        {
            CandidArg arg = CandidArg.FromCandid(CandidTypedValue.FromObject(arg0, this.Converter));
            CandidArg reply = await this.Agent.CallAsync(this.CanisterId, "token_liquidity", arg);
            return reply.ToObjects<LiquidityResponse>(this.Converter);
        }

        public async Task<MintResponse> TokenMint(MintRequest mintrequest)
        {
            CandidArg arg = CandidArg.FromCandid(CandidTypedValue.FromObject(mintrequest, this.Converter));
            CandidArg reply = await this.Agent.CallAsync(this.CanisterId, "token_mint", arg);
            return reply.ToObjects<MintResponse>(this.Converter);
        }

        public async Task<TradeResponse> TokenTrade(TradeRequest tradeRequest)
        {
            CandidArg arg = CandidArg.FromCandid(CandidTypedValue.FromObject(tradeRequest, this.Converter));
            CandidArg reply = await this.Agent.CallAsync(this.CanisterId, "token_trade", arg);
            return reply.ToObjects<TradeResponse>(this.Converter);
        }

        public async Task<WithdrawResponse> TokenWithdraw(WithdrawRequest withdrawRequest)
        {
            CandidArg arg = CandidArg.FromCandid(CandidTypedValue.FromObject(withdrawRequest, this.Converter));
            CandidArg reply = await this.Agent.CallAsync(this.CanisterId, "token_withdraw", arg);
            return reply.ToObjects<WithdrawResponse>(this.Converter);
        }
        public static decimal ConvertToBTC(long satoshis)
        {
            return Decimal.Round((decimal)satoshis / (decimal)1000, 3);
        }
        public static decimal ConvertToTokenAmount(long satoshis)
        {
            return Decimal.Round((decimal)satoshis / (decimal)100000000000, 0);
        }
        static decimal CalculatePercentDifference(decimal a, decimal b)
        {
            // Formula: |A - B| / ((A + B) / 2) * 100
            decimal difference = Math.Abs(a - b);
            decimal average = (a + b) / 2;
            return (difference / average) * 100;
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
        public static async Task<BTCPriceResponse?> GetBTCprice()
        {
            string url = "https://pepodins.com/api/getBTCPrice";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                BTCPriceResponse? priceCheck = JsonConvert.DeserializeObject<BTCPriceResponse>(responseBody);
                if (priceCheck != null)
                {
                    return priceCheck;
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
        public static async Task<BundleCheck?> CheckBundleStatus(string id)
        {
            string url = "https://pepodins.com/api/getSecurity?tokenid=" + id;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                BundleCheck? bundleCheck = JsonConvert.DeserializeObject<BundleCheck>(responseBody);
                if (bundleCheck != null)
                {
                    return bundleCheck;
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
        public class GetLockedTokensReturnArg0
        {
            [CandidName("liquidity")]
            public LiquidityInfo Liquidity { get; set; }

            [CandidName("trade")]
            public TradeInfo Trade { get; set; }

            [CandidName("withdraw")]
            public WithdrawInfo Withdraw { get; set; }

            public GetLockedTokensReturnArg0(LiquidityInfo liquidity, TradeInfo trade, WithdrawInfo withdraw)
            {
                this.Liquidity = liquidity;
                this.Trade = trade;
                this.Withdraw = withdraw;
            }

            public GetLockedTokensReturnArg0()
            {

            }
        }
        public class LiquidityInfo : List<TokenID>
        {
            public LiquidityInfo()
            {
            }
        }

        public class TradeInfo : List<TokenID>
        {
            public TradeInfo()
            {
            }
        }

        public class WithdrawInfo : List<TokenID>
        {
            public WithdrawInfo()
            {
            }
        }
    }
}
