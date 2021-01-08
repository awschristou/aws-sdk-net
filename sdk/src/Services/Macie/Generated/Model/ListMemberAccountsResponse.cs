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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie.Model
{
    /// <summary>
    /// This is the response object from the ListMemberAccounts operation.
    /// </summary>
    public partial class ListMemberAccountsResponse : AmazonWebServiceResponse
    {
        private List<MemberAccount> _memberAccounts = new List<MemberAccount>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MemberAccounts. 
        /// <para>
        /// A list of the Amazon Macie Classic member accounts returned by the action. The current
        /// master account is also included in this list. 
        /// </para>
        /// </summary>
        public List<MemberAccount> MemberAccounts
        {
            get { return this._memberAccounts; }
            set { this._memberAccounts = value; }
        }

        // Check to see if MemberAccounts property is set
        internal bool IsSetMemberAccounts()
        {
            return this._memberAccounts != null && this._memberAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When a response is generated, if there is more data to be listed, this parameter is
        /// present in the response and contains the value to use for the nextToken parameter
        /// in a subsequent pagination request. If there is no more data to be listed, this parameter
        /// is set to null. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
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