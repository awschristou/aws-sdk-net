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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the MigrateWorkspace operation.
    /// Migrates a WorkSpace from one operating system or bundle type to another, while retaining
    /// the data on the user volume.
    /// 
    ///  
    /// <para>
    /// The migration process recreates the WorkSpace by using a new root volume from the
    /// target bundle image and the user volume from the last available snapshot of the original
    /// WorkSpace. During migration, the original <code>D:\Users\%USERNAME%</code> user profile
    /// folder is renamed to <code>D:\Users\%USERNAME%MMddyyTHHmmss%.NotMigrated</code>. A
    /// new <code>D:\Users\%USERNAME%\</code> folder is generated by the new OS. Certain files
    /// in the old user profile are moved to the new user profile.
    /// </para>
    ///  
    /// <para>
    /// For available migration scenarios, details about what happens during migration, and
    /// best practices, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/migrate-workspaces.html">Migrate
    /// a WorkSpace</a>.
    /// </para>
    /// </summary>
    public partial class MigrateWorkspaceRequest : AmazonWorkSpacesRequest
    {
        private string _bundleId;
        private string _sourceWorkspaceId;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The identifier of the target bundle type to migrate the WorkSpace to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceWorkspaceId. 
        /// <para>
        /// The identifier of the WorkSpace to migrate from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceWorkspaceId
        {
            get { return this._sourceWorkspaceId; }
            set { this._sourceWorkspaceId = value; }
        }

        // Check to see if SourceWorkspaceId property is set
        internal bool IsSetSourceWorkspaceId()
        {
            return this._sourceWorkspaceId != null;
        }

    }
}