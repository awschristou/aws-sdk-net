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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DLM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DLM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLifecyclePolicy Request Marshaller
    /// </summary>       
    public class UpdateLifecyclePolicyRequestMarshaller : IMarshaller<IRequest, UpdateLifecyclePolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLifecyclePolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLifecyclePolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DLM");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-01-12";            
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetPolicyId())
                throw new AmazonDLMException("Request object does not have required field PolicyId set");
            request.AddPathResource("{policyId}", StringUtils.FromString(publicRequest.PolicyId));
            request.ResourcePath = "/policies/{policyId}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetExecutionRoleArn())
                {
                    context.Writer.WritePropertyName("ExecutionRoleArn");
                    context.Writer.Write(publicRequest.ExecutionRoleArn);
                }

                if(publicRequest.IsSetPolicyDetails())
                {
                    context.Writer.WritePropertyName("PolicyDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = PolicyDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PolicyDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetState())
                {
                    context.Writer.WritePropertyName("State");
                    context.Writer.Write(publicRequest.State);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateLifecyclePolicyRequestMarshaller _instance = new UpdateLifecyclePolicyRequestMarshaller();        

        internal static UpdateLifecyclePolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLifecyclePolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}