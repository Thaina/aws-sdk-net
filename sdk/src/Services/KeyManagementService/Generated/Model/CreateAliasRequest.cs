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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAlias operation.
    /// Creates a display name for a customer master key. An alias can be used to identify
    /// a key and should be unique. The console enforces a one-to-one mapping between the
    /// alias and a key. An alias name can contain only alphanumeric characters, forward slashes
    /// (/), underscores (_), and dashes (-). An alias must start with the word "alias" followed
    /// by a forward slash (alias/). An alias that begins with "aws" after the forward slash
    /// (alias/aws...) is reserved by Amazon Web Services (AWS).
    /// 
    ///  
    /// <para>
    /// The alias and the key it is mapped to must be in the same AWS account and the same
    /// region.
    /// </para>
    ///  
    /// <para>
    /// To map an alias to a different key, call <a>UpdateAlias</a>.
    /// </para>
    /// </summary>
    public partial class CreateAliasRequest : AmazonKeyManagementServiceRequest
    {
        private string _aliasName;
        private string _targetKeyId;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// String that contains the display name. The name must start with the word "alias" followed
        /// by a forward slash (alias/). Aliases that begin with "alias/AWS" are reserved.
        /// </para>
        /// </summary>
        public string AliasName
        {
            get { return this._aliasName; }
            set { this._aliasName = value; }
        }

        // Check to see if AliasName property is set
        internal bool IsSetAliasName()
        {
            return this._aliasName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetKeyId. 
        /// <para>
        /// An identifier of the key for which you are creating the alias. This value cannot be
        /// another alias but can be a globally unique identifier or a fully specified ARN to
        /// a key.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string TargetKeyId
        {
            get { return this._targetKeyId; }
            set { this._targetKeyId = value; }
        }

        // Check to see if TargetKeyId property is set
        internal bool IsSetTargetKeyId()
        {
            return this._targetKeyId != null;
        }

    }
}