# Running SignalR on .NET Core 2.1.

## Introduction

This is a sample of running SignalR on .NET Core 2.1.

In this sample the following capabilities are demonstrated:

- Running cross-platform;

- Running client without JQuery dependency;

- Default transport method is websockets.

## Prerequisites 

Install .NET Core 2.1: https://www.microsoft.com/net/core/

```
$ dotnet --version
```

Should return: 2.1.301

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


