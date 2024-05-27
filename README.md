# dotnet-restart-webapi-programmatically

A proof of concept for restarting a .NET WebAPI with code

## How to run ?

```pwsh
dotnet build
dotnet run
```

Visit http://localhost:5080/status to see server uptime.

Visit http://localhost:5080/admin/shutdown-r to programmatically restart the server.

<kbd>CTRL + C</kbd> to stop

## How does it work ?

`IHostApplicationLifetime.StopApplication()` allows shutting down the server on demand.

To restart the server, start a second process in the background, running the same executable -
just wait a few seconds until the first process finishes and stops listening to the 5080 port.
