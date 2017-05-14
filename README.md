# Running SignalR on .NET Core 2.0.

## Introduction

This is a sample of running SignalR on .NET Core 2.0.

In this sample the following capabilities are demonstrated:

- Runing cross-platform;

- Running client without JQuery dependency;

- Default transport method is websockets.

## Prerequisites 

Install .NET Core 2.0 Preview 1: https://www.microsoft.com/net/core/preview

$ dotnet --version

Should return: 2.0.0-preview1-005977

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

## Development

For further development best is to use Visual Studio Code. For running in Visual Studio, a new preview 2017 version is needed.

## Remarks

The file signalr-client.js is a copy from the npm signalr-client package:

```
$ npm install signalr-client --registry https://dotnet.myget.org/f/aspnetcore-ci-dev/npm/
```
