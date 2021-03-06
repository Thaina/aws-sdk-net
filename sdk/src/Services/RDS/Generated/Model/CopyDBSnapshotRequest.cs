/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CopyDBSnapshot operation.
    /// Copies the specified DB snapshot. The source DB snapshot must be in the "available"
    /// state. 
    /// 
    ///  
    /// <para>
    /// If you are copying from a shared manual DB snapshot, the <code>SourceDBSnapshotIdentifier</code>
    /// must be the ARN of the shared DB snapshot.
    /// </para>
    /// </summary>
    public partial class CopyDBSnapshotRequest : AmazonRDSRequest
    {
        private bool? _copyTags;
        private string _kmsKeyId;
        private string _sourceDBSnapshotIdentifier;
        private List<Tag> _tags = new List<Tag>();
        private string _targetDBSnapshotIdentifier;

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// True to copy all tags from the source DB snapshot to the target DB snapshot; otherwise
        /// false. The default is false.
        /// </para>
        /// </summary>
        public bool CopyTags
        {
            get { return this._copyTags.GetValueOrDefault(); }
            set { this._copyTags = value; }
        }

        // Check to see if CopyTags property is set
        internal bool IsSetCopyTags()
        {
            return this._copyTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The AWS Key Management Service (AWS KMS) key identifier for an encrypted DB snapshot.
        /// The KMS key identifier is the Amazon Resource Name (ARN) or the KMS key alias for
        /// the KMS encryption key. 
        /// </para>
        ///  
        /// <para>
        /// If you copy an unencrypted DB snapshot and specify a value for the <code>KmsKeyId</code>
        /// parameter, Amazon RDS encrypts the target DB snapshot using the specified KMS encryption
        /// key.
        /// </para>
        ///  
        /// <para>
        /// If you copy an encrypted DB snapshot from your AWS account, you can specify a value
        /// for <code>KmsKeyId</code> to encrypt the copy with a new KMS encryption key. If you
        /// don't specify a value for <code>KmsKeyId</code> then the copy of the DB snapshot is
        /// encrypted with the same KMS key as the source DB snapshot. 
        /// </para>
        ///  
        /// <para>
        /// If you copy an encrypted DB snapshot that is shared from another AWS account, then
        /// you must specify a value for <code>KmsKeyId</code>.
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
        /// Gets and sets the property SourceDBSnapshotIdentifier. 
        /// <para>
        ///  The identifier for the source DB snapshot. 
        /// </para>
        ///  
        /// <para>
        /// If you are copying from a shared manual DB snapshot, this must be the ARN of the shared
        /// DB snapshot.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must specify a valid system snapshot in the "available" state.</li> <li>If
        /// the source snapshot is in the same region as the copy, specify a valid DB snapshot
        /// identifier.</li> <li>If the source snapshot is in a different region than the copy,
        /// specify a valid DB snapshot ARN. For more information, go to <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_CopySnapshot.html">
        /// Copying a DB Snapshot</a>.</li> </ul> 
        /// <para>
        /// Example: <code>rds:mydb-2012-04-02-00-01</code>
        /// </para>
        ///  
        /// <para>
        /// Example: <code>arn:aws:rds:rr-regn-1:123456789012:snapshot:mysql-instance1-snapshot-20130805</code>
        /// </para>
        /// </summary>
        public string SourceDBSnapshotIdentifier
        {
            get { return this._sourceDBSnapshotIdentifier; }
            set { this._sourceDBSnapshotIdentifier = value; }
        }

        // Check to see if SourceDBSnapshotIdentifier property is set
        internal bool IsSetSourceDBSnapshotIdentifier()
        {
            return this._sourceDBSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetDBSnapshotIdentifier. 
        /// <para>
        ///  The identifier for the copied snapshot. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Cannot be null, empty, or blank</li> <li>Must contain from 1 to 255 alphanumeric
        /// characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end
        /// with a hyphen or contain two consecutive hyphens</li> </ul> 
        /// <para>
        /// Example: <code>my-db-snapshot</code>
        /// </para>
        /// </summary>
        public string TargetDBSnapshotIdentifier
        {
            get { return this._targetDBSnapshotIdentifier; }
            set { this._targetDBSnapshotIdentifier = value; }
        }

        // Check to see if TargetDBSnapshotIdentifier property is set
        internal bool IsSetTargetDBSnapshotIdentifier()
        {
            return this._targetDBSnapshotIdentifier != null;
        }

    }
}