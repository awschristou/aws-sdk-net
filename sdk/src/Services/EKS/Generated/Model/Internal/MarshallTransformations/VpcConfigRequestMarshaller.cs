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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EKS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VpcConfigRequest Marshaller
    /// </summary>       
    public class VpcConfigRequestMarshaller : IRequestMarshaller<VpcConfigRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VpcConfigRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEndpointPrivateAccess())
            {
                context.Writer.WritePropertyName("endpointPrivateAccess");
                context.Writer.Write(requestObject.EndpointPrivateAccess);
            }

            if(requestObject.IsSetEndpointPublicAccess())
            {
                context.Writer.WritePropertyName("endpointPublicAccess");
                context.Writer.Write(requestObject.EndpointPublicAccess);
            }

            if(requestObject.IsSetPublicAccessCidrs())
            {
                context.Writer.WritePropertyName("publicAccessCidrs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPublicAccessCidrsListValue in requestObject.PublicAccessCidrs)
                {
                        context.Writer.Write(requestObjectPublicAccessCidrsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSecurityGroupIds())
            {
                context.Writer.WritePropertyName("securityGroupIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecurityGroupIdsListValue in requestObject.SecurityGroupIds)
                {
                        context.Writer.Write(requestObjectSecurityGroupIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSubnetIds())
            {
                context.Writer.WritePropertyName("subnetIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSubnetIdsListValue in requestObject.SubnetIds)
                {
                        context.Writer.Write(requestObjectSubnetIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static VpcConfigRequestMarshaller Instance = new VpcConfigRequestMarshaller();

    }
}