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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the ListBuilds operation.
    /// Retrieves build records for all builds associated with an AWS account. You can filter
    /// the result set by build status. Use the pagination parameters to retrieve results
    /// in a set of sequential pages. 
    /// 
    ///  <note>
    /// <para>
    /// Build records are not listed in any particular order.
    /// </para>
    /// </note>
    /// </summary>
    public partial class ListBuildsRequest : AmazonGameLiftRequest
    {
        private int? _limit;
        private string _nextToken;
        private BuildStatus _status;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Maximum number of results to return. You can use this parameter with <i>NextToken</i>
        /// to get results as a set of sequential pages.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token indicating the start of the next sequential page of results. Use the token that
        /// is returned with a previous call to this action. To specify the start of the result
        /// set, do not specify a value.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Build state to filter results on. Use this parameter to retrieve builds in a certain
        /// state. To retrieve all builds, leave this parameter empty. Possible build states include:
        /// <ul><li>INITIALIZED: A new build has been defined, but no files have been uploaded.
        /// You cannot create fleets for builds that are in this state. When a build is successfully
        /// created, the build state is set to this value. </li><li>READY: The game build has
        /// been successfully uploaded. You can now create new fleets for this build.</li><li>FAILED:
        /// The game build upload failed. You cannot create new fleets for this build. </li></ul>
        /// </para>
        /// </summary>
        public BuildStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}