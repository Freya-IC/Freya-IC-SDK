# Freya-IC SDK
 Freya IC SDK is a C# client & toolkit for building apps or trading AI for Odin.fun

### Getting Started
Add Edjcase.ICP.Agent nuget package to your project & compile the freya-ic source code into a DLL then import it as a project reference.
```
using EdjCase.ICP.Agent.Agents;
using EdjCase.ICP.Agent.Identities;
using EdjCase.ICP.Candid.Models;
using FreyaSDK.Models;
using FreyaSDK;
```

#### ICP Identity 
Create a new ICP Ed25519 Identity and save the private key to import later on
```
Ed25519Identity? identity = IdentityUtil.GenerateEd25519Identity();

Console.WriteLine("Publickey: " + Convert.ToBase64String(identity.GetPublicKey().ToDerEncoding()));
Console.WriteLine("Privatekey: " + Convert.ToBase64String(identity.PrivateKey));
Console.WriteLine("ICP Identity Principal: "+ identity.GetPublicKey().ToPrincipal().ToString());
```

#### [*Required*] Authorizing new identity on Odin.fun system 
Each new identity needs to register with odin.fun system to begin trading
```
//one time authorization for account creation
string auth_response = await OdinFunAPI.AuthIdentity(identity);
```

#### Interacting with Odin.fun canister
Call the trade method on the odin.fun canister through the Freya client or initiate a withdrawal
```
HttpAgent agent = new HttpAgent(httpBoundryNodeUrl: new Uri("https://icp0.io")) { Identity = identity };
FreyaClient freya = new FreyaClient(agent);

TradeRequest? trade_request = new TradeRequest { Tokenid = "2awv", Amount = TradeAmount.Btc(10000000), Typeof = TradeType.Buy };
TradeResponse? trade = await freya.TokenTrade(trade_request);

WithdrawRequest? withdrawal_request = new WithdrawRequest { Address = "BTC_ADDRESS", Protocol = WithdrawProtocol.Btc, Amount = TokenAmount.FromBigInteger(100000), Tokenid = "TOKEN ID" };
WithdrawResponse? withdrawal = await freya.TokenWithdraw(withdrawal_request);

```

#### Interacting with Odin.fun API
Call the odin.fun API to pull user, token or trade data in real-time

```
OdinUser? user = await OdinFunAPI.GetOdinFunUser(identity.GetPublicKey().ToPrincipal().ToString());
if(user != null)
{
    Console.WriteLine(user.username);
    Console.WriteLine(user.profit);
    Console.WriteLine(user.btc_deposit_address);
    Console.WriteLine(user.btc_wallet_address); 
}
```

#### Change OdinFun Username
Call the odin.fun API to change your username using auth tokens

```
Ed25519Identity? trader = Ed25519Identity.FromPrivateKey(Convert.FromBase64String("private-key-here"));
AuthToken? auth = await OdinFunAPI.AuthIdentity(trader);
if (auth != null)
{
    string response = await OdinFunAPI.ChangeUsername("new-username-here", trader.GetPublicKey().ToPrincipal().ToString(), auth.token );
}
```
