// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System.Collections.Generic;
using System.Net.Http;
using Microsoft.Rest.Serialization;
using MicrosoftNewsAPI.SDK.Models;
using Newtonsoft.Json;

namespace MicrosoftNewsAPI.SDK
{
    public partial class MicrosoftNewsAPI
    {
        partial void CustomInitialize() {
            // Overwrite Deserialization settings. 
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                TypeNameHandling = TypeNameHandling.Auto,                    
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Full,
                Converters = new List<JsonConverter>
                {
                    new Iso8601TimeSpanConverter()
                }
            };
        }
    }

    public class MicrosoftNewsClient : MicrosoftNewsAPI
    {

        /// <summary>
        /// Your api key.
        /// </summary>
        private string apikey;
        
        /// <summary>
        /// Your ocid.
        /// </summary>
        private string ocid;

        /// <summary>
        /// Initializes a new instance of the OneServiceAPIDocumentation class.
        /// </summary>
        /// <param name='apikey'>
        /// Your API Key as string.
        /// </param>
        /// <param name='ocid'>
        /// Your ocid as string.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling OneServiceAPIDocumentation.Dispose(). False: will not dispose provided httpClient</param>
        public MicrosoftNewsClient(string apikey, string ocid, HttpClient httpClient, bool disposeHttpClient) 
            : base(httpClient, disposeHttpClient)
        {
            this.apikey = apikey;
            this.ocid = ocid;
        }


        /// <summary>
        /// Initializes a new instance of the OneServiceAPIDocumentation class.
        /// </summary>
        /// <param name='apikey'>
        /// Your API Key as string.
        /// </param>
        /// <param name='ocid'>
        /// Your ocid as string.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public MicrosoftNewsClient(string apikey, string ocid, params DelegatingHandler[] handlers)
            : base(handlers)
        {
            this.apikey = apikey;
            this.ocid = ocid;
        }


        /// <summary>
        /// Initializes a new instance of the OneServiceAPIDocumentation class.
        /// </summary>
        /// <param name='apikey'>
        ///  Your API Key as string.
        /// </param>
        /// <param name='ocid'>
        ///  Your ocid as string.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public MicrosoftNewsClient(string apikey, string ocid, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) 
            : base(rootHandler, handlers)
        {
            this.apikey = apikey;
            this.ocid = ocid;
        }


        /// <summary>
        /// Initializes a new instance of the OneServiceAPIDocumentation class.
        /// </summary>
        /// <param name='apikey'>
        /// Your API Key as string.
        /// </param>
        /// <param name='ocid'>
        /// Your ocid as string.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public MicrosoftNewsClient(string apikey, string ocid, System.Uri baseUri, params DelegatingHandler[] handlers) 
            : base(baseUri, handlers)
        {
            this.apikey = apikey;
            this.ocid = ocid;
        }

        /// <summary>
        /// Initializes a new instance of the OneServiceAPIDocumentation class.
        /// </summary>
        /// <param name='apikey'>
        /// Your API Key as string.
        /// </param>
        /// <param name='ocid'>
        /// Your ocid as string.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public MicrosoftNewsClient(string apikey, string ocid) 
        {
            this.apikey = apikey;
            this.ocid = ocid;
        }

        
        /// <summary>
        /// The Feed API is a one stop shop for getting content for any category (ie. autos, sports), search term (ie. Microsoft), or theme (trending feed, related feed).
        /// </summary>
        /// <param name='query'>
        /// Comma separated value for an MSN category, entity, or any freeform search term for which a feed is desired.
        /// </param>
        /// <param name='nextPageCount'>
        /// Indicates the desired number of documents for the next page - Defaults to $top value, or 10 if $top is not specified.
        /// </param>
        /// <param name='market'>
        /// The market.
        /// </param>
        /// <param name='user'>
        /// The user ID of who is making the request, needs to be authenticated.
        /// </param>
        /// <param name='filter'>
        /// ODATA-formatted filter that applies to artifacts. This supports filtering on the following artifact properties:             Provider/Id: can filter out specific providers.             Type: can filter out specific content types.
        /// </param>
        /// <param name='activityId'>
        /// Use this parameter for if you need to relate your request activities with Microsoft News API performance monitoring
        /// </param>
        /// <param name='top'>
        /// Total number of documents required - (default is 10)
        /// </param>
        /// <param name='select'>
        /// Comma separated fields, for attribute projection purpose
        /// </param>
        /// <param name='ids'>
        /// Get related entities via their ids.
        /// </param>
        /// <param name='skip'>
        /// Number of documents to be skipped from the top.
        /// </param>
        public MicrosoftNewsClientODataResponseMicrosoftNewsApiContractsFeedItemViewV1 GetNewsFeed(string query = default(string), int? nextPageCount = default(int?), string market = default(string), string user = default(string), string filter = default(string), string activityId = default(string), int? top = default(int?), string select = default(string), string ids = default(string), int? skip = default(int?))
        {
            return MicrosoftNewsAPIExtensions.GetNewsFeed(this, this.apikey, this.ocid, query, nextPageCount, market, user, filter, activityId, top, select, ids, skip) as MicrosoftNewsClientODataResponseMicrosoftNewsApiContractsFeedItemViewV1;
        }
        
            
        /// <summary>
        /// Read Market objects. Queryable across markets.
        /// </summary>
        /// <param name='filter'>
        /// OData filter.
        /// </param>
        /// <param name='activityId'>
        /// Use this parameter for if you need to relate your request activities with Microsoft News API performance monitoring
        /// </param>
        /// <param name='top'>
        /// Total number of documents required - (default is 10)
        /// </param>
        /// <param name='select'>
        /// Comma separated fields, for attribute projection purpose
        /// </param>
        /// <param name='ids'>
        /// Get related entities via their ids.
        /// </param>
        /// <param name='skip'>
        /// Number of documents to be skipped from the top.
        /// </param>
        public MicrosoftNewsClientODataResponseMsnTagsDataModelTagEntityLibMarket GetNewsMarkets(string filter = default(string), string activityId = default(string), int? top = default(int?), string select = default(string), string ids = default(string), int? skip = default(int?))
        {
            return MicrosoftNewsAPIExtensions.GetNewsMarkets(this, this.apikey, this.ocid, filter, activityId, top, select, ids, skip) as MicrosoftNewsClientODataResponseMsnTagsDataModelTagEntityLibMarket;
        }
        
            
        /// <summary>
        /// Get available interests.
        /// </summary>
        /// <param name='market'>
        /// The market.
        /// </param>
        /// <param name='user'>
        /// The user ID of who is making the request, needs to be authenticated.
        /// </param>
        /// <param name='activityId'>
        /// Use this parameter for if you need to relate your request activities with Microsoft News API performance monitoring
        /// </param>
        /// <param name='top'>
        /// Total number of documents required - (default is 10)
        /// </param>
        /// <param name='select'>
        /// Comma separated fields, for attribute projection purpose
        /// </param>
        /// <param name='ids'>
        /// Get related entities via their ids.
        /// </param>
        /// <param name='skip'>
        /// Number of documents to be skipped from the top.
        /// </param>
        public MicrosoftNewsClientODataResponseMsnTagsDataModelTagEntityLibCompositeCard GetNewsTopics(string market = default(string), string user = default(string), string activityId = default(string), int? top = default(int?), string select = default(string), string ids = default(string), int? skip = default(int?))
        {
            return MicrosoftNewsAPIExtensions.GetNewsTopics(this, this.apikey, this.ocid, market, user, activityId, top, select, ids, skip) as MicrosoftNewsClientODataResponseMsnTagsDataModelTagEntityLibCompositeCard;
        }
        
            

    }
}
    