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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridge.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EventBridge.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutPartnerEventsRequestEntry Marshaller
    /// </summary>       
    public class PutPartnerEventsRequestEntryMarshaller : IRequestMarshaller<PutPartnerEventsRequestEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PutPartnerEventsRequestEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDetail())
            {
                context.Writer.WritePropertyName("Detail");
                context.Writer.Write(requestObject.Detail);
            }

            if(requestObject.IsSetDetailType())
            {
                context.Writer.WritePropertyName("DetailType");
                context.Writer.Write(requestObject.DetailType);
            }

            if(requestObject.IsSetResources())
            {
                context.Writer.WritePropertyName("Resources");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourcesListValue in requestObject.Resources)
                {
                        context.Writer.Write(requestObjectResourcesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSource())
            {
                context.Writer.WritePropertyName("Source");
                context.Writer.Write(requestObject.Source);
            }

            if(requestObject.IsSetTime())
            {
                context.Writer.WritePropertyName("Time");
                context.Writer.Write(requestObject.Time);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static PutPartnerEventsRequestEntryMarshaller Instance = new PutPartnerEventsRequestEntryMarshaller();

    }
}