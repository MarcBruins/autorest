// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is

namespace Fixtures.Azure.AcceptanceTestsAzureSpecials
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ApiVersionDefaultOperations operations.
    /// </summary>
    public partial interface IApiVersionDefaultOperations
    {
        /// <summary>
        /// GET method with api-version modeled in global settings.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> GetMethodGlobalValidWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// GET method with api-version modeled in global settings.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> GetMethodGlobalNotProvidedValidWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// GET method with api-version modeled in global settings.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> GetPathGlobalValidWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// GET method with api-version modeled in global settings.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> GetSwaggerGlobalValidWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}