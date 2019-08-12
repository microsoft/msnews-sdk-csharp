// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System;
using MicrosoftNewsAPI.SDK;

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
            

            
            Console.WriteLine("Endpoint /news/topics");
            var responseGetNewsTopics = client.GetNewsTopics();
            if (responseGetNewsTopics != null) {
                for (int i = 0; i < responseGetNewsTopics.Value.Count; i++) {
                    Console.WriteLine(responseGetNewsTopics.Value[i]);
                }
            }
            else {
                Console.WriteLine("Invalid request or response from GetNewsTopics()");
            }
            
            
            Console.WriteLine("Endpoint /news/feed");
            var responseGetNewsFeed = client.GetNewsFeed();
            if (responseGetNewsFeed != null) {
                for (int i = 0; i < responseGetNewsFeed.Value.Count; i++) {
                    Console.WriteLine(responseGetNewsFeed.Value[i]);
                }
            }
            else {
                Console.WriteLine("Invalid request or response from GetNewsFeed()");
            }
            
            
            Console.WriteLine("Endpoint /news/markets");
            var responseGetNewsMarkets = client.GetNewsMarkets();
            if (responseGetNewsMarkets != null) {
                for (int i = 0; i < responseGetNewsMarkets.Value.Count; i++) {
                    Console.WriteLine(responseGetNewsMarkets.Value[i]);
                }
            }
            else {
                Console.WriteLine("Invalid request or response from GetNewsMarkets()");
            }
            
            
        }
    }
}
    