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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AlexaForBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AlexaForBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Device Object
    /// </summary>  
    public class DeviceUnmarshaller : IUnmarshaller<Device, XmlUnmarshallerContext>, IUnmarshaller<Device, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Device IUnmarshaller<Device, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Device Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Device unmarshalledObject = new Device();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DeviceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeviceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeviceSerialNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceSerialNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeviceStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeviceStatusInfo", targetDepth))
                {
                    var unmarshaller = DeviceStatusInfoUnmarshaller.Instance;
                    unmarshalledObject.DeviceStatusInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeviceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MacAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MacAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkProfileInfo", targetDepth))
                {
                    var unmarshaller = DeviceNetworkProfileInfoUnmarshaller.Instance;
                    unmarshalledObject.NetworkProfileInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoomArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoomArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SoftwareVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SoftwareVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DeviceUnmarshaller _instance = new DeviceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeviceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}