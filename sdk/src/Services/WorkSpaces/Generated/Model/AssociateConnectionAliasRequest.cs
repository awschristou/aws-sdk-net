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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateConnectionAlias operation.
    /// Associates the specified connection alias with the specified directory to enable cross-Region
    /// redirection. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
    /// Cross-Region Redirection for Amazon WorkSpaces</a>.
    /// 
    ///  <note> 
    /// <para>
    /// Before performing this operation, call <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeConnectionAliases.html">
    /// DescribeConnectionAliases</a> to make sure that the current state of the connection
    /// alias is <code>CREATED</code>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AssociateConnectionAliasRequest : AmazonWorkSpacesRequest
    {
        private string _aliasId;
        private string _resourceId;

        /// <summary>
        /// Gets and sets the property AliasId. 
        /// <para>
        /// The identifier of the connection alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=68)]
        public string AliasId
        {
            get { return this._aliasId; }
            set { this._aliasId = value; }
        }

        // Check to see if AliasId property is set
        internal bool IsSetAliasId()
        {
            return this._aliasId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the directory to associate the connection alias with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

    }
}