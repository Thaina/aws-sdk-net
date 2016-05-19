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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// This is the response object from the StartDataCollectionByAgentIds operation.
    /// </summary>
    public partial class StartDataCollectionByAgentIdsResponse : AmazonWebServiceResponse
    {
        private List<AgentConfigStatus> _agentsConfigStatus = new List<AgentConfigStatus>();

        /// <summary>
        /// Gets and sets the property AgentsConfigStatus. 
        /// <para>
        /// Information about agents that were instructed to start collecting data. Information
        /// includes the agent ID, a description of the operation performed, and whether or not
        /// the agent configuration was updated.
        /// </para>
        /// </summary>
        public List<AgentConfigStatus> AgentsConfigStatus
        {
            get { return this._agentsConfigStatus; }
            set { this._agentsConfigStatus = value; }
        }

        // Check to see if AgentsConfigStatus property is set
        internal bool IsSetAgentsConfigStatus()
        {
            return this._agentsConfigStatus != null && this._agentsConfigStatus.Count > 0; 
        }

    }
}