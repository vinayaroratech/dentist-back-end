# back-end

DentallApp is a web application with chatbot for appointment management, reminders and sending appointment cancellation messages for the dental office called [World Dental CO](https://www.tiktok.com/@worlddentalco).

> The maintainer of this repository is [Dave Roman](https://github.com/MrDave1999).
>
> This project has been improved too much since its [first alpha version](https://github.com/DentallApp/back-end/tree/v0.1.0). 

## Index

- [Important](#important)
- [Motivations](#motivations)
- [Technologies used](#technologies-used)
  - [Softwares](#softwares)
  - [Frameworks and libraries](#frameworks-and-libraries)
  - [Testing](#testing)
  - [Own libraries](#own-libraries)
- [Software Engineering](#software-engineering)
- [Installation](#installation)
- [Plugin configuration](#plugin-configuration)
- [Credentials](#credentials)
- [Validate identity documents](#validate-identity-documents)
- [Configure languages](#configure-languages)
- [Diagrams](#diagrams)
  - [General architecture](#general-architecture)
  - [Core layer](#core-layer)
  - [Relational model](#relational-model)
- [Direct Line API](#direct-line-api)
- [EF Core Migrations](#ef-core-migrations)
- [Running tests](#running-tests)
- [Contribution](#contribution)

## Important

This application was developed as a degree project for the [University of Guayaquil](https://www.ug.edu.ec), however, it is not ready to run in a production environment. All requirements for this project were obtained through interviews with the owner dentist of [World Dental CO](https://www.facebook.com/worlddentalco).

In the end, this project was never deployed in that dental office for personal reasons of the authors. However, it was decided to publish the source code of this application so that the community can use it for learning purposes (learn from it or even improve it).

## Motivations

I have continued to maintain this project because I have been experimenting with plugin-based architecture and I love it.

I have not found any .NET project that has applied this architectural pattern and I don't mean a sample project, but one that solves a problem. For that reason I decided to apply it in this project, I'm sure many will find it useful as knowledge.

Another of my reasons is that what I learn about software engineering, I like to share with the community. That's why I have been inspired to improve it.

> The best way to learn things is to do projects.

## Technologies used

### Softwares
- [.NET CLI](https://learn.microsoft.com/en-us/dotnet/core/tools)
- [Visual Studio 2022](https://visualstudio.microsoft.com)
- [vscode](https://github.com/microsoft/vscode)
- [Docker](https://github.com/docker)
- [Postman](https://www.postman.com)
- [InDirectLine](https://github.com/newbienewbie/InDirectLine)
- [MariaDB](https://github.com/mariadb)
- [HeidiSQL](https://github.com/HeidiSQL)
- [BotFramework-Emulator](https://github.com/microsoft/BotFramework-Emulator)
- [GitHub Actions](https://github.com/actions)
- [Git](https://git-scm.com)
- [draw.io](https://app.diagrams.net)

### Frameworks and libraries
- [ASP.NET Core](https://github.com/dotnet/aspnetcore)
- [Microsoft Bot Framework](https://github.com/microsoft/botframework-sdk)
- [AdaptiveCards](https://github.com/microsoft/AdaptiveCards)
- [Twilio](https://github.com/twilio/twilio-csharp)
- [SendGrid](https://github.com/sendgrid/sendgrid-csharp)
- [SendGrid.Extensions.DependencyInjection](https://www.nuget.org/packages/SendGrid.Extensions.DependencyInjection)
- [libphonenumber-csharp](https://github.com/twcclegg/libphonenumber-csharp)
- [Quartz.Net](https://github.com/quartznet/quartznet)
- [Quartz.Extensions.Hosting](https://www.nuget.org/packages/Quartz.Extensions.Hosting)
- [Swashbuckle.AspNetCore](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
- [Scrutor](https://github.com/khellang/Scrutor)
- [efcore](https://github.com/dotnet/efcore)
- [Pomelo.EntityFrameworkCore.MySql](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql)
- [EFCore.NamingConventions](https://github.com/efcore/EFCore.NamingConventions)
- [linq2db.EntityFrameworkCore](https://github.com/linq2db/linq2db.EntityFrameworkCore)
- [EntityFramework.Exceptions](https://github.com/Giorgi/EntityFramework.Exceptions)
- [EFCore.CustomQueryPreprocessor](https://github.com/MrDave1999/EFCore.CustomQueryPreprocessor)
- [DelegateDecompiler](https://github.com/hazzik/DelegateDecompiler)
- [Dapper](https://github.com/DapperLib/Dapper)
- [Microsoft.VisualStudio.Threading.Analyzers](https://github.com/microsoft/vs-threading)
- [Microsoft.AspNetCore.Authentication.JwtBearer](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer)
- [Microsoft.IdentityModel.Tokens](https://www.nuget.org/packages/Microsoft.IdentityModel.Tokens)
- [System.IdentityModel.Tokens.Jwt](https://www.nuget.org/packages/System.IdentityModel.Tokens.Jwt)
- [BCrypt.Net-Next](https://github.com/BcryptNet/bcrypt.net)
- [Scriban](https://github.com/scriban/scriban)
- [itext7.pdfhtml](https://github.com/itext/i7n-pdfhtml)
- [File.TypeChecker](https://github.com/AJMitev/FileTypeChecker)
- [FluentValidation](https://github.com/FluentValidation/FluentValidation)
- [FluentValidation.DependencyInjectionExtensions](https://www.nuget.org/packages/FluentValidation.DependencyInjectionExtensions)

### Testing
- [NUnit](https://github.com/nunit/nunit)
- [FluentAssertions](https://github.com/fluentassertions/fluentassertions)
- [JustMock](https://github.com/telerik/JustMockLite)
- [coverlet.msbuild](https://github.com/coverlet-coverage/coverlet)
- [Respawn](https://github.com/jbogard/Respawn)
- [Microsoft.AspNetCore.Mvc.Testing](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Testing)
- [Microsoft.Bot.Builder.Testing](https://www.nuget.org/packages/Microsoft.Bot.Builder.Testing)

### Own libraries
- [DotEnv.Core](https://github.com/MrDave1999/dotenv.core)
- [YeSql.Net](https://github.com/ose-net/yesql.net)
- [SimpleResults](https://github.com/MrDave1999/SimpleResults)
- [CPlugin.Net](https://github.com/MrDave1999/CPlugin.Net)
- [CPlugin.Net.Attributes](https://www.nuget.org/packages/CPlugin.Net.Attributes)
- [CopySqlFilesToOutputDirectory](https://www.nuget.org/packages/CopySqlFilesToOutputDirectory)
- [CopyPluginsToPublishDirectory](https://www.nuget.org/packages/CopyPluginsToPublishDirectory)

## Software Engineering

Software engineering concepts have been applied in this project:
- [Vertical Slice Architecture](https://garywoodfine.com/implementing-vertical-slice-architecture)
- [CQRS](https://en.wikipedia.org/wiki/Command_Query_Responsibility_Segregation)
- [Plugin-based architecture](https://www.linkedin.com/pulse/plugin-architecture-design-pattern-beginners-guide-nick-cosentino)
- [Interface-based programming](https://en.wikipedia.org/wiki/Interface-based_programming)
- [Modular programming](https://en.wikipedia.org/wiki/Modular_programming)
- [Dependency injection](https://en.wikipedia.org/wiki/Dependency_injection)
- [Operation Result Pattern](https://medium.com/@wgyxxbf/result-pattern-a01729f42f8c)
- [Guard Clause](https://deviq.com/design-patterns/guard-clause)
- [Fail Fast](https://deviq.com/principles/fail-fast)
- [Open-closed principle](https://en.wikipedia.org/wiki/Open%E2%80%93closed_principle)
- [Acyclic dependencies principle](https://en.wikipedia.org/wiki/Acyclic_dependencies_principle)
- [Explicit dependencies](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles#explicit-dependencies)
- [Separation of concerns](https://en.wikipedia.org/wiki/Separation_of_concerns)

**Additional references:**
- [Software principles and design](https://deviq.com)
- [Plugin Architecture Pattern in C# by Alvaro Montoya](https://code-maze.com/csharp-plugin-architecture-pattern)
- [Plugin Architecture Design Pattern by Nick Cosentino](https://www.devleader.ca/2023/09/07/plugin-architecture-design-pattern-a-beginners-guide-to-modularity)
- [Plugin Architecture In C# For Improved Software Design by Nick Cosentino](https://www.devleader.ca/2024/03/12/plugin-architecture-in-c-for-improved-software-design)
- [Vertical Slice Architecture in ASP.NET Core by Swapnil Meshram](https://www.linkedin.com/pulse/vertical-slice-architecture-aspnet-core-swapnil-meshram-sitsf)
- [Vertical Slice Architecture in ASP.NET Core by Code Maze](https://code-maze.com/vertical-slice-architecture-aspnet-core)

## Installation

To run this application, it is recommended to install [Docker](https://docs.docker.com/get-docker), it is much easier to install the app with [Docker](https://docs.docker.com/get-docker).

- Clone the repository with this command.
```sh
git clone https://github.com/DentallApp/back-end.git
```
- Change directory.
```sh
cd back-end
```
- Copy the contents of `.env.example` to `.env`.
```sh
cp .env.example .env
# On Windows use the "xcopy" command.
```
- You must specify the [time zone](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones) for the Docker container. This is necessary for the calculation of available hours for a medical appointment to return consistent results.
The logical thing to do would be to choose the time zone in which the dental clinic is located (which in this case would be **America/Guayaquil**).
```sh
echo -e '\nTZ=America/Guayaquil' >> .env
```
- Build the image and initiate services.
```sh
docker compose up --build -d
```
- Access the application with this URL.
```
http://localhost:5000/swagger
```
- If you wish to test the chatbot, you can do so with the [test client](https://github.com/DentallApp/webchat-client). Access this URL.
```
https://dentallapp.github.io/webchat-client
```

**NOTE:** Twilio.WhatsApp and SendGrid (these are plugins) are not loaded by default. So the app will use a fake provider that uses a console logger (useful for a development environment).

## Plugin configuration

By default only two plugins are loaded:
- `Plugin.ChatBot.dll`
- `Plugin.AppointmentReminders.dll`

You can add other plugins by modifying the [PLUGINS](https://github.com/DentallApp/back-end/blob/52a0f58f8a721d731b0c21da75bb648eedb40d33/.env.example#L9-L12) key from the .env file:
```.env
PLUGINS="
Plugin.ChatBot.dll
Plugin.AppointmentReminders.dll
Plugin.Twilio.WhatsApp.dll
Plugin.SendGrid.dll
"
```
Of course, for this to work, you will need to create an account on [Twilio](https://www.twilio.com/en-us) and [SendGrid](https://sendgrid.com/en-us), generate the necessary credentials and then add it to the .env file.

You can also remove all plugins. The host application will work without any problems. 

## Credentials

The following table shows the default credentials for authentication from the application.

| Username                | Password                    |
|-------------------------|-----------------------------|
| basic_user@hotmail.com  | 123456                      |
| secretary@hotmail.com   | 123456                      |
| dentist@hotmail.com     | 123456                      |
| admin@hotmail.com       | 123456                      |
| superadmin@hotmail.com  | 123456                      |

Use this route for authentication:
```
POST - /api/user/login
```
Request body:
```json
{
  "userName": "basic_user@hotmail.com",
  "password": "123456"
}
```

## Validate identity documents

To validate identity documents, it depends largely on the country where the dental office is located. At the moment, we can only validate identity documents registered in Ecuador.

You can enable it from the configuration file, e.g.
```.env
PLUGINS="
Plugin.IdentityDocument.Ecuador.dll
"
```
In case there is no plugin loaded to validate the identity document, the host application will use a fake provider called [FakeIdentityDocument](https://github.com/DentallApp/back-end/blob/dev/src/Infrastructure/Services/FakeIdentityDocument.cs).

It was decided to implement the logic to validate identity documents from a plugin, because it is flexible, since it allows to change the implementation without having to modify the source code of the host application.

## Configure languages

This project uses [resource files](https://github.com/DentallApp/back-end/tree/dev/src/Shared/Resources) to store response messages in different languages. If you want to add a new language, you must modify the [Languages section](https://github.com/DentallApp/back-end/blob/52a0f58f8a721d731b0c21da75bb648eedb40d33/src/HostApplication/appsettings.json#L7-L10) of `appsettings.json`.
```json
"Languages": [
  "es",
  "en",
  "fr"
]
```

## Diagrams

### General architecture

<details>
<summary><b>Show diagram</b></summary>

![general-architecture](https://github.com/DentallApp/back-end/blob/dev/diagrams/general-architecture.png)

</details>

<details>
<summary><b>More details</b></summary>
<br/>

**Overview of each component:**
- **Host Application.** Contains everything needed to run the application. It represents the entry point of the application.
  This layer performs other tasks such as:
  - Load plugins from a configuration file (.env) using the library called [CPlugin.Net](https://github.com/MrDave1999/CPlugin.Net).
  - Finds the types that implement the interfaces shared between the host application and the plugins to create instances of those types.
  - Add services to the service collection, register middleware, load SQL files, load the .env file, among other things.
- **Shared Layer.** It contains common classes and interfaces between many components. This layer has [aspects](https://en.wikipedia.org/wiki/Aspect_(computer_programming)) (additional parts) that are not related to the main processes of the application.
  - This layer contains the interfaces that allow communication between the host application and the plugins.
  - This layer does not contain the implementation of a functional requirement.
  - It contains other things such as:
    - Extension classes
    - Exception classes
    - Classes mapped to the database schema (entities)
    - Data models
    - Value objects
    - Objects that represent error and success messages
    - Constants
    - Settings objects
    - Language resources 
    - Common validation rules
    - Repository and service interfaces
- **Core Layer.** Contains the main processes (essential features) of the application.
  - Each feature represents a functional requirement of what the app should do. 
  - A feature contains the minimum code to execute a functional requirement. 
  - The purpose of grouping related elements of a feature is to increase cohesion.
  - By convention, each feature module contains a:
    - Controller
    - Request/Response
    - Validator
    - Use case class (has the logic of the functional requirement)
- **Infrastructure Layer.** Contains the implementation (concrete classes) of an interface defined in the shared layer. 
  - The purpose of this layer is to hide external dependencies that you do not have control over.
  - This layer is useful because it avoids exposing third party dependencies to other components, so if the dependency is changed/removed it should not affect any other component.
  - Not all third party dependencies are added in this layer. For example, Entity Framework Core is used directly in the features to avoid introducing more complexity.
- **ChatBot.** It is an plugin that allows a basic user to schedule appointments from a chatbot.
- **Appointment Reminders.** It is a plugin that allows to send appointment reminders to patients through a background service.
- **SendGrid Email.** It is a plugin that allows to send emails in cases such as:
  - When a customer registers in the application, an email is sent to confirm the user's email address.
  - When a user wants to reset their password, an email is sent with the security token.
- **Twilio WhatsApp.** It is a plugin that allows to send messages by whatsapp in cases such as:
  - When an appointment is scheduled from the chatbot, the user is sent the appointment information to whatsapp.
  - When an employee needs to cancel an appointment, he/she should notify patients by whatsapp.
- **IdentityDocument.Ecuador.** It is a plugin that allows to validate identity documents registered in Ecuador.
  This plugin uses an [algorithm](https://www.skypack.dev/view/udv-ec) to verify if the identity document is valid or not.

</details>

### Core layer

<details>
<summary><b>Show diagram</b></summary>

![core-layer](https://github.com/DentallApp/back-end/blob/dev/diagrams/core-layer.png)

</details>

<details>
<summary><b>More details</b></summary>

The above diagram describes in more detail which feature modules are contained in the core layer. 

In the presented diagram it can be identified that the feature modules are not coupled to each other, the purpose of this is not to cause a [dependency hell](https://en.wikipedia.org/wiki/Dependency_hell), in order to maintain a dependency graph that is as simple as possible. The purpose is to make it easier to understand the parts of the backend application.

</details>

### Relational model

<details>
<summary><b>Show diagram</b></summary>

![relational-model](https://github.com/DentallApp/back-end/blob/dev/diagrams/relational-model.png)

</details>

## Direct Line API

[Direct Line API](https://learn.microsoft.com/en-us/azure/bot-service/rest-api/bot-framework-rest-direct-line-3-0-api-reference) allows your client application to communicate with the bot. It acts as a bridge between the client and the bot.

For development and test environments you can use [InDirectLine](https://github.com/newbienewbie/InDirectLine) to avoid having to use Azure. [InDirectLine](https://github.com/newbienewbie/InDirectLine) is a bridge that implements the Direct Line API, but should not be used for production.

By default, the configuration file (.env) contains a key called `DIRECT_LINE_BASE_URL`.
```.env
DIRECT_LINE_BASE_URL=http://indirectline:3000/
```
The provider called [InDirectLine](https://github.com/newbienewbie/InDirectLine) is used by default.

In production, the value of this key must be changed to:
```.env
DIRECT_LINE_BASE_URL=https://directline.botframework.com/
```
In that case the provider to use will be the Direct Line channel of Azure Bot. The backend application is able to switch providers just by reading the URL.

## EF Core Migrations

You can use EF Core migrations to create the database from the entities.

- You must install [dotnet ef](https://learn.microsoft.com/en-us/ef/core/cli/dotnet#installing-the-tools) as a global tool using the following command:
```sh
dotnet tool install --global dotnet-ef
```

- Change directory.
```sh
cd src/HostApplication
```

- Run this command to create the migration files.
```sh
dotnet ef migrations add InitialCreate
```

- At this point you can have EF create your database and create your schema from the migration.
```sh
dotnet ef database update
```

> That's all there is to it - your application is ready to run on your new database, and you didn't need to write a single line of SQL. Note that this way of applying migrations is ideal for local development, but is less suitable for production environments - see the [Applying Migrations](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/applying) page for more info.

## Running tests

To run the unit tests on your local machine, run this command:
```sh
dotnet test ./tests/UnitTests/DentallApp.UnitTests.csproj -c Release
```

You can also run the chatbot tests on their local machine:
```sh
dotnet test ./tests/ChatBot/Plugin.ChatBot.IntegrationTests.csproj -c Release
```

You can run the integration tests that depend on a database but first you need to follow the following steps:
- Install [MariaDb Server](https://mariadb.com/downloads) and set up your username and password.
- Create a file called `.env` in the root directory with the command:
```sh
cp .env.example .env
# On Windows use the "xcopy" command.
```
- Create a file called `.env.test` in the test directory with the command:
```sh
cp ./tests/IntegrationTests/.env.test.example ./tests/IntegrationTests/.env.test
# On Windows use the "xcopy" command.
```
- Specify your database credentials in the `.env.test` file.
- Execute the dotnet test command to run the tests.
```sh
dotnet test ./tests/IntegrationTests/DentallApp.IntegrationTests.csproj -c Release
```

> The database credentials you have in the ".env" file may not necessarily be the same as those in the ".env.test" file. For example, the ".env" file may have credentials from a remote AWS database and run the application on your local machine with that connection string.

## Contribution

Any contribution is welcome! Remember that you can contribute not only in the code, but also in the documentation or even improve the tests.

Follow the steps below:

- Fork it
- Create your custom branch (git checkout -b my-new-change)
- Commit your changes (git commit -am 'Add some change')
- Push to the branch (git push origin my-new-change)
- Create new Pull Request