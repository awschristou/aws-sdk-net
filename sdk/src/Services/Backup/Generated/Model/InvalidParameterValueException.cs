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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Indicates that something is wrong with a parameter's value. For example, the value
    /// is out of range.
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class InvalidParameterValueException : AmazonBackupException
    {
        private string _code;
        private string _context;
        private string _type;

        /// <summary>
        /// Constructs a new InvalidParameterValueException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public InvalidParameterValueException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of InvalidParameterValueException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public InvalidParameterValueException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of InvalidParameterValueException
        /// </summary>
        /// <param name="innerException"></param>
        public InvalidParameterValueException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of InvalidParameterValueException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public InvalidParameterValueException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of InvalidParameterValueException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public InvalidParameterValueException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the InvalidParameterValueException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected InvalidParameterValueException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Code = (string)info.GetValue("Code", typeof(string));
            this.Context = (string)info.GetValue("Context", typeof(string));
            this.Type = (string)info.GetValue("Type", typeof(string));
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
#if BCL35
        [System.Security.Permissions.SecurityPermission(
            System.Security.Permissions.SecurityAction.LinkDemand,
            Flags = System.Security.Permissions.SecurityPermissionFlag.SerializationFormatter)]
#endif
        [System.Security.SecurityCritical]
        // These FxCop rules are giving false-positives for this method
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Code", this.Code);
            info.AddValue("Context", this.Context);
            info.AddValue("Type", this.Type);
        }
#endif

        /// <summary>
        /// Gets and sets the property Code.
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Context.
        /// </summary>
        public string Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}