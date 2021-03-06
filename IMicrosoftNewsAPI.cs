// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace MicrosoftNewsAPI.SDK
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    public partial interface IMicrosoftNewsAPI : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// The Feed API is a one stop shop for getting content for any
        /// category (ie. autos, sports), search term (ie. Microsoft), or theme
        /// (trending feed, related feed).
        /// </summary>
        /// <param name='apikey'>
        /// Security parameter : apikey
        /// </param>
        /// <param name='ocid'>
        /// Security parameter : ocid
        /// </param>
        /// <param name='query'>
        /// Comma separated value for an MSN category, entity, or any freeform
        /// search term for which a feed is desired.
        /// </param>
        /// <param name='nextPageCount'>
        /// Indicates the desired number of documents for the next page -
        /// Defaults to $top value, or 10 if $top is not specified.
        /// </param>
        /// <param name='market'>
        /// The market.
        /// </param>
        /// <param name='user'>
        /// The user ID of who is making the request, needs to be
        /// authenticated.
        /// </param>
        /// <param name='filter'>
        /// ODATA-formatted filter that applies to artifacts. This supports
        /// filtering on the following artifact properties:
        /// Provider/Id: can filter out specific providers.
        /// Type: can filter out specific content types.
        /// </param>
        /// <param name='activityId'>
        /// Use this parameter for if you need to relate your request
        /// activities with Microsoft News API performance monitoring
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
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetNewsFeedWithHttpMessagesAsync(string apikey, string ocid, string query = default(string), int? nextPageCount = default(int?), string market = default(string), string user = default(string), string filter = default(string), string activityId = default(string), int? top = default(int?), string select = default(string), string ids = default(string), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Read Market objects. Queryable across markets.
        /// </summary>
        /// <param name='apikey'>
        /// Security parameter : apikey
        /// </param>
        /// <param name='ocid'>
        /// Security parameter : ocid
        /// </param>
        /// <param name='filter'>
        /// OData filter.
        /// </param>
        /// <param name='activityId'>
        /// Use this parameter for if you need to relate your request
        /// activities with Microsoft News API performance monitoring
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
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetNewsMarketsWithHttpMessagesAsync(string apikey, string ocid, string filter = default(string), string activityId = default(string), int? top = default(int?), string select = default(string), string ids = default(string), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get available interests.
        /// </summary>
        /// <param name='apikey'>
        /// Security parameter : apikey
        /// </param>
        /// <param name='ocid'>
        /// Security parameter : ocid
        /// </param>
        /// <param name='market'>
        /// The market.
        /// </param>
        /// <param name='user'>
        /// The user ID of who is making the request, needs to be
        /// authenticated.
        /// </param>
        /// <param name='activityId'>
        /// Use this parameter for if you need to relate your request
        /// activities with Microsoft News API performance monitoring
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
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetNewsTopicsWithHttpMessagesAsync(string apikey, string ocid, string market = default(string), string user = default(string), string activityId = default(string), int? top = default(int?), string select = default(string), string ids = default(string), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
