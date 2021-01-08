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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// This is the response object from the AddCustomRoutingEndpoints operation.
    /// </summary>
    public partial class AddCustomRoutingEndpointsResponse : AmazonWebServiceResponse
    {
        private List<CustomRoutingEndpointDescription> _endpointDescriptions = new List<CustomRoutingEndpointDescription>();
        private string _endpointGroupArn;

        /// <summary>
        /// Gets and sets the property EndpointDescriptions. 
        /// <para>
        /// The endpoint objects added to the custom routing accelerator.
        /// </para>
        /// </summary>
        public List<CustomRoutingEndpointDescription> EndpointDescriptions
        {
            get { return this._endpointDescriptions; }
            set { this._endpointDescriptions = value; }
        }

        // Check to see if EndpointDescriptions property is set
        internal bool IsSetEndpointDescriptions()
        {
            return this._endpointDescriptions != null && this._endpointDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndpointGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint group for the custom routing endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string EndpointGroupArn
        {
            get { return this._endpointGroupArn; }
            set { this._endpointGroupArn = value; }
        }

        // Check to see if EndpointGroupArn property is set
        internal bool IsSetEndpointGroupArn()
        {
            return this._endpointGroupArn != null;
        }

    }
}