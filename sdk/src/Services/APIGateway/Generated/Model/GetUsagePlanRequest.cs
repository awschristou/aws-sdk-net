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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetUsagePlan operation.
    /// Gets a usage plan of a given plan identifier.
    /// </summary>
    public partial class GetUsagePlanRequest : AmazonAPIGatewayRequest
    {
        private string _usagePlanId;

        /// <summary>
        /// Gets and sets the property UsagePlanId. 
        /// <para>
        /// [Required] The identifier of the <a>UsagePlan</a> resource to be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UsagePlanId
        {
            get { return this._usagePlanId; }
            set { this._usagePlanId = value; }
        }

        // Check to see if UsagePlanId property is set
        internal bool IsSetUsagePlanId()
        {
            return this._usagePlanId != null;
        }

    }
}