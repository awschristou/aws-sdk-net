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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// This is the response object from the GetResolverQueryLogConfig operation.
    /// </summary>
    public partial class GetResolverQueryLogConfigResponse : AmazonWebServiceResponse
    {
        private ResolverQueryLogConfig _resolverQueryLogConfig;

        /// <summary>
        /// Gets and sets the property ResolverQueryLogConfig. 
        /// <para>
        /// Information about the Resolver query logging configuration that you specified in a
        /// <code>GetQueryLogConfig</code> request.
        /// </para>
        /// </summary>
        public ResolverQueryLogConfig ResolverQueryLogConfig
        {
            get { return this._resolverQueryLogConfig; }
            set { this._resolverQueryLogConfig = value; }
        }

        // Check to see if ResolverQueryLogConfig property is set
        internal bool IsSetResolverQueryLogConfig()
        {
            return this._resolverQueryLogConfig != null;
        }

    }
}