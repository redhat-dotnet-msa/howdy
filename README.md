[![Stories in Ready](https://badge.waffle.io/redhat-dotnet-msa/howdy.png?label=ready&title=Ready)](https://waffle.io/redhat-dotnet-msa/howdy)
# howdy
RESTful service that returns "howdy".

### Platform
This microservice requires .NET Core 1.1. It is written to use Red Hat Enterprise Linux.

### Briefly...
This service has a mechanism built in to mimic an overloaded or slow server. This feature is controlled by the URI used to GET from this service:

/greeting - this returns the string "Howdy". If the file 'slowdown' exists, the service will sleep for nine (9) seconds before returning, feigning a slow service.

/slowdown - this creates a file ('slowdown'). Because a file is persistent across multiple sessions, subsequent calls to this service will see it and respond accordingly.

/normal - this deletes the file 'slowdown'

This normal/slowdown feature is highlighted by using the Circuit Breaker Pattern. A command-line client can be found at https://github.com/redhat-dotnet-msa/circuitbreaker_console_app.
