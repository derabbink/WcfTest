# WcfTest

A code example that demonstrates WCF's three Message Exchange Patterns (MEP) while maximizing code reuse keeping `App.config` small.
The code features a client that can send greetings to a server, which will send back and ack, a greeting of its own, an exception, or nothing at all.


## How To Run

 * Open `WcfTest.sln` in Visual Studio (>= 2010).
 * run `WcfTest.Host` first.
 * run `WcfTest.Client`
 * Check the client's and server's `App.config` for settings. N.B.: you may need to execute some commands to get permission for opening ports. You can find these in comments in the config files.

If upon running the client, the server generates an exception (in debug mode), just continue running the application. The exceptions thrown are intended to demonstrate how exceptions travel between server and client.


## Purpose

This code is for demonstration purposes only. That's also the reason why there are no tests.

## Assemblies and Dependencies
`WcfTest.Host` requires the following assemblies:

 * `WcfTest.Greeter.Contracts`
 * `WcfTest.Greeter.Service`

`WcfTest.Client` requires the following assemblies:

 * `WcfTest.Greeter.Contracts`
 * `WcfTest.ClientProxy`
 * `WcfTest.Greeter.Service` This last one is only needed because `WcfTest.Client.Samples.MepDuplexSample` uses a default implementation of `WcfTest.Greeter.Contracts.Service.MepDuplex
.IGreeterCallback` in that assembly (which is `WcfTest.Greeter.Service.MepDuplex.GreeterCallbackService`).

This reuse of assemblies is much cleaner than using Visual Studios 'Add Service Reference', or the `svcutil` command.


## Credits

This work was inspired by Miguel Castro's [article][1], which I found through [this answer][2] on Stackoverflow.

 [1]: http://code-magazine.com/article.aspx?quickid=0809101
 [2]: http://stackoverflow.com/a/7474694/1296709
