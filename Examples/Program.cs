// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

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
                       Console.WriteLine("(MsnTagsDataModelTagEntityLibCompositeCard) Composite Card : " + card.Title);
                    }
                }
            }
            else {
                Console.WriteLine("Invalid request or response from GetNewsTopics()");
            }
        }
    }
}