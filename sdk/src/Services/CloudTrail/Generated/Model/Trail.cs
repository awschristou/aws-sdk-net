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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// The settings for a trail.
    /// </summary>
    public partial class Trail
    {
        private string _cloudWatchLogsLogGroupArn;
        private string _cloudWatchLogsRoleArn;
        private bool? _hasCustomEventSelectors;
        private bool? _hasInsightSelectors;
        private string _homeRegion;
        private bool? _includeGlobalServiceEvents;
        private bool? _isMultiRegionTrail;
        private bool? _isOrganizationTrail;
        private string _kmsKeyId;
        private bool? _logFileValidationEnabled;
        private string _name;
        private string _s3BucketName;
        private string _s3KeyPrefix;
        private string _snsTopicARN;
        private string _snsTopicName;
        private string _trailARN;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsLogGroupArn. 
        /// <para>
        /// Specifies an Amazon Resource Name (ARN), a unique identifier that represents the log
        /// group to which CloudTrail logs will be delivered.
        /// </para>
        /// </summary>
        public string CloudWatchLogsLogGroupArn
        {
            get { return this._cloudWatchLogsLogGroupArn; }
            set { this._cloudWatchLogsLogGroupArn = value; }
        }

        // Check to see if CloudWatchLogsLogGroupArn property is set
        internal bool IsSetCloudWatchLogsLogGroupArn()
        {
            return this._cloudWatchLogsLogGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLogsRoleArn. 
        /// <para>
        /// Specifies the role for the CloudWatch Logs endpoint to assume to write to a user's
        /// log group.
        /// </para>
        /// </summary>
        public string CloudWatchLogsRoleArn
        {
            get { return this._cloudWatchLogsRoleArn; }
            set { this._cloudWatchLogsRoleArn = value; }
        }

        // Check to see if CloudWatchLogsRoleArn property is set
        internal bool IsSetCloudWatchLogsRoleArn()
        {
            return this._cloudWatchLogsRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property HasCustomEventSelectors. 
        /// <para>
        /// Specifies if the trail has custom event selectors.
        /// </para>
        /// </summary>
        public bool HasCustomEventSelectors
        {
            get { return this._hasCustomEventSelectors.GetValueOrDefault(); }
            set { this._hasCustomEventSelectors = value; }
        }

        // Check to see if HasCustomEventSelectors property is set
        internal bool IsSetHasCustomEventSelectors()
        {
            return this._hasCustomEventSelectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HasInsightSelectors. 
        /// <para>
        /// Specifies whether a trail has insight types specified in an <code>InsightSelector</code>
        /// list.
        /// </para>
        /// </summary>
        public bool HasInsightSelectors
        {
            get { return this._hasInsightSelectors.GetValueOrDefault(); }
            set { this._hasInsightSelectors = value; }
        }

        // Check to see if HasInsightSelectors property is set
        internal bool IsSetHasInsightSelectors()
        {
            return this._hasInsightSelectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// The region in which the trail was created.
        /// </para>
        /// </summary>
        public string HomeRegion
        {
            get { return this._homeRegion; }
            set { this._homeRegion = value; }
        }

        // Check to see if HomeRegion property is set
        internal bool IsSetHomeRegion()
        {
            return this._homeRegion != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeGlobalServiceEvents. 
        /// <para>
        /// Set to <b>True</b> to include AWS API calls from AWS global services such as IAM.
        /// Otherwise, <b>False</b>.
        /// </para>
        /// </summary>
        public bool IncludeGlobalServiceEvents
        {
            get { return this._includeGlobalServiceEvents.GetValueOrDefault(); }
            set { this._includeGlobalServiceEvents = value; }
        }

        // Check to see if IncludeGlobalServiceEvents property is set
        internal bool IsSetIncludeGlobalServiceEvents()
        {
            return this._includeGlobalServiceEvents.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsMultiRegionTrail. 
        /// <para>
        /// Specifies whether the trail exists only in one region or exists in all regions.
        /// </para>
        /// </summary>
        public bool IsMultiRegionTrail
        {
            get { return this._isMultiRegionTrail.GetValueOrDefault(); }
            set { this._isMultiRegionTrail = value; }
        }

        // Check to see if IsMultiRegionTrail property is set
        internal bool IsSetIsMultiRegionTrail()
        {
            return this._isMultiRegionTrail.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsOrganizationTrail. 
        /// <para>
        /// Specifies whether the trail is an organization trail.
        /// </para>
        /// </summary>
        public bool IsOrganizationTrail
        {
            get { return this._isOrganizationTrail.GetValueOrDefault(); }
            set { this._isOrganizationTrail = value; }
        }

        // Check to see if IsOrganizationTrail property is set
        internal bool IsSetIsOrganizationTrail()
        {
            return this._isOrganizationTrail.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Specifies the KMS key ID that encrypts the logs delivered by CloudTrail. The value
        /// is a fully specified ARN to a KMS key in the format:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:kms:us-east-2:123456789012:key/12345678-1234-1234-1234-123456789012</code>
        /// 
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LogFileValidationEnabled. 
        /// <para>
        /// Specifies whether log file validation is enabled.
        /// </para>
        /// </summary>
        public bool LogFileValidationEnabled
        {
            get { return this._logFileValidationEnabled.GetValueOrDefault(); }
            set { this._logFileValidationEnabled = value; }
        }

        // Check to see if LogFileValidationEnabled property is set
        internal bool IsSetLogFileValidationEnabled()
        {
            return this._logFileValidationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the trail set by calling <a>CreateTrail</a>. The maximum length is 128 characters.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// Name of the Amazon S3 bucket into which CloudTrail delivers your trail files. See
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/create_trail_naming_policy.html">Amazon
        /// S3 Bucket Naming Requirements</a>.
        /// </para>
        /// </summary>
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// Specifies the Amazon S3 key prefix that comes after the name of the bucket you have
        /// designated for log file delivery. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-find-log-files.html">Finding
        /// Your CloudTrail Log Files</a>.The maximum length is 200 characters.
        /// </para>
        /// </summary>
        public string S3KeyPrefix
        {
            get { return this._s3KeyPrefix; }
            set { this._s3KeyPrefix = value; }
        }

        // Check to see if S3KeyPrefix property is set
        internal bool IsSetS3KeyPrefix()
        {
            return this._s3KeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicARN. 
        /// <para>
        /// Specifies the ARN of the Amazon SNS topic that CloudTrail uses to send notifications
        /// when log files are delivered. The format of a topic ARN is:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:sns:us-east-2:123456789012:MyTopic</code> 
        /// </para>
        /// </summary>
        public string SnsTopicARN
        {
            get { return this._snsTopicARN; }
            set { this._snsTopicARN = value; }
        }

        // Check to see if SnsTopicARN property is set
        internal bool IsSetSnsTopicARN()
        {
            return this._snsTopicARN != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicName. 
        /// <para>
        /// This field is no longer in use. Use SnsTopicARN.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated. Use SnsTopicARN.")]
        public string SnsTopicName
        {
            get { return this._snsTopicName; }
            set { this._snsTopicName = value; }
        }

        // Check to see if SnsTopicName property is set
        internal bool IsSetSnsTopicName()
        {
            return this._snsTopicName != null;
        }

        /// <summary>
        /// Gets and sets the property TrailARN. 
        /// <para>
        /// Specifies the ARN of the trail. The format of a trail ARN is:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</code> 
        /// </para>
        /// </summary>
        public string TrailARN
        {
            get { return this._trailARN; }
            set { this._trailARN = value; }
        }

        // Check to see if TrailARN property is set
        internal bool IsSetTrailARN()
        {
            return this._trailARN != null;
        }

    }
}