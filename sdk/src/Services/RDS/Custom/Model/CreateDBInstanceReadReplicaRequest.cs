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

using Amazon.RDS.Internal;

namespace Amazon.RDS.Model
{
    public partial class CreateDBInstanceReadReplicaRequest : AmazonRDSRequest, IPreSignedUrlRequest
    {
        private string _sourceRegion;

        /// <summary>
        /// The SourceRegion for generating the PreSignedUrl property.
        ///
        /// If SourceRegion is set and the PreSignedUrl property is not,
        /// then PreSignedUrl will be automatically generated by the client.
        /// </summary>
        public string SourceRegion
        {
            get
            {
                return _sourceRegion;
            }
            set
            {
                _sourceRegion = value;
            }
        }
    }
}