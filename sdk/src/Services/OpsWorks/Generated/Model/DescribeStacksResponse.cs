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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeStacks</code> request.
    /// </summary>
    public partial class DescribeStacksResponse : AmazonWebServiceResponse
    {
        private List<Stack> _stacks = new List<Stack>();

        /// <summary>
        /// Gets and sets the property Stacks. 
        /// <para>
        /// An array of <code>Stack</code> objects that describe the stacks.
        /// </para>
        /// </summary>
        public List<Stack> Stacks
        {
            get { return this._stacks; }
            set { this._stacks = value; }
        }

        // Check to see if Stacks property is set
        internal bool IsSetStacks()
        {
            return this._stacks != null && this._stacks.Count > 0; 
        }

    }
}