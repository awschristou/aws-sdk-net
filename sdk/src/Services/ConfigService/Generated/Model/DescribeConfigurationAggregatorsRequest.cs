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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConfigurationAggregators operation.
    /// Returns the details of one or more configuration aggregators. If the configuration
    /// aggregator is not specified, this action returns the details for all the configuration
    /// aggregators associated with the account.
    /// </summary>
    public partial class DescribeConfigurationAggregatorsRequest : AmazonConfigServiceRequest
    {
        private List<string> _configurationAggregatorNames = new List<string>();
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConfigurationAggregatorNames. 
        /// <para>
        /// The name of the configuration aggregators.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> ConfigurationAggregatorNames
        {
            get { return this._configurationAggregatorNames; }
            set { this._configurationAggregatorNames = value; }
        }

        // Check to see if ConfigurationAggregatorNames property is set
        internal bool IsSetConfigurationAggregatorNames()
        {
            return this._configurationAggregatorNames != null && this._configurationAggregatorNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of configuration aggregators returned on each page. The default
        /// is maximum. If you specify 0, AWS Config uses the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> string returned on a previous page that you use to get
        /// the next page of results in a paginated response.
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

    }
}