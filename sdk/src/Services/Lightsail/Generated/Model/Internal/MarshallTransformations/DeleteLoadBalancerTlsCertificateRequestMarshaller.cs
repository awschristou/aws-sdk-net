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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteLoadBalancerTlsCertificate Request Marshaller
    /// </summary>       
    public class DeleteLoadBalancerTlsCertificateRequestMarshaller : IMarshaller<IRequest, DeleteLoadBalancerTlsCertificateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteLoadBalancerTlsCertificateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteLoadBalancerTlsCertificateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lightsail");
            string target = "Lightsail_20161128.DeleteLoadBalancerTlsCertificate";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCertificateName())
                {
                    context.Writer.WritePropertyName("certificateName");
                    context.Writer.Write(publicRequest.CertificateName);
                }

                if(publicRequest.IsSetForce())
                {
                    context.Writer.WritePropertyName("force");
                    context.Writer.Write(publicRequest.Force);
                }

                if(publicRequest.IsSetLoadBalancerName())
                {
                    context.Writer.WritePropertyName("loadBalancerName");
                    context.Writer.Write(publicRequest.LoadBalancerName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DeleteLoadBalancerTlsCertificateRequestMarshaller _instance = new DeleteLoadBalancerTlsCertificateRequestMarshaller();        

        internal static DeleteLoadBalancerTlsCertificateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteLoadBalancerTlsCertificateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}