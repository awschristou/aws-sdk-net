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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.XRay.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.XRay.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ErrorRootCause Object
    /// </summary>  
    public class ErrorRootCauseUnmarshaller : IUnmarshaller<ErrorRootCause, XmlUnmarshallerContext>, IUnmarshaller<ErrorRootCause, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ErrorRootCause IUnmarshaller<ErrorRootCause, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ErrorRootCause Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ErrorRootCause unmarshalledObject = new ErrorRootCause();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ClientImpacting", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ClientImpacting = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Services", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ErrorRootCauseService, ErrorRootCauseServiceUnmarshaller>(ErrorRootCauseServiceUnmarshaller.Instance);
                    unmarshalledObject.Services = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ErrorRootCauseUnmarshaller _instance = new ErrorRootCauseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ErrorRootCauseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}