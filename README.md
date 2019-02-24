This is a .Net Core 2.1 application

To run you will need .Net Core installed on your machine

# How to build

Either build in Visual Studio using the solution file RoadStatus.sln as normal or

Open a command prompt and navigate to the solution directory then run
`dotnet restore`
`dotnet build`


# How to run

This is a dotnet Core project so no .exe is created by default.  Run the application
from the project folder /RoadStatus (not the solution root) by using
`dotnet run A2`

To run the code copy the contents of the /bin/Debug/netcoreapp2.1 folder to your
location and run
`dotnet RoadStatus.dll A2`

Configuration is held in the appsettings.json file and must be added for it to run.
The API returns a 200 when no credentials are supplied not the expected 403.


# Tests

Tests are Nunit 3 and reside in the RoadStatus.Test project.  They can be run by opening
the solution in Visual Studio and should be visible in the test explorer automatically

# Notes

Console apps don't come with a lot of the components ASP.NET projects do, so this needed
Dependency Injection and Configuration management added to it.  Normally using a service-
locator is against the goals of DI.

The code is all located in a single Core project with separate folders for Data and Domain.
Having separate projects for each layer in this application is overkill.

HttpClient is still a pain to mock and test with: IHttpClientFactory or .AddHttpClient 
both don't work  out of the box yet.

I initially tried to use the API with fiddler but this was always rejected is this expected
behaviour?

Finally the A2 went from open to closed the day I made this on!


Ciaran