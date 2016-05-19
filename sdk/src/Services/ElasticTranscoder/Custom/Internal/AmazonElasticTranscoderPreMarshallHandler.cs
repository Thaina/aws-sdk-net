﻿/*
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

using System;
using System.Globalization;
using Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticTranscoder.Internal
{
    /// <summary>
    /// Custom pipeline handler
    /// </summary>
    public class AmazonElasticTranscoderPreMarshallHandler : PipelineHandler
    {
        /// <summary>
        /// Construct instance of AmazonElasticTranscoderPreMarshallHandler
        /// </summary>
        public AmazonElasticTranscoderPreMarshallHandler()
        {
        }

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            base.InvokeSync(executionContext);
        }
#if AWS_ASYNC_API 

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            return base.InvokeAsync<T>(executionContext);                        
        }

#elif AWS_APM_API

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>IAsyncResult which represent an async operation.</returns>
        public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            PreInvoke(ExecutionContext.CreateFromAsyncContext(executionContext));
            return base.InvokeAsync(executionContext);
        }
#endif
        /// <summary>
        /// Logic to be executed before request marshalling.
        /// </summary>        
        static void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.OriginalRequest;
            var config = executionContext.RequestContext.ClientConfig;

            var createPipelineRequest = request as CreatePipelineRequest;
            if (createPipelineRequest != null)
            {
                if (createPipelineRequest.Notifications != null)
                {
                    var notifications = createPipelineRequest.Notifications;

                    if (notifications.Completed == null)
                        notifications.Completed = string.Empty;

                    if (notifications.Error == null)
                        notifications.Error = string.Empty;

                    if (notifications.Progressing == null)
                        notifications.Progressing = string.Empty;

                    if (notifications.Warning == null)
                        notifications.Warning = string.Empty;
                }
            }
        }
    }
}
