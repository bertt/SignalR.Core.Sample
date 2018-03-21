# Running SignalR on .NET Core 2.1.

## Introduction

This is a sample of running SignalR on .NET Core 2.1.

In this sample the following capabilities are demonstrated:

- Running cross-platform;

- Running client without JQuery dependency;

- Default transport method is websockets.

## Prerequisites 

Install .NET Core 2.1 Preview 1: https://www.microsoft.com/net/core/preview

```
$ dotnet --version
```

Should return: 2.1.300-preview1-008174

## Startup

```
$ git clone https://github.com/bertt/SignalR.Core.Sample.git
$ cd SignalR.Core.Sample
$ cd src
$ dotnet restore
$ dotnet run
```

## Testing 

In browser go to http://localhost:5000

## Demo 

<img src = "signalr_core.gif"/>

## Protocol

1] get token

request: http://localhost:5000/chat/negotiate?

response: d6515a93-4533-4654-9bf6-530718bc8e4a

2] change to websockets

request: ws://localhost:5000/chat/ws?id=d6515a93-4533-4

101 Switching Protocols

response: Connection:Upgrade

3] send message

{"invocationId":"5","type":1,"target":"Send","nonBlocking":true,"arguments":["yo"]

More on the protocol https://github.com/aspnet/SignalR/blob/dev/specs/HubProtocol.md

## Development

For further development best is to use Visual Studio Code. For running in Visual Studio, a new preview 2017 version is needed.

## Remarks

The Microsoft.AspNetCore.SignalR we get from: https://dotnet.myget.org/feed/aspnetcore-dev/package/nuget/Microsoft.AspNetCore.SignalR

The file signalr-client.js is a copy from the npm signalr-client package:

```
$ npm install signalr-client --registry https://dotnet.myget.org/f/aspnetcore-ci-dev/npm/
```
