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
    /// This is the response object from the DescribeWorkspaceImagePermissions operation.
    /// </summary>
    public partial class DescribeWorkspaceImagePermissionsResponse : AmazonWebServiceResponse
    {
        private string _imageId;
        private List<ImagePermission> _imagePermissions = new List<ImagePermission>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The identifier of the image.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property ImagePermissions. 
        /// <para>
        /// The identifiers of the AWS accounts that the image has been shared with.
        /// </para>
        /// </summary>
        public List<ImagePermission> ImagePermissions
        {
            get { return this._imagePermissions; }
            set { this._imagePermissions = value; }
        }

        // Check to see if ImagePermissions property is set
        internal bool IsSetImagePermissions()
        {
            return this._imagePermissions != null && this._imagePermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next set of results, or null if no more results are
        /// available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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