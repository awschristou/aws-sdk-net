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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeImages operation.
    /// Returns metadata about the images in a repository in a public registry.
    /// 
    ///  <note> 
    /// <para>
    /// Beginning with Docker version 1.9, the Docker client compresses image layers before
    /// pushing them to a V2 Docker registry. The output of the <code>docker images</code>
    /// command shows the uncompressed image size, so it may return a larger image size than
    /// the image sizes returned by <a>DescribeImages</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeImagesRequest : AmazonECRPublicRequest
    {
        private List<ImageIdentifier> _imageIds = new List<ImageIdentifier>();
        private int? _maxResults;
        private string _nextToken;
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property ImageIds. 
        /// <para>
        /// The list of image IDs for the requested repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ImageIdentifier> ImageIds
        {
            get { return this._imageIds; }
            set { this._imageIds = value; }
        }

        // Check to see if ImageIds property is set
        internal bool IsSetImageIds()
        {
            return this._imageIds != null && this._imageIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of repository results returned by <code>DescribeImages</code> in
        /// paginated output. When this parameter is used, <code>DescribeImages</code> only returns
        /// <code>maxResults</code> results in a single page along with a <code>nextToken</code>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <code>DescribeImages</code> request with the returned <code>nextToken</code>
        /// value. This value can be between 1 and 1000. If this parameter is not used, then <code>DescribeImages</code>
        /// returns up to 100 results and a <code>nextToken</code> value, if applicable. This
        /// option cannot be used when you specify images with <code>imageIds</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value returned from a previous paginated <code>DescribeImages</code>
        /// request where <code>maxResults</code> was used and the results exceeded the value
        /// of that parameter. Pagination continues from the end of the previous results that
        /// returned the <code>nextToken</code> value. This value is <code>null</code> when there
        /// are no more results to return. This option cannot be used when you specify images
        /// with <code>imageIds</code>.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The AWS account ID associated with the public registry that contains the repository
        /// in which to describe images. If you do not specify a registry, the default public
        /// registry is assumed.
        /// </para>
        /// </summary>
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository that contains the images to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=205)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}