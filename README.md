# Freya-IC-SDK
 Freya IC SDK is a C# client & toolkit for building apps or trading AI for Odin.fun


```
using EdjCase.ICP.Agent.Agents;
using EdjCase.ICP.Agent.Identities;
using EdjCase.ICP.Candid.Models;
using FreyaSDK.Models;
using FreyaSDK;

var identity = IdentityUtil.GenerateEd25519Identity();
var agent = new HttpAgent(httpBoundryNodeUrl: new Uri("https://icp0.io")) { Identity = identity };
Principal canisterId = Principal.FromText("z2vm5-gaaaa-aaaaj-azw6q-cai");
var freya = new FreyaClient(agent, canisterId);

//one time authorization for account creation
string response = await OdinFunAPI.AuthIdentity(identity);
//Deposit to your btc deposit address then continue here
var request = new TradeRequest { Tokenid = "27uj", Amount = TradeAmount.Btc(10000000), Typeof = TradeType.Buy };
var trade = await freya.TokenTrade(request);

```
