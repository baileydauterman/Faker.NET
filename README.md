# Purpose

Faker.NET makes it easy to create fake user data. A simple interface to allows users to create preestablished or customized data sets. After importing the project it's as easy as doing:

```csharp
using Faker.NET;

Faker.SetLocale("en");
Faker.SetSeed(10000); // allows for deterministic fake data creation

var firstName = Faker.Person.FirstName();
var lastName = Faker.Person.LastName();
var fullName = Faker.Person.FullName(firstName: firstName, lastName: lastName;
var ipAddr = Faker.Internet.IPv4();

// if using a supported culture as your current culture
Faker.SetLocale(CultureInfo.CurrentCulture);

var fullName = Faker.Person.FullName();
```
