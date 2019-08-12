# Microsoft News API SDK for C#
Integrate the Microsoft News API into your .NET project!

## Give us your feedback
Your feedback is important to us.

- To let us know about any questions or issues you find in the documentation, [submit an issue](https://github.com/microsoft/msnews-sdk-csharp/issues) in this repository.
- We also encourage you to fork, make the fix, and do a pull request of your proposed changes. See [Contributing](##Contributing) section for contributing guidelines.

## Quick Start
### 1. Clone project 
You can clone Microsoft News API SDK for C# using following git command
```shell
cd %YOUR_PROJECT_DIR%
git clone https://github.com/microsoft/msnews-sdk-csharp
```
### 2. Open solution
Open **MSN.Library.MicrosoftNewsAPI.SDK.Csharp.sln** solution in Visual Studio
### 3. Install dependencies
Open **Nuget Manager** and install **Microsoft.Rest.ClientRuntime, Microsoft.NETCore.App, Newtonsoft.Json** packages
### 4. Set your credentials
Set your credentials ( **APIKEY** and **OCID**) at **MicrosoftNewsClient** constructor.
Sample usage as follows,
```csharp
MicrosoftNewsClient client  = new MicrosoftNewsClient("YOUR_APIKEY", "YOUR_OCID");
```
### 5. Sample API calls
You check **Program.cs** file located under **Examples** project to further usage of SDK
```csharp
using System;
using MicrosoftNewsAPI.SDK;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connection client
            MicrosoftNewsClient client;
            if (args.Length == 2)
                client = new MicrosoftNewsClient(args[0], args[1]);
            else
                client = new MicrosoftNewsClient("YOUR_APIKEY", "YOUR_OCID");

            // Sample API calls
            Console.WriteLine("Endpoint /News/Feed");
            var responseGetNewsFeed = client.GetNewsFeed(query:"sports",nextPageCount:20);
            for (int i = 0; i < responseGetNewsFeed.Value.Count; i++) {
                Console.WriteLine(responseGetNewsFeed.Value[i].SubCards.Count);
            }

            Console.WriteLine("Endpoint /News/Markets");
            var responseGetNewsMarkets = client.GetNewsMarkets();
            for (int i = 0; i < responseGetNewsMarkets.Value.Count; i++) {
                Console.WriteLine(responseGetNewsMarkets.Value[i].Id);
            }

            Console.WriteLine("Endpoint /News/Topics");
            var responseGetNewsTopics = client.GetNewsTopics();
            for (int i = 0; i < responseGetNewsTopics.Value.Count; i++) {
                Console.WriteLine(responseGetNewsTopics.Value[i].SubCards.Count);
            }
        }
    }
}

```
Expected Output
```bash
Endpoint /News/Feed
10
Endpoint /News/Markets
M_hi_in
M_es_xl
M_es_mx
M_en_au
M_pt_br
M_es_ar
M_es_co
M_en_in
M_fr_be
M_pt_pt
Endpoint /News/Topics
10
```

## Contributing
This project welcomes contributions and suggestions. Most contributions require you to
agree to a Contributor License Agreement (CLA) declaring that you have the right to,
and actually do, grant us the rights to use your contribution. For details, visit
https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need
to provide a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the
instructions provided by the bot. You will only need to do this once across all repositories using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/)
or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Reporting Security Issues
Security issues and bugs should be reported privately, via email, to the Microsoft Security
Response Center (MSRC) at [secure@microsoft.com](mailto:secure@microsoft.com). You should
receive a response within 24 hours. If for some reason you do not, please follow up via
email to ensure we received your original message. Further information, including the
[MSRC PGP](https://technet.microsoft.com/en-us/security/dn606155) key, can be found in
the [Security TechCenter](https://technet.microsoft.com/en-us/security/default).

## License
Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT [license](License.txt). See [Third Party Notices](THIRD_PARTY_NOTICES) for information on the packages referenced via NuGet.