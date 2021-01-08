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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetContainerServicePowers operation.
    /// </summary>
    public partial class GetContainerServicePowersResponse : AmazonWebServiceResponse
    {
        private List<ContainerServicePower> _powers = new List<ContainerServicePower>();

        /// <summary>
        /// Gets and sets the property Powers. 
        /// <para>
        /// An array of objects that describe the powers that can be specified for a container
        /// service.
        /// </para>
        /// </summary>
        public List<ContainerServicePower> Powers
        {
            get { return this._powers; }
            set { this._powers = value; }
        }

        // Check to see if Powers property is set
        internal bool IsSetPowers()
        {
            return this._powers != null && this._powers.Count > 0; 
        }

    }
}