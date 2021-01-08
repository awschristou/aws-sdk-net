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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Container for the parameters to the SendTaskHeartbeat operation.
    /// Used by activity workers and task states using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-wait-token">callback</a>
    /// pattern to report to Step Functions that the task represented by the specified <code>taskToken</code>
    /// is still making progress. This action resets the <code>Heartbeat</code> clock. The
    /// <code>Heartbeat</code> threshold is specified in the state machine's Amazon States
    /// Language definition (<code>HeartbeatSeconds</code>). This action does not in itself
    /// create an event in the execution history. However, if the task times out, the execution
    /// history contains an <code>ActivityTimedOut</code> entry for activities, or a <code>TaskTimedOut</code>
    /// entry for for tasks using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-sync">job
    /// run</a> or <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-wait-token">callback</a>
    /// pattern.
    /// 
    ///  <note> 
    /// <para>
    /// The <code>Timeout</code> of a task, defined in the state machine's Amazon States Language
    /// definition, is its maximum allowed duration, regardless of the number of <a>SendTaskHeartbeat</a>
    /// requests received. Use <code>HeartbeatSeconds</code> to configure the timeout interval
    /// for heartbeats.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SendTaskHeartbeatRequest : AmazonStepFunctionsRequest
    {
        private string _taskToken;

        /// <summary>
        /// Gets and sets the property TaskToken. 
        /// <para>
        /// The token that represents this task. Task tokens are generated by Step Functions when
        /// tasks are assigned to a worker, or in the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/input-output-contextobject.html">context
        /// object</a> when a workflow enters a task state. See <a>GetActivityTaskOutput$taskToken</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string TaskToken
        {
            get { return this._taskToken; }
            set { this._taskToken = value; }
        }

        // Check to see if TaskToken property is set
        internal bool IsSetTaskToken()
        {
            return this._taskToken != null;
        }

    }
}