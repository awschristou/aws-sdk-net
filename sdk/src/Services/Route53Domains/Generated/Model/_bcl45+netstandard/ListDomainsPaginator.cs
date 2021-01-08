#if !NETSTANDARD13
/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Base class for ListDomains paginators.
    /// </summary>
    internal sealed partial class ListDomainsPaginator : IPaginator<ListDomainsResponse>, IListDomainsPaginator
    {
        private readonly IAmazonRoute53Domains _client;
        private readonly ListDomainsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListDomainsResponse> Responses => new PaginatedResponse<ListDomainsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Domains
        /// </summary>
        public IPaginatedEnumerable<DomainSummary> Domains => 
            new PaginatedResultKeyResponse<ListDomainsResponse, DomainSummary>(this, (i) => i.Domains);

        internal ListDomainsPaginator(IAmazonRoute53Domains client, ListDomainsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListDomainsResponse> IPaginator<ListDomainsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListDomainsResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.ListDomains(_request);
                marker = response.NextPageMarker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListDomainsResponse> IPaginator<ListDomainsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListDomainsResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.ListDomainsAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.NextPageMarker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
    }
}
#endif