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
    /// The output for the <a>DescribeConfigurationRecorders</a> action.
    /// </summary>
    public partial class DescribeConfigurationRecordersResponse : AmazonWebServiceResponse
    {
        private List<ConfigurationRecorder> _configurationRecorders = new List<ConfigurationRecorder>();

        /// <summary>
        /// Gets and sets the property ConfigurationRecorders. 
        /// <para>
        /// A list that contains the descriptions of the specified configuration recorders.
        /// </para>
        /// </summary>
        public List<ConfigurationRecorder> ConfigurationRecorders
        {
            get { return this._configurationRecorders; }
            set { this._configurationRecorders = value; }
        }

        // Check to see if ConfigurationRecorders property is set
        internal bool IsSetConfigurationRecorders()
        {
            return this._configurationRecorders != null && this._configurationRecorders.Count > 0; 
        }

    }
}