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
 * Do not modify this file. This file is generated from the kinesis-video-signaling-2019-12-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisVideoSignalingChannels.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisVideoSignalingChannels.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendAlexaOfferToMaster Request Marshaller
    /// </summary>       
    public class SendAlexaOfferToMasterRequestMarshaller : IMarshaller<IRequest, SendAlexaOfferToMasterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendAlexaOfferToMasterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendAlexaOfferToMasterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KinesisVideoSignalingChannels");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-04";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/send-alexa-offer-to-master";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetChannelARN())
                {
                    context.Writer.WritePropertyName("ChannelARN");
                    context.Writer.Write(publicRequest.ChannelARN);
                }

                if(publicRequest.IsSetMessagePayload())
                {
                    context.Writer.WritePropertyName("MessagePayload");
                    context.Writer.Write(publicRequest.MessagePayload);
                }

                if(publicRequest.IsSetSenderClientId())
                {
                    context.Writer.WritePropertyName("SenderClientId");
                    context.Writer.Write(publicRequest.SenderClientId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SendAlexaOfferToMasterRequestMarshaller _instance = new SendAlexaOfferToMasterRequestMarshaller();        

        internal static SendAlexaOfferToMasterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendAlexaOfferToMasterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}