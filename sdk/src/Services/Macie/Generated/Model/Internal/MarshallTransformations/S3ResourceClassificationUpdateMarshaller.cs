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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Macie.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3ResourceClassificationUpdate Marshaller
    /// </summary>       
    public class S3ResourceClassificationUpdateMarshaller : IRequestMarshaller<S3ResourceClassificationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3ResourceClassificationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBucketName())
            {
                context.Writer.WritePropertyName("bucketName");
                context.Writer.Write(requestObject.BucketName);
            }

            if(requestObject.IsSetClassificationTypeUpdate())
            {
                context.Writer.WritePropertyName("classificationTypeUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = ClassificationTypeUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.ClassificationTypeUpdate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPrefix())
            {
                context.Writer.WritePropertyName("prefix");
                context.Writer.Write(requestObject.Prefix);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static S3ResourceClassificationUpdateMarshaller Instance = new S3ResourceClassificationUpdateMarshaller();

    }
}