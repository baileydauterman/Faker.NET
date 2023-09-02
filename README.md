# Faker.NET

> Introducing Faker.NET, the C# Class Library that helps you generate fake data quickly and effortlessly! With just a few lines of code, you can generate names, addresses, phone numbers, email accounts, and much more. Whether you need to populate a test database or create sample data for your application, Faker.NET has got you covered.
>
> What's more, Faker.NET supports the 10 most popular languages in the world, so you can generate fake data in the language of your choice. Say goodbye to spending hours creating fake data manually, and let Faker.NET handle it for you. Try it out today and see how easy it is to use!
> 
> \- ChatGPT

# Purpose

Faker.NET makes it easy to create fake user data. A simple interface to allows users to create preestablished or customized data sets. After importing the project it's as easy as doing:

```csharp
using Faker.NET;

Faker.SetLocale("en");
Faker.SetSeed(10000);

var firstName = Faker.Name.First;
var lastName = Faker.Name.Last;
var fulleName = Faker.Name.Full;
var user = Faker.User.New;
var ipAddr = Faker.Computer.IPv4Address;

Faker.SetLocale(CultureInfo.CurrentCulture);

var user = Faker.User.New;
```
