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
    /// Container for the parameters to the DeleteDocumentationVersion operation.
    /// 
    /// </summary>
    public partial class DeleteDocumentationVersionRequest : AmazonAPIGatewayRequest
    {
        private string _documentationVersion;
        private string _restApiId;

        /// <summary>
        /// Gets and sets the property DocumentationVersion. 
        /// <para>
        /// [Required] The version identifier of a to-be-deleted documentation snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DocumentationVersion
        {
            get { return this._documentationVersion; }
            set { this._documentationVersion = value; }
        }

        // Check to see if DocumentationVersion property is set
        internal bool IsSetDocumentationVersion()
        {
            return this._documentationVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// [Required] The string identifier of the associated <a>RestApi</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RestApiId
        {
            get { return this._restApiId; }
            set { this._restApiId = value; }
        }

        // Check to see if RestApiId property is set
        internal bool IsSetRestApiId()
        {
            return this._restApiId != null;
        }

    }
}