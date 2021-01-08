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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutConfigurationSetDeliveryOptions Request Marshaller
    /// </summary>       
    public class PutConfigurationSetDeliveryOptionsRequestMarshaller : IMarshaller<IRequest, PutConfigurationSetDeliveryOptionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutConfigurationSetDeliveryOptionsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutConfigurationSetDeliveryOptionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.Parameters.Add("Action", "PutConfigurationSetDeliveryOptions");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetConfigurationSetName())
                {
                    request.Parameters.Add("ConfigurationSetName", StringUtils.FromString(publicRequest.ConfigurationSetName));
                }
                if(publicRequest.IsSetDeliveryOptions())
                {
                    if(publicRequest.DeliveryOptions.IsSetTlsPolicy())
                    {
                        request.Parameters.Add("DeliveryOptions" + "." + "TlsPolicy", StringUtils.FromString(publicRequest.DeliveryOptions.TlsPolicy));
                    }
                }
            }
            return request;
        }
                    private static PutConfigurationSetDeliveryOptionsRequestMarshaller _instance = new PutConfigurationSetDeliveryOptionsRequestMarshaller();        

        internal static PutConfigurationSetDeliveryOptionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutConfigurationSetDeliveryOptionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}