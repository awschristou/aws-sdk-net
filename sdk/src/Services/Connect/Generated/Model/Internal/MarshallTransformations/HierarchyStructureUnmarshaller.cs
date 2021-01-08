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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HierarchyStructure Object
    /// </summary>  
    public class HierarchyStructureUnmarshaller : IUnmarshaller<HierarchyStructure, XmlUnmarshallerContext>, IUnmarshaller<HierarchyStructure, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        HierarchyStructure IUnmarshaller<HierarchyStructure, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public HierarchyStructure Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            HierarchyStructure unmarshalledObject = new HierarchyStructure();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("LevelFive", targetDepth))
                {
                    var unmarshaller = HierarchyLevelUnmarshaller.Instance;
                    unmarshalledObject.LevelFive = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LevelFour", targetDepth))
                {
                    var unmarshaller = HierarchyLevelUnmarshaller.Instance;
                    unmarshalledObject.LevelFour = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LevelOne", targetDepth))
                {
                    var unmarshaller = HierarchyLevelUnmarshaller.Instance;
                    unmarshalledObject.LevelOne = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LevelThree", targetDepth))
                {
                    var unmarshaller = HierarchyLevelUnmarshaller.Instance;
                    unmarshalledObject.LevelThree = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LevelTwo", targetDepth))
                {
                    var unmarshaller = HierarchyLevelUnmarshaller.Instance;
                    unmarshalledObject.LevelTwo = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static HierarchyStructureUnmarshaller _instance = new HierarchyStructureUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HierarchyStructureUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}