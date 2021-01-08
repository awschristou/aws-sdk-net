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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Specifies the attributes to add to your attribute-based access control (ABAC) configuration.
    /// </summary>
    public partial class InstanceAccessControlAttributeConfiguration
    {
        private List<AccessControlAttribute> _accessControlAttributes = new List<AccessControlAttribute>();

        /// <summary>
        /// Gets and sets the property AccessControlAttributes. 
        /// <para>
        /// Lists the attributes that are configured for ABAC in the specified AWS SSO instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<AccessControlAttribute> AccessControlAttributes
        {
            get { return this._accessControlAttributes; }
            set { this._accessControlAttributes = value; }
        }

        // Check to see if AccessControlAttributes property is set
        internal bool IsSetAccessControlAttributes()
        {
            return this._accessControlAttributes != null && this._accessControlAttributes.Count > 0; 
        }

    }
}