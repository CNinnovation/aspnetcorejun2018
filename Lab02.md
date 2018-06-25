# Lab 02 - Using .NET Core Libraries

## Dependency Injection

1. Create a console application
2. Create a service contract *IHelloService* with a *Hello* method
3. Create *HelloController* with constructor injection using the IHelloService, and a *Greeting* method using the *IHelloService*
4. Create a concrete imlpementation for the IHelloService
5. Use the *HelloController* from the *Program* class
6. Add the NuGet package *Microsoft.Extensions.DependendyInjection*
7. Register services *IHelloService* and *HelloController* with the container
8. Use the *HelloController* by getting a reference from the container

Questions:

1. How is the *HelloController* instantiated?
2. What happens if the IHelloService implementation cannot be found?

