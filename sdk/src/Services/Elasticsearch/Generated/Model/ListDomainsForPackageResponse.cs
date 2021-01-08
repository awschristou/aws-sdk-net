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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for response parameters to <code> <a>ListDomainsForPackage</a> </code>
    /// operation.
    /// </summary>
    public partial class ListDomainsForPackageResponse : AmazonWebServiceResponse
    {
        private List<DomainPackageDetails> _domainPackageDetailsList = new List<DomainPackageDetails>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DomainPackageDetailsList. 
        /// <para>
        /// List of <code>DomainPackageDetails</code> objects.
        /// </para>
        /// </summary>
        public List<DomainPackageDetails> DomainPackageDetailsList
        {
            get { return this._domainPackageDetailsList; }
            set { this._domainPackageDetailsList = value; }
        }

        // Check to see if DomainPackageDetailsList property is set
        internal bool IsSetDomainPackageDetailsList()
        {
            return this._domainPackageDetailsList != null && this._domainPackageDetailsList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}