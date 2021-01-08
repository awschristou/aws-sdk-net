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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AuditManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AuditManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Scope Object
    /// </summary>  
    public class ScopeUnmarshaller : IUnmarshaller<Scope, XmlUnmarshallerContext>, IUnmarshaller<Scope, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Scope IUnmarshaller<Scope, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Scope Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Scope unmarshalledObject = new Scope();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("awsAccounts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AWSAccount, AWSAccountUnmarshaller>(AWSAccountUnmarshaller.Instance);
                    unmarshalledObject.AwsAccounts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("awsServices", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AWSService, AWSServiceUnmarshaller>(AWSServiceUnmarshaller.Instance);
                    unmarshalledObject.AwsServices = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ScopeUnmarshaller _instance = new ScopeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScopeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}