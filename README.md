# Microsoft News API SDK for C#
Integrate the Microsoft News API into your .NET project!
To obtain your api key and ocid, you can send us an [e-mail](mailto:msftnewsapi@microsoft.com)!
[![Build status](https://microsoft.visualstudio.com/Universal%20Store/_apis/build/status/%5B5%5D%20%5BGitHub%5D%20%5BCI%5D%20Microsoft%20News%20SDK%20GitHub%20CI)](https://microsoft.visualstudio.com/Universal%20Store/_build/latest?definitionId=44416)

## Give us your feedback
Your feedback is important to us.

- To let us know about any questions or issues you find in the documentation, [submit an issue](https://github.com/microsoft/msnews-sdk-csharp/issues) in this repository.
- We also encourage you to fork, make the fix, and do a pull request of your proposed changes. See [Contributing](#Contributing) section for contributing guidelines.

## Quick Start
### 1. Clone project 
You can clone Microsoft News API SDK for C# using following git command
```shell
cd %YOUR_PROJECT_DIR%
git clone https://github.com/microsoft/msnews-sdk-csharp
```
### 2. Open solution
Open **MSN.Library.MicrosoftNewsAPI.SDK.Csharp.sln** solution in Visual Studio
### 3. Set your credentials
Set your credentials ( **APIKEY** and **OCID**) at **MicrosoftNewsClient** constructor.
Sample usage as follows,
```csharp
MicrosoftNewsClient client  = new MicrosoftNewsClient("YOUR_APIKEY", "YOUR_OCID");
```
### 4. Sample API calls
You check **Program.cs** file located under **Examples** project to further usage of SDK
```csharp

using System;
using MicrosoftNewsAPI.SDK;
using MicrosoftNewsAPI.SDK.Models;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            MicrosoftNewsClient client;
            if (args.Length == 2)
                client = new MicrosoftNewsClient(args[0], args[1]);
            else
                client = new MicrosoftNewsClient("YOUR_APIKEY", "YOUR_OCID");
            

            Console.WriteLine("Endpoint /news/feed");
            var responseGetNewsFeed = client.GetNewsFeed();
            if (responseGetNewsFeed != null) {
                for (int i = 0; i < responseGetNewsFeed.Value.Count; i++) {
                    Console.WriteLine("Number of subCards : " + responseGetNewsFeed.Value[i].SubCards.Count);
                    foreach (var card in responseGetNewsFeed.Value[i].SubCards)
                    {
                        Console.WriteLine("(MicrosoftNewsApiContractsFeedItemViewV1) Title :" + card.Title);
                    }
                }
            }
            else {
                Console.WriteLine("Invalid request or response from GetNewsFeed()");
            }
            
            
            Console.WriteLine("Endpoint /news/markets");
            var responseGetNewsMarkets = client.GetNewsMarkets();
            if (responseGetNewsMarkets != null) {
                for (int i = 0; i < responseGetNewsMarkets.Value.Count; i++) {
                    Console.WriteLine("(MsnTagsDataModelTagEntityLibMarket) Culture :" + responseGetNewsMarkets.Value[i].Culture);
                }
            }
            else {
                Console.WriteLine("Invalid request or response from GetNewsMarkets()");
            }
            
            
            Console.WriteLine("Endpoint /news/topics");
            var responseGetNewsTopics = client.GetNewsTopics();
            if (responseGetNewsTopics != null) {
                for (int i = 0; i < responseGetNewsTopics.Value.Count; i++) {
                    Console.WriteLine("Number of subCards : " + responseGetNewsTopics.Value[i].SubCards.Count);
                    foreach (var card in responseGetNewsTopics.Value[i].SubCards)
                    {
                        if (card is MsnTagsDataModelTagEntityLibArtifact)
                        {
                            var artifact = (MsnTagsDataModelTagEntityLibArtifact) card;
                            Console.WriteLine("(MsnTagsDataModelTagEntityLibArtifact) Title : " + artifact.Title);
                        
                        }
                        else if (card is MsnTagsDataModelTagEntityLibSysTag)
                        {
                            var sysTag = (MsnTagsDataModelTagEntityLibSysTag) card;
                            Console.WriteLine("(MsnTagsDataModelTagEntityLibSysTag) Name : " + sysTag.Name);
                        }
                        else if (card is MsnTagsDataModelTagEntityLibCompositeCard)
                        {
                            var compositeCard = (MsnTagsDataModelTagEntityLibCompositeCard) card;
                            Console.WriteLine("(MsnTagsDataModelTagEntityLibCompositeCard) Composite Card : " + compositeCard.Title);
                        }
                        else
                        {
                            Console.WriteLine("ERROR!");
                        }
                    }
                }
            }
            else {
                Console.WriteLine("Invalid request or response from GetNewsTopics()");
            }
            
            
        }
    }
}

```
Expected Output
```bash
Endpoint /news/feed
Number of subCards : 10
(MicrosoftNewsApiContractsFeedItemViewV1) Title :Trump questions patriotism of whistleblower in firestorm
(MicrosoftNewsApiContractsFeedItemViewV1) Title :Fashion hits and misses
(MicrosoftNewsApiContractsFeedItemViewV1) Title :Best pictures from the 2019 Emmys
(MicrosoftNewsApiContractsFeedItemViewV1) Title :Woman sexually assaulted by Brock Turner gives '60 Minutes' interview
(MicrosoftNewsApiContractsFeedItemViewV1) Title :Ranking the 7 NFL teams with 3-0 records
(MicrosoftNewsApiContractsFeedItemViewV1) Title :5 TV shows and people who don't deserve their Emmy awards - sorry
(MicrosoftNewsApiContractsFeedItemViewV1) Title :Kasich on Ukraine: 'People would be going crazy' if Obama did this
(MicrosoftNewsApiContractsFeedItemViewV1) Title :Overstock plummets 19% as CFO resigns
(MicrosoftNewsApiContractsFeedItemViewV1) Title :Tekashi 69: Can he disappear after testifying against the Bloods?
(MicrosoftNewsApiContractsFeedItemViewV1) Title :This company has filed 10,000 appeals to Trump's tariffs
Endpoint /news/markets
(MsnTagsDataModelTagEntityLibMarket) Culture :hi-in
(MsnTagsDataModelTagEntityLibMarket) Culture :es-xl
(MsnTagsDataModelTagEntityLibMarket) Culture :es-mx
(MsnTagsDataModelTagEntityLibMarket) Culture :en-au
(MsnTagsDataModelTagEntityLibMarket) Culture :pt-br
(MsnTagsDataModelTagEntityLibMarket) Culture :es-ar
(MsnTagsDataModelTagEntityLibMarket) Culture :es-co
(MsnTagsDataModelTagEntityLibMarket) Culture :en-in
(MsnTagsDataModelTagEntityLibMarket) Culture :fr-be
(MsnTagsDataModelTagEntityLibMarket) Culture :pt-pt
Endpoint /news/topics
Number of subCards : 10
(MsnTagsDataModelTagEntityLibSysTag) Name : outlook-uwp
(MsnTagsDataModelTagEntityLibSysTag) Name : Royals
(MsnTagsDataModelTagEntityLibSysTag) Name : Milwaukee
(MsnTagsDataModelTagEntityLibSysTag) Name : Oklahoma City
(MsnTagsDataModelTagEntityLibSysTag) Name : San Antonio
(MsnTagsDataModelTagEntityLibSysTag) Name : Los Angeles
(MsnTagsDataModelTagEntityLibSysTag) Name : Portland, ME
(MsnTagsDataModelTagEntityLibSysTag) Name : Cleveland
(MsnTagsDataModelTagEntityLibSysTag) Name : New Orleans
(MsnTagsDataModelTagEntityLibSysTag) Name : Baltimore
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

## Dependencies
**Microsoft.Rest.ClientRuntime** (SDK Project), **Newtonsoft.Json** (SDK Project), **Microsoft.NETCore.App** (Sample Project)  
