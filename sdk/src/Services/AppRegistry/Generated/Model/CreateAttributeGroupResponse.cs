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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// This is the response object from the CreateAttributeGroup operation.
    /// </summary>
    public partial class CreateAttributeGroupResponse : AmazonWebServiceResponse
    {
        private AttributeGroup _attributeGroup;

        /// <summary>
        /// Gets and sets the property AttributeGroup. 
        /// <para>
        /// Information about the attribute group.
        /// </para>
        /// </summary>
        public AttributeGroup AttributeGroup
        {
            get { return this._attributeGroup; }
            set { this._attributeGroup = value; }
        }

        // Check to see if AttributeGroup property is set
        internal bool IsSetAttributeGroup()
        {
            return this._attributeGroup != null;
        }

    }
}