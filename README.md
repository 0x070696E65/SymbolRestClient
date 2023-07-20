# SymbolRestClient

## Installation

```bash
dotnet add package SymbolRestClient
```
or

using Nuget Package Manager

## 必要なライブラリ

- JsonSubTypes (Version 2.0.1): A library for supporting subtypes during JSON serialization and deserialization.
- Newtonsoft.Json (Version 13.0.3): A popular library for serializing and deserializing JSON data in .NET applications.
- RestSharp (Version 108.0.3): A simple and easy-to-use client library for making requests to RESTful APIs.
- Polly (Version 7.2.3): A library for implementing policies like retry, fallback, and circuit breaker in .NET applications.
- System.ComponentModel.Annotations (Version 5.0.0): A library for adding annotations to data models in .NET applications, enabling data validation and metadata enhancements.

## 使い方

```csharp
// アカウント
var accountRoutesApi = new SymbolRestClient.Api.AccountRoutesApi(NODE_URL);
var acc = accountRoutesApi.GetAccountInfo("SYMBOL_ADDRESS or PUBLIC_KEY");

// トランザクション
var transactionRoutesApi = new SymbolRestClient.Api.TransactionRoutesApi(node);
var tranasction = transactionRoutesApi.GetConfirmedTransaction("14019F0FEDFF2DDFF22355A21617C50F5BEA7CD9B64D2D2D947BD312A015A8B0");
if (tranasction.Transaction.ActualInstance.GetType() == typeof(TransferTransactionDTO))
{
    if(tranasction.Transaction.ActualInstance is TransferTransactionDTO transfer)
        Console.WriteLine(Converter.HexToUtf8(transfer.Message));
}
```

