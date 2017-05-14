# SignalR.Core.Sample

Prerequisites: 

- Install .NET Core 2.0 Preview 1: https://www.microsoft.com/net/core/preview

$ dotnet --version

2.0.0-preview1-005977

Startup:

```
$ git clone https://github.com/bertt/SignalR.Core.Sample.git
$ cd SignalR.Core.Sample
$ cd src
$ dotnet restore
$ dotnet run
```

In browser go to http://localhost:5000

<img src = "signalr_core.gif"/>

nb: the file singnalr-client.js is a copy from the npm signalr-client package:

```
$ npm install signalr-client --registry https://dotnet.myget.org/f/aspnetcore-ci-dev/npm/
```
