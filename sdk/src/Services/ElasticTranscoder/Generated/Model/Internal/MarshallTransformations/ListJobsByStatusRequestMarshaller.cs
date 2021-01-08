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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListJobsByStatus Request Marshaller
    /// </summary>       
    public class ListJobsByStatusRequestMarshaller : IMarshaller<IRequest, ListJobsByStatusRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListJobsByStatusRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListJobsByStatusRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticTranscoder");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-09-25";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetStatus())
                throw new AmazonElasticTranscoderException("Request object does not have required field Status set");
            request.AddPathResource("{Status}", StringUtils.FromString(publicRequest.Status));
            
            if (publicRequest.IsSetAscending())
                request.Parameters.Add("Ascending", StringUtils.FromString(publicRequest.Ascending));
            
            if (publicRequest.IsSetPageToken())
                request.Parameters.Add("PageToken", StringUtils.FromString(publicRequest.PageToken));
            request.ResourcePath = "/2012-09-25/jobsByStatus/{Status}";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static ListJobsByStatusRequestMarshaller _instance = new ListJobsByStatusRequestMarshaller();        

        internal static ListJobsByStatusRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListJobsByStatusRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}