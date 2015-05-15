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
 * Do not modify this file. This file is generated from the ec2-2015-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CancelReservedInstancesListing Request Marshaller
    /// </summary>       
    public class CancelReservedInstancesListingRequestMarshaller : IMarshaller<IRequest, CancelReservedInstancesListingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CancelReservedInstancesListingRequest)input);
        }
    
        public IRequest Marshall(CancelReservedInstancesListingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CancelReservedInstancesListing");
            request.Parameters.Add("Version", "2015-04-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetReservedInstancesListingId())
                {
                    request.Parameters.Add("ReservedInstancesListingId", StringUtils.FromString(publicRequest.ReservedInstancesListingId));
                }
            }
            return request;
        }
    }
}