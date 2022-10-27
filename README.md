# Relewise.Integrations.Umbraco [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](./LICENSE) [![NuGet version](https://img.shields.io/nuget/v/Relewise.Integrations.Umbraco)](https://www.nuget.org/packages/Relewise.Integrations.Umbraco) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://https://github.com/Relewise/relewise-sdk-csharp-extensions/pulls)

### Installing Relewise.Integrations.Umbraco 

You should install Relewise.Integrations.Umbraco using NuGet:

> Install-Package Relewise.Integrations.Umbraco

Run this command from the NuGet Package Manager Console to install the NuGet package.

### Using Relewise.Integrations.Umbraco

Add Relewise to the UmbracoBuilder, and specify the ContentTypes, that you would like exported into Relewise for content search and recommendation.
In this example, we are exporting all LandingPages and ContentPages to Relewise.
```csharp
services.AddUmbraco(_env, _config)
    .AddRelewise(options => options
        .AddContentType("landingPage", contentType => contentType.AutoMap())
        .AddContentType("blogList", contentType => contentType.UseMapper(new BlogMapper()))
        .AddContentType("contentPage", contentType => contentType.AutoMap())
        .AddContentType("blogEntry", contentType => contentType.AutoMap()))
```

### Sample site - Get it up and running.

The sample site requires .NET 6 and NPM. There is a sample site for both Umbraco v9 and Umbraco v10. 
The sample site share the same frontend client, which is located in the Umbraco v10 sample site folder.
The sample site has demo content, so once it's up and running, you can have a look around. 

 If you wish to setup and run, then just follow the steps below:

1. Start by cloning the repository.
2. Setting up the frontend.
    
    1. Navigate to `samples/UmbracoV10/client` (also if intend to run the v9 sample - see above)
    2. Run `npm install` via a command prompt
    3. Run `npm run serve` via a command prompt

3. Spinning up the site.

    1. Navigate to `samples/UmbracoV9` or `samples/UmbracoV10`, depending on whether you want to sample v9 or v10.
    2. Run `dotnet run` via a command prompt.
    3. Access the website from your browser

4. Installing Umbraco - When visiting the site for the first time, you are asked to configure Umbraco. Just follow the instructions.
5. Publish the content of the site. The site comes with content already created. You just need to login and publish the content

## Resources

Find more information on the Umbraco Marketplace: https://umbraco.com/marketplace/relewise/

## Contributing

Pull requests are always welcome.  
Please fork this repository and make a PR when you are ready with your contribution.  

Otherwise you are welcome to open an Issue in our [issue tracker](https://github.com/Relewise/relewise-integrations-umbraco/issues).

## License

Relewise.Integrations.Umbraco is under the [MIT licensed](./LICENSE)
