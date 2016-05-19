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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.StorageGateway.Model;
using Amazon.StorageGateway.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.StorageGateway
{
    /// <summary>
    /// Implementation for accessing StorageGateway
    ///
    /// AWS Storage Gateway Service 
    /// <para>
    /// AWS Storage Gateway is the service that connects an on-premises software appliance
    /// with cloud-based storage to provide seamless and secure integration between an organization's
    /// on-premises IT environment and AWS's storage infrastructure. The service enables you
    /// to securely upload data to the AWS cloud for cost effective backup and rapid disaster
    /// recovery.
    /// </para>
    ///  
    /// <para>
    /// Use the following links to get started using the <i>AWS Storage Gateway Service API
    /// Reference</i>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayHTTPRequestsHeaders.html">AWS
    /// Storage Gateway Required Request Headers</a>: Describes the required headers that
    /// you must send with every POST request to AWS Storage Gateway.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewaySigningRequests.html">Signing
    /// Requests</a>: AWS Storage Gateway requires that you authenticate every request you
    /// send; this topic describes how sign such a request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/APIErrorResponses.html">Error
    /// Responses</a>: Provides reference information about AWS Storage Gateway errors.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPIOperations.html">Operations
    /// in AWS Storage Gateway</a>: Contains detailed descriptions of all AWS Storage Gateway
    /// operations, their request parameters, response elements, possible errors, and examples
    /// of requests and responses.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html">AWS
    /// Storage Gateway Regions and Endpoints</a>: Provides a list of each of the s and endpoints
    /// available for use with AWS Storage Gateway.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// AWS Storage Gateway resource IDs are in uppercase. When you use these resource IDs
    /// with the Amazon EC2 API, EC2 expects resource IDs in lowercase. You must change your
    /// resource ID to lowercase to use it with the EC2 API. For example, in Storage Gateway
    /// the ID for a volume might be <code>vol-1122AABB</code>. When you use this ID with
    /// the EC2 API, you must change it to <code>vol-1122aabb</code>. Otherwise, the EC2 API
    /// might not behave as expected.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// IDs for Storage Gateway volumes and Amazon EBS snapshots created from gateway volumes
    /// are changing to a longer format. Starting in December 2016, all new volumes and snapshots
    /// will be created with a 17-character string. Starting in April 2016, you will be able
    /// to use these longer IDs so you can test your systems with the new format. For more
    /// information, see <a href="https://aws.amazon.com/ec2/faqs/#longer-ids">Longer EC2
    /// and EBS Resource IDs</a>.
    /// </para>
    ///  
    /// <para>
    ///  For example, a volume ARN with the longer volume ID format will look like this:
    /// </para>
    ///  
    /// <para>
    ///  <code>arn:aws:storagegateway:us-west-2:111122223333:gateway/sgw-12A3456B/volume/vol-1122AABBCCDDEEFFG</code>.
    /// </para>
    ///  
    /// <para>
    /// A snapshot ID with the longer ID format will look like this: <code>snap-78e226633445566ee</code>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://forums.aws.amazon.com/ann.jspa?annID=3557">Announcement:
    /// Heads-up – Longer AWS Storage Gateway volume and snapshot IDs coming in 2016</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class AmazonStorageGatewayClient : AmazonServiceClient, IAmazonStorageGateway
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonStorageGatewayClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonStorageGatewayConfig()) { }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonStorageGatewayClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonStorageGatewayConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonStorageGatewayClient Configuration Object</param>
        public AmazonStorageGatewayClient(AmazonStorageGatewayConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonStorageGatewayClient(AWSCredentials credentials)
            : this(credentials, new AmazonStorageGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonStorageGatewayClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonStorageGatewayConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Credentials and an
        /// AmazonStorageGatewayClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonStorageGatewayClient Configuration Object</param>
        public AmazonStorageGatewayClient(AWSCredentials credentials, AmazonStorageGatewayConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonStorageGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonStorageGatewayConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonStorageGatewayClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonStorageGatewayClient Configuration Object</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonStorageGatewayConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonStorageGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonStorageGatewayConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonStorageGatewayClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonStorageGatewayClient Configuration Object</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonStorageGatewayConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  ActivateGateway

        /// <summary>
        /// Activates the gateway you previously deployed on your host. For more information,
        /// see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/GettingStartedActivateGateway-common.html">
        /// Activate the AWS Storage Gateway</a>. In the activation process, you specify information
        /// such as the you want to use for storing snapshots, the time zone for scheduled snapshots
        /// the gateway snapshot schedule window, an activation key, and a name for your gateway.
        /// The activation process also associates your gateway with your account; for more information,
        /// see <a>UpdateGatewayInformation</a>.
        /// 
        ///  <note>
        /// <para>
        /// You must turn on the gateway VM before you can activate your gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateGateway service method.</param>
        /// 
        /// <returns>The response from the ActivateGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public ActivateGatewayResponse ActivateGateway(ActivateGatewayRequest request)
        {
            var marshaller = new ActivateGatewayRequestMarshaller();
            var unmarshaller = ActivateGatewayResponseUnmarshaller.Instance;

            return Invoke<ActivateGatewayRequest,ActivateGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateGateway operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivateGateway
        ///         operation.</returns>
        public IAsyncResult BeginActivateGateway(ActivateGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ActivateGatewayRequestMarshaller();
            var unmarshaller = ActivateGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<ActivateGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ActivateGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateGateway.</param>
        /// 
        /// <returns>Returns a  ActivateGatewayResult from StorageGateway.</returns>
        public  ActivateGatewayResponse EndActivateGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<ActivateGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  AddCache

        /// <summary>
        /// Configures one or more gateway local disks as cache for a cached-volume gateway. This
        /// operation is supported only for the gateway-cached volume architecture (see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/StorageGatewayConcepts.html">Storage
        /// Gateway Concepts</a>).
        /// 
        ///  
        /// <para>
        /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add cache, and one or more disk IDs that you want to configure as cache.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddCache service method.</param>
        /// 
        /// <returns>The response from the AddCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public AddCacheResponse AddCache(AddCacheRequest request)
        {
            var marshaller = new AddCacheRequestMarshaller();
            var unmarshaller = AddCacheResponseUnmarshaller.Instance;

            return Invoke<AddCacheRequest,AddCacheResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCache operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddCache
        ///         operation.</returns>
        public IAsyncResult BeginAddCache(AddCacheRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AddCacheRequestMarshaller();
            var unmarshaller = AddCacheResponseUnmarshaller.Instance;

            return BeginInvoke<AddCacheRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddCache.</param>
        /// 
        /// <returns>Returns a  AddCacheResult from StorageGateway.</returns>
        public  AddCacheResponse EndAddCache(IAsyncResult asyncResult)
        {
            return EndInvoke<AddCacheResponse>(asyncResult);
        }

        #endregion
        
        #region  AddTagsToResource

        /// <summary>
        /// Adds one or more tags to the specified resource. You use tags to add metadata to resources,
        /// which you can use to categorize these resources. For example, you can categorize resources
        /// by purpose, owner, environment, or team. Each tag consists of a key and a value, which
        /// you define. You can add tags to the following AWS Storage Gateway resources:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Storage gateways of all types
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// Storage Volumes
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// Virtual Tapes
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can create a maximum of 10 tags for each resource. Virtual tapes and storage volumes
        /// that are recovered to a new gateway maintain their tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToResource
        ///         operation.</returns>
        public IAsyncResult BeginAddTagsToResource(AddTagsToResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return BeginInvoke<AddTagsToResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToResource.</param>
        /// 
        /// <returns>Returns a  AddTagsToResourceResult from StorageGateway.</returns>
        public  AddTagsToResourceResponse EndAddTagsToResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsToResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  AddUploadBuffer

        /// <summary>
        /// Configures one or more gateway local disks as upload buffer for a specified gateway.
        /// This operation is supported for both the gateway-stored and gateway-cached volume
        /// architectures.
        /// 
        ///  
        /// <para>
        /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add upload buffer, and one or more disk IDs that you want to configure as upload
        /// buffer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddUploadBuffer service method.</param>
        /// 
        /// <returns>The response from the AddUploadBuffer service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public AddUploadBufferResponse AddUploadBuffer(AddUploadBufferRequest request)
        {
            var marshaller = new AddUploadBufferRequestMarshaller();
            var unmarshaller = AddUploadBufferResponseUnmarshaller.Instance;

            return Invoke<AddUploadBufferRequest,AddUploadBufferResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddUploadBuffer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUploadBuffer operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddUploadBuffer
        ///         operation.</returns>
        public IAsyncResult BeginAddUploadBuffer(AddUploadBufferRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AddUploadBufferRequestMarshaller();
            var unmarshaller = AddUploadBufferResponseUnmarshaller.Instance;

            return BeginInvoke<AddUploadBufferRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddUploadBuffer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddUploadBuffer.</param>
        /// 
        /// <returns>Returns a  AddUploadBufferResult from StorageGateway.</returns>
        public  AddUploadBufferResponse EndAddUploadBuffer(IAsyncResult asyncResult)
        {
            return EndInvoke<AddUploadBufferResponse>(asyncResult);
        }

        #endregion
        
        #region  AddWorkingStorage

        /// <summary>
        /// Configures one or more gateway local disks as working storage for a gateway. This
        /// operation is supported only for the gateway-stored volume architecture. This operation
        /// is deprecated in cached-volumes API version 20120630. Use <a>AddUploadBuffer</a> instead.
        /// 
        ///  <note> 
        /// <para>
        /// Working storage is also referred to as upload buffer. You can also use the <a>AddUploadBuffer</a>
        /// operation to add upload buffer to a stored-volume gateway.
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add working storage, and one or more disk IDs that you want to configure as working
        /// storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddWorkingStorage service method.</param>
        /// 
        /// <returns>The response from the AddWorkingStorage service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public AddWorkingStorageResponse AddWorkingStorage(AddWorkingStorageRequest request)
        {
            var marshaller = new AddWorkingStorageRequestMarshaller();
            var unmarshaller = AddWorkingStorageResponseUnmarshaller.Instance;

            return Invoke<AddWorkingStorageRequest,AddWorkingStorageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddWorkingStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddWorkingStorage operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddWorkingStorage
        ///         operation.</returns>
        public IAsyncResult BeginAddWorkingStorage(AddWorkingStorageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AddWorkingStorageRequestMarshaller();
            var unmarshaller = AddWorkingStorageResponseUnmarshaller.Instance;

            return BeginInvoke<AddWorkingStorageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddWorkingStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddWorkingStorage.</param>
        /// 
        /// <returns>Returns a  AddWorkingStorageResult from StorageGateway.</returns>
        public  AddWorkingStorageResponse EndAddWorkingStorage(IAsyncResult asyncResult)
        {
            return EndInvoke<AddWorkingStorageResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelArchival

        /// <summary>
        /// Cancels archiving of a virtual tape to the virtual tape shelf (VTS) after the archiving
        /// process is initiated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelArchival service method.</param>
        /// 
        /// <returns>The response from the CancelArchival service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public CancelArchivalResponse CancelArchival(CancelArchivalRequest request)
        {
            var marshaller = new CancelArchivalRequestMarshaller();
            var unmarshaller = CancelArchivalResponseUnmarshaller.Instance;

            return Invoke<CancelArchivalRequest,CancelArchivalResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelArchival operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelArchival operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelArchival
        ///         operation.</returns>
        public IAsyncResult BeginCancelArchival(CancelArchivalRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CancelArchivalRequestMarshaller();
            var unmarshaller = CancelArchivalResponseUnmarshaller.Instance;

            return BeginInvoke<CancelArchivalRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelArchival operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelArchival.</param>
        /// 
        /// <returns>Returns a  CancelArchivalResult from StorageGateway.</returns>
        public  CancelArchivalResponse EndCancelArchival(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelArchivalResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelRetrieval

        /// <summary>
        /// Cancels retrieval of a virtual tape from the virtual tape shelf (VTS) to a gateway
        /// after the retrieval process is initiated. The virtual tape is returned to the VTS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelRetrieval service method.</param>
        /// 
        /// <returns>The response from the CancelRetrieval service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public CancelRetrievalResponse CancelRetrieval(CancelRetrievalRequest request)
        {
            var marshaller = new CancelRetrievalRequestMarshaller();
            var unmarshaller = CancelRetrievalResponseUnmarshaller.Instance;

            return Invoke<CancelRetrievalRequest,CancelRetrievalResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelRetrieval operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelRetrieval operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelRetrieval
        ///         operation.</returns>
        public IAsyncResult BeginCancelRetrieval(CancelRetrievalRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CancelRetrievalRequestMarshaller();
            var unmarshaller = CancelRetrievalResponseUnmarshaller.Instance;

            return BeginInvoke<CancelRetrievalRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelRetrieval operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelRetrieval.</param>
        /// 
        /// <returns>Returns a  CancelRetrievalResult from StorageGateway.</returns>
        public  CancelRetrievalResponse EndCancelRetrieval(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelRetrievalResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCachediSCSIVolume

        /// <summary>
        /// Creates a cached volume on a specified cached gateway. This operation is supported
        /// only for the gateway-cached volume architecture.
        /// 
        ///  <note>
        /// <para>
        /// Cache storage must be allocated to the gateway before you can create a cached volume.
        /// Use the <a>AddCache</a> operation to add cache storage to a gateway. 
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, you must specify the gateway, size of the volume in bytes, the iSCSI
        /// target name, an IP address on which to expose the target, and a unique client token.
        /// In response, AWS Storage Gateway creates the volume and returns information about
        /// it such as the volume Amazon Resource Name (ARN), its size, and the iSCSI target ARN
        /// that initiators can use to connect to the volume target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCachediSCSIVolume service method.</param>
        /// 
        /// <returns>The response from the CreateCachediSCSIVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public CreateCachediSCSIVolumeResponse CreateCachediSCSIVolume(CreateCachediSCSIVolumeRequest request)
        {
            var marshaller = new CreateCachediSCSIVolumeRequestMarshaller();
            var unmarshaller = CreateCachediSCSIVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateCachediSCSIVolumeRequest,CreateCachediSCSIVolumeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCachediSCSIVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCachediSCSIVolume operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCachediSCSIVolume
        ///         operation.</returns>
        public IAsyncResult BeginCreateCachediSCSIVolume(CreateCachediSCSIVolumeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateCachediSCSIVolumeRequestMarshaller();
            var unmarshaller = CreateCachediSCSIVolumeResponseUnmarshaller.Instance;

            return BeginInvoke<CreateCachediSCSIVolumeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCachediSCSIVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCachediSCSIVolume.</param>
        /// 
        /// <returns>Returns a  CreateCachediSCSIVolumeResult from StorageGateway.</returns>
        public  CreateCachediSCSIVolumeResponse EndCreateCachediSCSIVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCachediSCSIVolumeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSnapshot

        /// <summary>
        /// Initiates a snapshot of a volume.
        /// 
        ///  
        /// <para>
        /// AWS Storage Gateway provides the ability to back up point-in-time snapshots of your
        /// data to Amazon Simple Storage (S3) for durable off-site recovery, as well as import
        /// the data to an Amazon Elastic Block Store (EBS) volume in Amazon Elastic Compute Cloud
        /// (EC2). You can take snapshots of your gateway volume on a scheduled or ad-hoc basis.
        /// This API enables you to take ad-hoc snapshot. For more information, see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/WorkingWithSnapshots.html">Working
        /// With Snapshots in the AWS Storage Gateway Console</a>.
        /// </para>
        ///  
        /// <para>
        /// In the CreateSnapshot request you identify the volume by providing its Amazon Resource
        /// Name (ARN). You must also provide description for the snapshot. When AWS Storage Gateway
        /// takes the snapshot of specified volume, the snapshot and description appears in the
        /// AWS Storage Gateway Console. In response, AWS Storage Gateway returns you a snapshot
        /// ID. You can use this snapshot ID to check the snapshot progress or later use it when
        /// you want to create a volume from a snapshot.
        /// </para>
        ///  <note>
        /// <para>
        /// To list or delete a snapshot, you must use the Amazon EC2 API. For more information,
        /// see DescribeSnapshots or DeleteSnapshot in the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_Operations.html">EC2
        /// API reference</a>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Volume and snapshot IDs are changing to a longer length ID format. For more information,
        /// see the important note on the <a href="http://docs.aws.amazon.com/storagegateway/latest/APIReference/Welcome.html">Welcome</a>
        /// page.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotRequest,CreateSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotResult from StorageGateway.</returns>
        public  CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSnapshotFromVolumeRecoveryPoint

        /// <summary>
        /// Initiates a snapshot of a gateway from a volume recovery point. This operation is
        /// supported only for the gateway-cached volume architecture.
        /// 
        ///  
        /// <para>
        /// A volume recovery point is a point in time at which all data of the volume is consistent
        /// and from which you can create a snapshot. To get a list of volume recovery point for
        /// gateway-cached volumes, use <a>ListVolumeRecoveryPoints</a>.
        /// </para>
        ///  
        /// <para>
        /// In the <code>CreateSnapshotFromVolumeRecoveryPoint</code> request, you identify the
        /// volume by providing its Amazon Resource Name (ARN). You must also provide a description
        /// for the snapshot. When AWS Storage Gateway takes a snapshot of the specified volume,
        /// the snapshot and its description appear in the AWS Storage Gateway console. In response,
        /// AWS Storage Gateway returns you a snapshot ID. You can use this snapshot ID to check
        /// the snapshot progress or later use it when you want to create a volume from a snapshot.
        /// </para>
        ///  <note> 
        /// <para>
        /// To list or delete a snapshot, you must use the Amazon EC2 API. For more information,
        /// in <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotFromVolumeRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshotFromVolumeRecoveryPoint service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public CreateSnapshotFromVolumeRecoveryPointResponse CreateSnapshotFromVolumeRecoveryPoint(CreateSnapshotFromVolumeRecoveryPointRequest request)
        {
            var marshaller = new CreateSnapshotFromVolumeRecoveryPointRequestMarshaller();
            var unmarshaller = CreateSnapshotFromVolumeRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotFromVolumeRecoveryPointRequest,CreateSnapshotFromVolumeRecoveryPointResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotFromVolumeRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotFromVolumeRecoveryPoint operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshotFromVolumeRecoveryPoint
        ///         operation.</returns>
        public IAsyncResult BeginCreateSnapshotFromVolumeRecoveryPoint(CreateSnapshotFromVolumeRecoveryPointRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateSnapshotFromVolumeRecoveryPointRequestMarshaller();
            var unmarshaller = CreateSnapshotFromVolumeRecoveryPointResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSnapshotFromVolumeRecoveryPointRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshotFromVolumeRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshotFromVolumeRecoveryPoint.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotFromVolumeRecoveryPointResult from StorageGateway.</returns>
        public  CreateSnapshotFromVolumeRecoveryPointResponse EndCreateSnapshotFromVolumeRecoveryPoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSnapshotFromVolumeRecoveryPointResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStorediSCSIVolume

        /// <summary>
        /// Creates a volume on a specified gateway. This operation is supported only for the
        /// gateway-stored volume architecture.
        /// 
        ///  
        /// <para>
        /// The size of the volume to create is inferred from the disk size. You can choose to
        /// preserve existing data on the disk, create volume from an existing snapshot, or create
        /// an empty volume. If you choose to create an empty gateway volume, then any existing
        /// data on the disk is erased.
        /// </para>
        ///  
        /// <para>
        /// In the request you must specify the gateway and the disk information on which you
        /// are creating the volume. In response, AWS Storage Gateway creates the volume and returns
        /// volume information such as the volume Amazon Resource Name (ARN), its size, and the
        /// iSCSI target ARN that initiators can use to connect to the volume target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorediSCSIVolume service method.</param>
        /// 
        /// <returns>The response from the CreateStorediSCSIVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public CreateStorediSCSIVolumeResponse CreateStorediSCSIVolume(CreateStorediSCSIVolumeRequest request)
        {
            var marshaller = new CreateStorediSCSIVolumeRequestMarshaller();
            var unmarshaller = CreateStorediSCSIVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateStorediSCSIVolumeRequest,CreateStorediSCSIVolumeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorediSCSIVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorediSCSIVolume operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStorediSCSIVolume
        ///         operation.</returns>
        public IAsyncResult BeginCreateStorediSCSIVolume(CreateStorediSCSIVolumeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateStorediSCSIVolumeRequestMarshaller();
            var unmarshaller = CreateStorediSCSIVolumeResponseUnmarshaller.Instance;

            return BeginInvoke<CreateStorediSCSIVolumeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStorediSCSIVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStorediSCSIVolume.</param>
        /// 
        /// <returns>Returns a  CreateStorediSCSIVolumeResult from StorageGateway.</returns>
        public  CreateStorediSCSIVolumeResponse EndCreateStorediSCSIVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStorediSCSIVolumeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTapes

        /// <summary>
        /// Creates one or more virtual tapes. You write data to the virtual tapes and then archive
        /// the tapes.
        /// 
        ///  <note>
        /// <para>
        /// Cache storage must be allocated to the gateway before you can create virtual tapes.
        /// Use the <a>AddCache</a> operation to add cache storage to a gateway. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTapes service method.</param>
        /// 
        /// <returns>The response from the CreateTapes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public CreateTapesResponse CreateTapes(CreateTapesRequest request)
        {
            var marshaller = new CreateTapesRequestMarshaller();
            var unmarshaller = CreateTapesResponseUnmarshaller.Instance;

            return Invoke<CreateTapesRequest,CreateTapesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTapes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTapes operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTapes
        ///         operation.</returns>
        public IAsyncResult BeginCreateTapes(CreateTapesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateTapesRequestMarshaller();
            var unmarshaller = CreateTapesResponseUnmarshaller.Instance;

            return BeginInvoke<CreateTapesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTapes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTapes.</param>
        /// 
        /// <returns>Returns a  CreateTapesResult from StorageGateway.</returns>
        public  CreateTapesResponse EndCreateTapes(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTapesResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTapeWithBarcode

        /// <summary>
        /// Creates a virtual tape by using your own barcode. You write data to the virtual tape
        /// and then archive the tape.
        /// 
        ///  <note>
        /// <para>
        /// Cache storage must be allocated to the gateway before you can create a virtual tape.
        /// Use the <a>AddCache</a> operation to add cache storage to a gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTapeWithBarcode service method.</param>
        /// 
        /// <returns>The response from the CreateTapeWithBarcode service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public CreateTapeWithBarcodeResponse CreateTapeWithBarcode(CreateTapeWithBarcodeRequest request)
        {
            var marshaller = new CreateTapeWithBarcodeRequestMarshaller();
            var unmarshaller = CreateTapeWithBarcodeResponseUnmarshaller.Instance;

            return Invoke<CreateTapeWithBarcodeRequest,CreateTapeWithBarcodeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTapeWithBarcode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTapeWithBarcode operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTapeWithBarcode
        ///         operation.</returns>
        public IAsyncResult BeginCreateTapeWithBarcode(CreateTapeWithBarcodeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateTapeWithBarcodeRequestMarshaller();
            var unmarshaller = CreateTapeWithBarcodeResponseUnmarshaller.Instance;

            return BeginInvoke<CreateTapeWithBarcodeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTapeWithBarcode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTapeWithBarcode.</param>
        /// 
        /// <returns>Returns a  CreateTapeWithBarcodeResult from StorageGateway.</returns>
        public  CreateTapeWithBarcodeResponse EndCreateTapeWithBarcode(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTapeWithBarcodeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBandwidthRateLimit

        /// <summary>
        /// Deletes the bandwidth rate limits of a gateway. You can delete either the upload and
        /// download bandwidth rate limit, or you can delete both. If you delete only one of the
        /// limits, the other limit remains unchanged. To specify which gateway to work with,
        /// use the Amazon Resource Name (ARN) of the gateway in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBandwidthRateLimit service method.</param>
        /// 
        /// <returns>The response from the DeleteBandwidthRateLimit service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DeleteBandwidthRateLimitResponse DeleteBandwidthRateLimit(DeleteBandwidthRateLimitRequest request)
        {
            var marshaller = new DeleteBandwidthRateLimitRequestMarshaller();
            var unmarshaller = DeleteBandwidthRateLimitResponseUnmarshaller.Instance;

            return Invoke<DeleteBandwidthRateLimitRequest,DeleteBandwidthRateLimitResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBandwidthRateLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBandwidthRateLimit operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBandwidthRateLimit
        ///         operation.</returns>
        public IAsyncResult BeginDeleteBandwidthRateLimit(DeleteBandwidthRateLimitRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteBandwidthRateLimitRequestMarshaller();
            var unmarshaller = DeleteBandwidthRateLimitResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteBandwidthRateLimitRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBandwidthRateLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBandwidthRateLimit.</param>
        /// 
        /// <returns>Returns a  DeleteBandwidthRateLimitResult from StorageGateway.</returns>
        public  DeleteBandwidthRateLimitResponse EndDeleteBandwidthRateLimit(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBandwidthRateLimitResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChapCredentials

        /// <summary>
        /// Deletes Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified
        /// iSCSI target and initiator pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChapCredentials service method.</param>
        /// 
        /// <returns>The response from the DeleteChapCredentials service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DeleteChapCredentialsResponse DeleteChapCredentials(DeleteChapCredentialsRequest request)
        {
            var marshaller = new DeleteChapCredentialsRequestMarshaller();
            var unmarshaller = DeleteChapCredentialsResponseUnmarshaller.Instance;

            return Invoke<DeleteChapCredentialsRequest,DeleteChapCredentialsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChapCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChapCredentials operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChapCredentials
        ///         operation.</returns>
        public IAsyncResult BeginDeleteChapCredentials(DeleteChapCredentialsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteChapCredentialsRequestMarshaller();
            var unmarshaller = DeleteChapCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteChapCredentialsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChapCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChapCredentials.</param>
        /// 
        /// <returns>Returns a  DeleteChapCredentialsResult from StorageGateway.</returns>
        public  DeleteChapCredentialsResponse EndDeleteChapCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChapCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGateway

        /// <summary>
        /// Deletes a gateway. To specify which gateway to delete, use the Amazon Resource Name
        /// (ARN) of the gateway in your request. The operation deletes the gateway; however,
        /// it does not delete the gateway virtual machine (VM) from your host computer.
        /// 
        ///  
        /// <para>
        /// After you delete a gateway, you cannot reactivate it. Completed snapshots of the gateway
        /// volumes are not deleted upon deleting the gateway, however, pending snapshots will
        /// not complete. After you delete a gateway, your next step is to remove it from your
        /// environment.
        /// </para>
        ///  <important> 
        /// <para>
        /// You no longer pay software charges after the gateway is deleted; however, your existing
        /// Amazon EBS snapshots persist and you will continue to be billed for these snapshots. You
        /// can choose to remove all remaining Amazon EBS snapshots by canceling your Amazon EC2
        /// subscription.  If you prefer not to cancel your Amazon EC2 subscription, you can delete
        /// your snapshots using the Amazon EC2 console. For more information, see the <a href="http://aws.amazon.com/storagegateway">
        /// AWS Storage Gateway Detail Page</a>. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request)
        {
            var marshaller = new DeleteGatewayRequestMarshaller();
            var unmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayRequest,DeleteGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGateway
        ///         operation.</returns>
        public IAsyncResult BeginDeleteGateway(DeleteGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteGatewayRequestMarshaller();
            var unmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGateway.</param>
        /// 
        /// <returns>Returns a  DeleteGatewayResult from StorageGateway.</returns>
        public  DeleteGatewayResponse EndDeleteGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSnapshotSchedule

        /// <summary>
        /// Deletes a snapshot of a volume.
        /// 
        ///  
        /// <para>
        /// You can take snapshots of your gateway volumes on a scheduled or ad hoc basis. This
        /// API action enables you to delete a snapshot schedule for a volume. For more information,
        /// see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/WorkingWithSnapshots.html">Working
        /// with Snapshots</a>. In the <code>DeleteSnapshotSchedule</code> request, you identify
        /// the volume by providing its Amazon Resource Name (ARN). 
        /// </para>
        ///  <note> 
        /// <para>
        /// To list or delete a snapshot, you must use the Amazon EC2 API. in <i>Amazon Elastic
        /// Compute Cloud API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshotSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DeleteSnapshotScheduleResponse DeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request)
        {
            var marshaller = new DeleteSnapshotScheduleRequestMarshaller();
            var unmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotScheduleRequest,DeleteSnapshotScheduleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSnapshotSchedule
        ///         operation.</returns>
        public IAsyncResult BeginDeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteSnapshotScheduleRequestMarshaller();
            var unmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSnapshotScheduleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshotSchedule.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotScheduleResult from StorageGateway.</returns>
        public  DeleteSnapshotScheduleResponse EndDeleteSnapshotSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSnapshotScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTape

        /// <summary>
        /// Deletes the specified virtual tape.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTape service method.</param>
        /// 
        /// <returns>The response from the DeleteTape service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DeleteTapeResponse DeleteTape(DeleteTapeRequest request)
        {
            var marshaller = new DeleteTapeRequestMarshaller();
            var unmarshaller = DeleteTapeResponseUnmarshaller.Instance;

            return Invoke<DeleteTapeRequest,DeleteTapeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTape operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTape operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTape
        ///         operation.</returns>
        public IAsyncResult BeginDeleteTape(DeleteTapeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteTapeRequestMarshaller();
            var unmarshaller = DeleteTapeResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteTapeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTape operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTape.</param>
        /// 
        /// <returns>Returns a  DeleteTapeResult from StorageGateway.</returns>
        public  DeleteTapeResponse EndDeleteTape(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTapeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTapeArchive

        /// <summary>
        /// Deletes the specified virtual tape from the virtual tape shelf (VTS).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTapeArchive service method.</param>
        /// 
        /// <returns>The response from the DeleteTapeArchive service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DeleteTapeArchiveResponse DeleteTapeArchive(DeleteTapeArchiveRequest request)
        {
            var marshaller = new DeleteTapeArchiveRequestMarshaller();
            var unmarshaller = DeleteTapeArchiveResponseUnmarshaller.Instance;

            return Invoke<DeleteTapeArchiveRequest,DeleteTapeArchiveResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTapeArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTapeArchive operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTapeArchive
        ///         operation.</returns>
        public IAsyncResult BeginDeleteTapeArchive(DeleteTapeArchiveRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteTapeArchiveRequestMarshaller();
            var unmarshaller = DeleteTapeArchiveResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteTapeArchiveRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTapeArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTapeArchive.</param>
        /// 
        /// <returns>Returns a  DeleteTapeArchiveResult from StorageGateway.</returns>
        public  DeleteTapeArchiveResponse EndDeleteTapeArchive(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTapeArchiveResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVolume

        /// <summary>
        /// Deletes the specified gateway volume that you previously created using the <a>CreateCachediSCSIVolume</a>
        /// or <a>CreateStorediSCSIVolume</a> API. For gateway-stored volumes, the local disk
        /// that was configured as the storage volume is not deleted. You can reuse the local
        /// disk to create another storage volume. 
        /// 
        ///  
        /// <para>
        /// Before you delete a gateway volume, make sure there are no iSCSI connections to the
        /// volume you are deleting. You should also make sure there is no snapshot in progress.
        /// You can use the Amazon Elastic Compute Cloud (Amazon EC2) API to query snapshots on
        /// the volume you are deleting and check the snapshot status. For more information, go
        /// to <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSnapshots.html">DescribeSnapshots</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// In the request, you must provide the Amazon Resource Name (ARN) of the storage volume
        /// you want to delete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            var marshaller = new DeleteVolumeRequestMarshaller();
            var unmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return Invoke<DeleteVolumeRequest,DeleteVolumeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVolume
        ///         operation.</returns>
        public IAsyncResult BeginDeleteVolume(DeleteVolumeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteVolumeRequestMarshaller();
            var unmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteVolumeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVolume.</param>
        /// 
        /// <returns>Returns a  DeleteVolumeResult from StorageGateway.</returns>
        public  DeleteVolumeResponse EndDeleteVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVolumeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBandwidthRateLimit

        /// <summary>
        /// Returns the bandwidth rate limits of a gateway. By default, these limits are not set,
        /// which means no bandwidth rate limiting is in effect.
        /// 
        ///  
        /// <para>
        /// This operation only returns a value for a bandwidth rate limit only if the limit is
        /// set. If no limits are set for the gateway, then this operation returns only the gateway
        /// ARN in the response body. To specify which gateway to describe, use the Amazon Resource
        /// Name (ARN) of the gateway in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimit service method.</param>
        /// 
        /// <returns>The response from the DescribeBandwidthRateLimit service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DescribeBandwidthRateLimitResponse DescribeBandwidthRateLimit(DescribeBandwidthRateLimitRequest request)
        {
            var marshaller = new DescribeBandwidthRateLimitRequestMarshaller();
            var unmarshaller = DescribeBandwidthRateLimitResponseUnmarshaller.Instance;

            return Invoke<DescribeBandwidthRateLimitRequest,DescribeBandwidthRateLimitResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBandwidthRateLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimit operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBandwidthRateLimit
        ///         operation.</returns>
        public IAsyncResult BeginDescribeBandwidthRateLimit(DescribeBandwidthRateLimitRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeBandwidthRateLimitRequestMarshaller();
            var unmarshaller = DescribeBandwidthRateLimitResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeBandwidthRateLimitRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBandwidthRateLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBandwidthRateLimit.</param>
        /// 
        /// <returns>Returns a  DescribeBandwidthRateLimitResult from StorageGateway.</returns>
        public  DescribeBandwidthRateLimitResponse EndDescribeBandwidthRateLimit(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBandwidthRateLimitResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCache

        /// <summary>
        /// Returns information about the cache of a gateway. This operation is supported only
        /// for the gateway-cached volume architecture.
        /// 
        ///  
        /// <para>
        /// The response includes disk IDs that are configured as cache, and it includes the amount
        /// of cache allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCache service method.</param>
        /// 
        /// <returns>The response from the DescribeCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DescribeCacheResponse DescribeCache(DescribeCacheRequest request)
        {
            var marshaller = new DescribeCacheRequestMarshaller();
            var unmarshaller = DescribeCacheResponseUnmarshaller.Instance;

            return Invoke<DescribeCacheRequest,DescribeCacheResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCache operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCache
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCache(DescribeCacheRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeCacheRequestMarshaller();
            var unmarshaller = DescribeCacheResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeCacheRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCache.</param>
        /// 
        /// <returns>Returns a  DescribeCacheResult from StorageGateway.</returns>
        public  DescribeCacheResponse EndDescribeCache(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCacheResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCachediSCSIVolumes

        /// <summary>
        /// Returns a description of the gateway volumes specified in the request. This operation
        /// is supported only for the gateway-cached volume architecture.
        /// 
        ///  
        /// <para>
        /// The list of gateway volumes in the request must be from one gateway. In the response
        /// Amazon Storage Gateway returns volume information sorted by volume Amazon Resource
        /// Name (ARN).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes service method.</param>
        /// 
        /// <returns>The response from the DescribeCachediSCSIVolumes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DescribeCachediSCSIVolumesResponse DescribeCachediSCSIVolumes(DescribeCachediSCSIVolumesRequest request)
        {
            var marshaller = new DescribeCachediSCSIVolumesRequestMarshaller();
            var unmarshaller = DescribeCachediSCSIVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeCachediSCSIVolumesRequest,DescribeCachediSCSIVolumesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCachediSCSIVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCachediSCSIVolumes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCachediSCSIVolumes(DescribeCachediSCSIVolumesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeCachediSCSIVolumesRequestMarshaller();
            var unmarshaller = DescribeCachediSCSIVolumesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeCachediSCSIVolumesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCachediSCSIVolumes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCachediSCSIVolumes.</param>
        /// 
        /// <returns>Returns a  DescribeCachediSCSIVolumesResult from StorageGateway.</returns>
        public  DescribeCachediSCSIVolumesResponse EndDescribeCachediSCSIVolumes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCachediSCSIVolumesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChapCredentials

        /// <summary>
        /// Returns an array of Challenge-Handshake Authentication Protocol (CHAP) credentials
        /// information for a specified iSCSI target, one for each target-initiator pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChapCredentials service method.</param>
        /// 
        /// <returns>The response from the DescribeChapCredentials service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DescribeChapCredentialsResponse DescribeChapCredentials(DescribeChapCredentialsRequest request)
        {
            var marshaller = new DescribeChapCredentialsRequestMarshaller();
            var unmarshaller = DescribeChapCredentialsResponseUnmarshaller.Instance;

            return Invoke<DescribeChapCredentialsRequest,DescribeChapCredentialsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChapCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChapCredentials operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChapCredentials
        ///         operation.</returns>
        public IAsyncResult BeginDescribeChapCredentials(DescribeChapCredentialsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeChapCredentialsRequestMarshaller();
            var unmarshaller = DescribeChapCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeChapCredentialsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChapCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChapCredentials.</param>
        /// 
        /// <returns>Returns a  DescribeChapCredentialsResult from StorageGateway.</returns>
        public  DescribeChapCredentialsResponse EndDescribeChapCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChapCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGatewayInformation

        /// <summary>
        /// Returns metadata about a gateway such as its name, network interfaces, configured
        /// time zone, and the state (whether the gateway is running or not). To specify which
        /// gateway to describe, use the Amazon Resource Name (ARN) of the gateway in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInformation service method.</param>
        /// 
        /// <returns>The response from the DescribeGatewayInformation service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DescribeGatewayInformationResponse DescribeGatewayInformation(DescribeGatewayInformationRequest request)
        {
            var marshaller = new DescribeGatewayInformationRequestMarshaller();
            var unmarshaller = DescribeGatewayInformationResponseUnmarshaller.Instance;

            return Invoke<DescribeGatewayInformationRequest,DescribeGatewayInformationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGatewayInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInformation operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGatewayInformation
        ///         operation.</returns>
        public IAsyncResult BeginDescribeGatewayInformation(DescribeGatewayInformationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeGatewayInformationRequestMarshaller();
            var unmarshaller = DescribeGatewayInformationResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeGatewayInformationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGatewayInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGatewayInformation.</param>
        /// 
        /// <returns>Returns a  DescribeGatewayInformationResult from StorageGateway.</returns>
        public  DescribeGatewayInformationResponse EndDescribeGatewayInformation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGatewayInformationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMaintenanceStartTime

        /// <summary>
        /// Returns your gateway's weekly maintenance start time including the day and time of
        /// the week. Note that values are in terms of the gateway's time zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceStartTime service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceStartTime service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DescribeMaintenanceStartTimeResponse DescribeMaintenanceStartTime(DescribeMaintenanceStartTimeRequest request)
        {
            var marshaller = new DescribeMaintenanceStartTimeRequestMarshaller();
            var unmarshaller = DescribeMaintenanceStartTimeResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceStartTimeRequest,DescribeMaintenanceStartTimeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMaintenanceStartTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceStartTime operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceStartTime
        ///         operation.</returns>
        public IAsyncResult BeginDescribeMaintenanceStartTime(DescribeMaintenanceStartTimeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeMaintenanceStartTimeRequestMarshaller();
            var unmarshaller = DescribeMaintenanceStartTimeResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeMaintenanceStartTimeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceStartTime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceStartTime.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceStartTimeResult from StorageGateway.</returns>
        public  DescribeMaintenanceStartTimeResponse EndDescribeMaintenanceStartTime(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMaintenanceStartTimeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSnapshotSchedule

        /// <summary>
        /// Describes the snapshot schedule for the specified gateway volume. The snapshot schedule
        /// information includes intervals at which snapshots are automatically initiated on the
        /// volume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DescribeSnapshotScheduleResponse DescribeSnapshotSchedule(DescribeSnapshotScheduleRequest request)
        {
            var marshaller = new DescribeSnapshotScheduleRequestMarshaller();
            var unmarshaller = DescribeSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotScheduleRequest,DescribeSnapshotScheduleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedule operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshotSchedule
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSnapshotSchedule(DescribeSnapshotScheduleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSnapshotScheduleRequestMarshaller();
            var unmarshaller = DescribeSnapshotScheduleResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSnapshotScheduleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshotSchedule.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotScheduleResult from StorageGateway.</returns>
        public  DescribeSnapshotScheduleResponse EndDescribeSnapshotSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSnapshotScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStorediSCSIVolumes

        /// <summary>
        /// Returns the description of the gateway volumes specified in the request. The list
        /// of gateway volumes in the request must be from one gateway. In the response Amazon
        /// Storage Gateway returns volume information sorted by volume ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes service method.</param>
        /// 
        /// <returns>The response from the DescribeStorediSCSIVolumes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DescribeStorediSCSIVolumesResponse DescribeStorediSCSIVolumes(DescribeStorediSCSIVolumesRequest request)
        {
            var marshaller = new DescribeStorediSCSIVolumesRequestMarshaller();
            var unmarshaller = DescribeStorediSCSIVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeStorediSCSIVolumesRequest,DescribeStorediSCSIVolumesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStorediSCSIVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStorediSCSIVolumes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeStorediSCSIVolumes(DescribeStorediSCSIVolumesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeStorediSCSIVolumesRequestMarshaller();
            var unmarshaller = DescribeStorediSCSIVolumesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeStorediSCSIVolumesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStorediSCSIVolumes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStorediSCSIVolumes.</param>
        /// 
        /// <returns>Returns a  DescribeStorediSCSIVolumesResult from StorageGateway.</returns>
        public  DescribeStorediSCSIVolumesResponse EndDescribeStorediSCSIVolumes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStorediSCSIVolumesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTapeArchives

        /// <summary>
        /// Returns a description of specified virtual tapes in the virtual tape shelf (VTS).
        /// 
        ///  
        /// <para>
        /// If a specific <code>TapeARN</code> is not specified, AWS Storage Gateway returns a
        /// description of all virtual tapes found in the VTS associated with your account.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTapeArchives service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DescribeTapeArchivesResponse DescribeTapeArchives()
        {
            return DescribeTapeArchives(new DescribeTapeArchivesRequest());
        }

        /// <summary>
        /// Returns a description of specified virtual tapes in the virtual tape shelf (VTS).
        /// 
        ///  
        /// <para>
        /// If a specific <code>TapeARN</code> is not specified, AWS Storage Gateway returns a
        /// description of all virtual tapes found in the VTS associated with your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeArchives service method.</param>
        /// 
        /// <returns>The response from the DescribeTapeArchives service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DescribeTapeArchivesResponse DescribeTapeArchives(DescribeTapeArchivesRequest request)
        {
            var marshaller = new DescribeTapeArchivesRequestMarshaller();
            var unmarshaller = DescribeTapeArchivesResponseUnmarshaller.Instance;

            return Invoke<DescribeTapeArchivesRequest,DescribeTapeArchivesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTapeArchives operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeArchives operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTapeArchives
        ///         operation.</returns>
        public IAsyncResult BeginDescribeTapeArchives(DescribeTapeArchivesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeTapeArchivesRequestMarshaller();
            var unmarshaller = DescribeTapeArchivesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeTapeArchivesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTapeArchives operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTapeArchives.</param>
        /// 
        /// <returns>Returns a  DescribeTapeArchivesResult from StorageGateway.</returns>
        public  DescribeTapeArchivesResponse EndDescribeTapeArchives(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTapeArchivesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTapeRecoveryPoints

        /// <summary>
        /// Returns a list of virtual tape recovery points that are available for the specified
        /// gateway-VTL.
        /// 
        ///  
        /// <para>
        /// A recovery point is a point-in-time view of a virtual tape at which all the data on
        /// the virtual tape is consistent. If your gateway crashes, virtual tapes that have recovery
        /// points can be recovered to a new gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeRecoveryPoints service method.</param>
        /// 
        /// <returns>The response from the DescribeTapeRecoveryPoints service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DescribeTapeRecoveryPointsResponse DescribeTapeRecoveryPoints(DescribeTapeRecoveryPointsRequest request)
        {
            var marshaller = new DescribeTapeRecoveryPointsRequestMarshaller();
            var unmarshaller = DescribeTapeRecoveryPointsResponseUnmarshaller.Instance;

            return Invoke<DescribeTapeRecoveryPointsRequest,DescribeTapeRecoveryPointsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTapeRecoveryPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeRecoveryPoints operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTapeRecoveryPoints
        ///         operation.</returns>
        public IAsyncResult BeginDescribeTapeRecoveryPoints(DescribeTapeRecoveryPointsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeTapeRecoveryPointsRequestMarshaller();
            var unmarshaller = DescribeTapeRecoveryPointsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeTapeRecoveryPointsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTapeRecoveryPoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTapeRecoveryPoints.</param>
        /// 
        /// <returns>Returns a  DescribeTapeRecoveryPointsResult from StorageGateway.</returns>
        public  DescribeTapeRecoveryPointsResponse EndDescribeTapeRecoveryPoints(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTapeRecoveryPointsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTapes

        /// <summary>
        /// Returns a description of the specified Amazon Resource Name (ARN) of virtual tapes.
        /// If a <code>TapeARN</code> is not specified, returns a description of all virtual tapes
        /// associated with the specified gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapes service method.</param>
        /// 
        /// <returns>The response from the DescribeTapes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DescribeTapesResponse DescribeTapes(DescribeTapesRequest request)
        {
            var marshaller = new DescribeTapesRequestMarshaller();
            var unmarshaller = DescribeTapesResponseUnmarshaller.Instance;

            return Invoke<DescribeTapesRequest,DescribeTapesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTapes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapes operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTapes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeTapes(DescribeTapesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeTapesRequestMarshaller();
            var unmarshaller = DescribeTapesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeTapesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTapes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTapes.</param>
        /// 
        /// <returns>Returns a  DescribeTapesResult from StorageGateway.</returns>
        public  DescribeTapesResponse EndDescribeTapes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTapesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUploadBuffer

        /// <summary>
        /// Returns information about the upload buffer of a gateway. This operation is supported
        /// for both the gateway-stored and gateway-cached volume architectures.
        /// 
        ///  
        /// <para>
        /// The response includes disk IDs that are configured as upload buffer space, and it
        /// includes the amount of upload buffer space allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUploadBuffer service method.</param>
        /// 
        /// <returns>The response from the DescribeUploadBuffer service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DescribeUploadBufferResponse DescribeUploadBuffer(DescribeUploadBufferRequest request)
        {
            var marshaller = new DescribeUploadBufferRequestMarshaller();
            var unmarshaller = DescribeUploadBufferResponseUnmarshaller.Instance;

            return Invoke<DescribeUploadBufferRequest,DescribeUploadBufferResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUploadBuffer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUploadBuffer operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUploadBuffer
        ///         operation.</returns>
        public IAsyncResult BeginDescribeUploadBuffer(DescribeUploadBufferRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeUploadBufferRequestMarshaller();
            var unmarshaller = DescribeUploadBufferResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeUploadBufferRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUploadBuffer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUploadBuffer.</param>
        /// 
        /// <returns>Returns a  DescribeUploadBufferResult from StorageGateway.</returns>
        public  DescribeUploadBufferResponse EndDescribeUploadBuffer(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUploadBufferResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVTLDevices

        /// <summary>
        /// Returns a description of virtual tape library (VTL) devices for the specified gateway.
        /// In the response, AWS Storage Gateway returns VTL device information.
        /// 
        ///  
        /// <para>
        /// The list of VTL devices must be from one gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVTLDevices service method.</param>
        /// 
        /// <returns>The response from the DescribeVTLDevices service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DescribeVTLDevicesResponse DescribeVTLDevices(DescribeVTLDevicesRequest request)
        {
            var marshaller = new DescribeVTLDevicesRequestMarshaller();
            var unmarshaller = DescribeVTLDevicesResponseUnmarshaller.Instance;

            return Invoke<DescribeVTLDevicesRequest,DescribeVTLDevicesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVTLDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVTLDevices operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVTLDevices
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVTLDevices(DescribeVTLDevicesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeVTLDevicesRequestMarshaller();
            var unmarshaller = DescribeVTLDevicesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeVTLDevicesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVTLDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVTLDevices.</param>
        /// 
        /// <returns>Returns a  DescribeVTLDevicesResult from StorageGateway.</returns>
        public  DescribeVTLDevicesResponse EndDescribeVTLDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVTLDevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkingStorage

        /// <summary>
        /// Returns information about the working storage of a gateway. This operation is supported
        /// only for the gateway-stored volume architecture. This operation is deprecated in cached-volumes
        /// API version (20120630). Use DescribeUploadBuffer instead.
        /// 
        ///  <note> 
        /// <para>
        /// Working storage is also referred to as upload buffer. You can also use the DescribeUploadBuffer
        /// operation to add upload buffer to a stored-volume gateway.
        /// </para>
        ///  </note> 
        /// <para>
        /// The response includes disk IDs that are configured as working storage, and it includes
        /// the amount of working storage allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkingStorage service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkingStorage service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DescribeWorkingStorageResponse DescribeWorkingStorage(DescribeWorkingStorageRequest request)
        {
            var marshaller = new DescribeWorkingStorageRequestMarshaller();
            var unmarshaller = DescribeWorkingStorageResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkingStorageRequest,DescribeWorkingStorageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkingStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkingStorage operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkingStorage
        ///         operation.</returns>
        public IAsyncResult BeginDescribeWorkingStorage(DescribeWorkingStorageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeWorkingStorageRequestMarshaller();
            var unmarshaller = DescribeWorkingStorageResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeWorkingStorageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkingStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkingStorage.</param>
        /// 
        /// <returns>Returns a  DescribeWorkingStorageResult from StorageGateway.</returns>
        public  DescribeWorkingStorageResponse EndDescribeWorkingStorage(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkingStorageResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableGateway

        /// <summary>
        /// Disables a gateway when the gateway is no longer functioning. For example, if your
        /// gateway VM is damaged, you can disable the gateway so you can recover virtual tapes.
        /// 
        ///  
        /// <para>
        /// Use this operation for a gateway-VTL that is not reachable or not functioning.
        /// </para>
        ///  <important>
        /// <para>
        /// Once a gateway is disabled it cannot be enabled.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableGateway service method.</param>
        /// 
        /// <returns>The response from the DisableGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public DisableGatewayResponse DisableGateway(DisableGatewayRequest request)
        {
            var marshaller = new DisableGatewayRequestMarshaller();
            var unmarshaller = DisableGatewayResponseUnmarshaller.Instance;

            return Invoke<DisableGatewayRequest,DisableGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableGateway operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableGateway
        ///         operation.</returns>
        public IAsyncResult BeginDisableGateway(DisableGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisableGatewayRequestMarshaller();
            var unmarshaller = DisableGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<DisableGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableGateway.</param>
        /// 
        /// <returns>Returns a  DisableGatewayResult from StorageGateway.</returns>
        public  DisableGatewayResponse EndDisableGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGateways

        /// <summary>
        /// Lists gateways owned by an AWS account in a region specified in the request. The returned
        /// list is ordered by gateway Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// By default, the operation returns a maximum of 100 gateways. This operation supports
        /// pagination that allows you to optionally reduce the number of gateways returned in
        /// a response.
        /// </para>
        ///  
        /// <para>
        /// If you have more gateways than are returned in a response (that is, the response returns
        /// only a truncated list of your gateways), the response contains a marker that you can
        /// specify in your next request to fetch the next page of gateways.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public ListGatewaysResponse ListGateways()
        {
            return ListGateways(new ListGatewaysRequest());
        }

        /// <summary>
        /// Lists gateways owned by an AWS account in a region specified in the request. The returned
        /// list is ordered by gateway Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// By default, the operation returns a maximum of 100 gateways. This operation supports
        /// pagination that allows you to optionally reduce the number of gateways returned in
        /// a response.
        /// </para>
        ///  
        /// <para>
        /// If you have more gateways than are returned in a response (that is, the response returns
        /// only a truncated list of your gateways), the response contains a marker that you can
        /// specify in your next request to fetch the next page of gateways.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public ListGatewaysResponse ListGateways(ListGatewaysRequest request)
        {
            var marshaller = new ListGatewaysRequestMarshaller();
            var unmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListGatewaysRequest,ListGatewaysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGateways operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGateways
        ///         operation.</returns>
        public IAsyncResult BeginListGateways(ListGatewaysRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListGatewaysRequestMarshaller();
            var unmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return BeginInvoke<ListGatewaysRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGateways.</param>
        /// 
        /// <returns>Returns a  ListGatewaysResult from StorageGateway.</returns>
        public  ListGatewaysResponse EndListGateways(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGatewaysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLocalDisks

        /// <summary>
        /// Returns a list of the gateway's local disks. To specify which gateway to describe,
        /// you use the Amazon Resource Name (ARN) of the gateway in the body of the request.
        /// 
        ///  
        /// <para>
        /// The request returns a list of all disks, specifying which are configured as working
        /// storage, cache storage, or stored volume or not configured at all. The response includes
        /// a <code>DiskStatus</code> field. This field can have a value of present (the disk
        /// is available to use), missing (the disk is no longer connected to the gateway), or
        /// mismatch (the disk node is occupied by a disk that has incorrect metadata or the disk
        /// content is corrupted). 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLocalDisks service method.</param>
        /// 
        /// <returns>The response from the ListLocalDisks service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public ListLocalDisksResponse ListLocalDisks(ListLocalDisksRequest request)
        {
            var marshaller = new ListLocalDisksRequestMarshaller();
            var unmarshaller = ListLocalDisksResponseUnmarshaller.Instance;

            return Invoke<ListLocalDisksRequest,ListLocalDisksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLocalDisks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLocalDisks operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLocalDisks
        ///         operation.</returns>
        public IAsyncResult BeginListLocalDisks(ListLocalDisksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListLocalDisksRequestMarshaller();
            var unmarshaller = ListLocalDisksResponseUnmarshaller.Instance;

            return BeginInvoke<ListLocalDisksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLocalDisks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLocalDisks.</param>
        /// 
        /// <returns>Returns a  ListLocalDisksResult from StorageGateway.</returns>
        public  ListLocalDisksResponse EndListLocalDisks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLocalDisksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags that have been added to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        public IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsForResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from StorageGateway.</returns>
        public  ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTapes

        /// <summary>
        /// Lists virtual tapes in your virtual tape library (VTL) and your virtual tape shelf
        /// (VTS). You specify the tapes to list by specifying one or more tape Amazon Resource
        /// Names (ARNs). If you don't specify a tape ARN, the operation lists all virtual tapes
        /// in both your VTL and VTS.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination. By default, the operation returns a maximum of
        /// up to 100 tapes. You can optionally specify the <code>Limit</code> parameter in the
        /// body to limit the number of tapes in the response. If the number of tapes returned
        /// in the response is truncated, the response includes a <code>Marker</code> element
        /// that you can use in your subsequent request to retrieve the next set of tapes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTapes service method.</param>
        /// 
        /// <returns>The response from the ListTapes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public ListTapesResponse ListTapes(ListTapesRequest request)
        {
            var marshaller = new ListTapesRequestMarshaller();
            var unmarshaller = ListTapesResponseUnmarshaller.Instance;

            return Invoke<ListTapesRequest,ListTapesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTapes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTapes operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTapes
        ///         operation.</returns>
        public IAsyncResult BeginListTapes(ListTapesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTapesRequestMarshaller();
            var unmarshaller = ListTapesResponseUnmarshaller.Instance;

            return BeginInvoke<ListTapesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTapes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTapes.</param>
        /// 
        /// <returns>Returns a  ListTapesResult from StorageGateway.</returns>
        public  ListTapesResponse EndListTapes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTapesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVolumeInitiators

        /// <summary>
        /// Lists iSCSI initiators that are connected to a volume. You can use this operation
        /// to determine whether a volume is being used or not.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeInitiators service method.</param>
        /// 
        /// <returns>The response from the ListVolumeInitiators service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public ListVolumeInitiatorsResponse ListVolumeInitiators(ListVolumeInitiatorsRequest request)
        {
            var marshaller = new ListVolumeInitiatorsRequestMarshaller();
            var unmarshaller = ListVolumeInitiatorsResponseUnmarshaller.Instance;

            return Invoke<ListVolumeInitiatorsRequest,ListVolumeInitiatorsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumeInitiators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeInitiators operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVolumeInitiators
        ///         operation.</returns>
        public IAsyncResult BeginListVolumeInitiators(ListVolumeInitiatorsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListVolumeInitiatorsRequestMarshaller();
            var unmarshaller = ListVolumeInitiatorsResponseUnmarshaller.Instance;

            return BeginInvoke<ListVolumeInitiatorsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVolumeInitiators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVolumeInitiators.</param>
        /// 
        /// <returns>Returns a  ListVolumeInitiatorsResult from StorageGateway.</returns>
        public  ListVolumeInitiatorsResponse EndListVolumeInitiators(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVolumeInitiatorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVolumeRecoveryPoints

        /// <summary>
        /// Lists the recovery points for a specified gateway. This operation is supported only
        /// for the gateway-cached volume architecture.
        /// 
        ///  
        /// <para>
        /// Each gateway-cached volume has one recovery point. A volume recovery point is a point
        /// in time at which all data of the volume is consistent and from which you can create
        /// a snapshot. To create a snapshot from a volume recovery point use the <a>CreateSnapshotFromVolumeRecoveryPoint</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeRecoveryPoints service method.</param>
        /// 
        /// <returns>The response from the ListVolumeRecoveryPoints service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public ListVolumeRecoveryPointsResponse ListVolumeRecoveryPoints(ListVolumeRecoveryPointsRequest request)
        {
            var marshaller = new ListVolumeRecoveryPointsRequestMarshaller();
            var unmarshaller = ListVolumeRecoveryPointsResponseUnmarshaller.Instance;

            return Invoke<ListVolumeRecoveryPointsRequest,ListVolumeRecoveryPointsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumeRecoveryPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeRecoveryPoints operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVolumeRecoveryPoints
        ///         operation.</returns>
        public IAsyncResult BeginListVolumeRecoveryPoints(ListVolumeRecoveryPointsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListVolumeRecoveryPointsRequestMarshaller();
            var unmarshaller = ListVolumeRecoveryPointsResponseUnmarshaller.Instance;

            return BeginInvoke<ListVolumeRecoveryPointsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVolumeRecoveryPoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVolumeRecoveryPoints.</param>
        /// 
        /// <returns>Returns a  ListVolumeRecoveryPointsResult from StorageGateway.</returns>
        public  ListVolumeRecoveryPointsResponse EndListVolumeRecoveryPoints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVolumeRecoveryPointsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVolumes

        /// <summary>
        /// Lists the iSCSI stored volumes of a gateway. Results are sorted by volume ARN. The
        /// response includes only the volume ARNs. If you want additional volume information,
        /// use the <a>DescribeStorediSCSIVolumes</a> API.
        /// 
        ///  
        /// <para>
        /// The operation supports pagination. By default, the operation returns a maximum of
        /// up to 100 volumes. You can optionally specify the <code>Limit</code> field in the
        /// body to limit the number of volumes in the response. If the number of volumes returned
        /// in the response is truncated, the response includes a Marker field. You can use this
        /// Marker value in your subsequent request to retrieve the next set of volumes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumes service method.</param>
        /// 
        /// <returns>The response from the ListVolumes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public ListVolumesResponse ListVolumes(ListVolumesRequest request)
        {
            var marshaller = new ListVolumesRequestMarshaller();
            var unmarshaller = ListVolumesResponseUnmarshaller.Instance;

            return Invoke<ListVolumesRequest,ListVolumesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumes operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVolumes
        ///         operation.</returns>
        public IAsyncResult BeginListVolumes(ListVolumesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListVolumesRequestMarshaller();
            var unmarshaller = ListVolumesResponseUnmarshaller.Instance;

            return BeginInvoke<ListVolumesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVolumes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVolumes.</param>
        /// 
        /// <returns>Returns a  ListVolumesResult from StorageGateway.</returns>
        public  ListVolumesResponse EndListVolumes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVolumesResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromResource
        ///         operation.</returns>
        public IAsyncResult BeginRemoveTagsFromResource(RemoveTagsFromResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveTagsFromResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromResource.</param>
        /// 
        /// <returns>Returns a  RemoveTagsFromResourceResult from StorageGateway.</returns>
        public  RemoveTagsFromResourceResponse EndRemoveTagsFromResource(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTagsFromResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetCache

        /// <summary>
        /// Resets all cache disks that have encountered a error and makes the disks available
        /// for reconfiguration as cache storage. If your cache disk encounters a error, the gateway
        /// prevents read and write operations on virtual tapes in the gateway. For example, an
        /// error can occur when a disk is corrupted or removed from the gateway. When a cache
        /// is reset, the gateway loses its cache storage. At this point you can reconfigure the
        /// disks as cache disks.
        /// 
        ///  <important> 
        /// <para>
        /// If the cache disk you are resetting contains data that has not been uploaded to Amazon
        /// S3 yet, that data can be lost. After you reset cache disks, there will be no configured
        /// cache disks left in the gateway, so you must configure at least one new cache disk
        /// for your gateway to function properly.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="gatewayARN">A property of ResetCacheRequest used to execute the ResetCache service method.</param>
        /// 
        /// <returns>The response from the ResetCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public ResetCacheResponse ResetCache(string gatewayARN)
        {
            var request = new ResetCacheRequest();
            request.GatewayARN = gatewayARN;
            return ResetCache(request);
        }


        /// <summary>
        /// Resets all cache disks that have encountered a error and makes the disks available
        /// for reconfiguration as cache storage. If your cache disk encounters a error, the gateway
        /// prevents read and write operations on virtual tapes in the gateway. For example, an
        /// error can occur when a disk is corrupted or removed from the gateway. When a cache
        /// is reset, the gateway loses its cache storage. At this point you can reconfigure the
        /// disks as cache disks.
        /// 
        ///  <important> 
        /// <para>
        /// If the cache disk you are resetting contains data that has not been uploaded to Amazon
        /// S3 yet, that data can be lost. After you reset cache disks, there will be no configured
        /// cache disks left in the gateway, so you must configure at least one new cache disk
        /// for your gateway to function properly.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetCache service method.</param>
        /// 
        /// <returns>The response from the ResetCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public ResetCacheResponse ResetCache(ResetCacheRequest request)
        {
            var marshaller = new ResetCacheRequestMarshaller();
            var unmarshaller = ResetCacheResponseUnmarshaller.Instance;

            return Invoke<ResetCacheRequest,ResetCacheResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetCache operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetCache
        ///         operation.</returns>
        public IAsyncResult BeginResetCache(ResetCacheRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ResetCacheRequestMarshaller();
            var unmarshaller = ResetCacheResponseUnmarshaller.Instance;

            return BeginInvoke<ResetCacheRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetCache.</param>
        /// 
        /// <returns>Returns a  ResetCacheResult from StorageGateway.</returns>
        public  ResetCacheResponse EndResetCache(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetCacheResponse>(asyncResult);
        }

        #endregion
        
        #region  RetrieveTapeArchive

        /// <summary>
        /// Retrieves an archived virtual tape from the virtual tape shelf (VTS) to a gateway-VTL.
        /// Virtual tapes archived in the VTS are not associated with any gateway. However after
        /// a tape is retrieved, it is associated with a gateway, even though it is also listed
        /// in the VTS.
        /// 
        ///  
        /// <para>
        /// Once a tape is successfully retrieved to a gateway, it cannot be retrieved again to
        /// another gateway. You must archive the tape again before you can retrieve it to another
        /// gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeArchive service method.</param>
        /// 
        /// <returns>The response from the RetrieveTapeArchive service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public RetrieveTapeArchiveResponse RetrieveTapeArchive(RetrieveTapeArchiveRequest request)
        {
            var marshaller = new RetrieveTapeArchiveRequestMarshaller();
            var unmarshaller = RetrieveTapeArchiveResponseUnmarshaller.Instance;

            return Invoke<RetrieveTapeArchiveRequest,RetrieveTapeArchiveResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveTapeArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeArchive operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetrieveTapeArchive
        ///         operation.</returns>
        public IAsyncResult BeginRetrieveTapeArchive(RetrieveTapeArchiveRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RetrieveTapeArchiveRequestMarshaller();
            var unmarshaller = RetrieveTapeArchiveResponseUnmarshaller.Instance;

            return BeginInvoke<RetrieveTapeArchiveRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RetrieveTapeArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieveTapeArchive.</param>
        /// 
        /// <returns>Returns a  RetrieveTapeArchiveResult from StorageGateway.</returns>
        public  RetrieveTapeArchiveResponse EndRetrieveTapeArchive(IAsyncResult asyncResult)
        {
            return EndInvoke<RetrieveTapeArchiveResponse>(asyncResult);
        }

        #endregion
        
        #region  RetrieveTapeRecoveryPoint

        /// <summary>
        /// Retrieves the recovery point for the specified virtual tape.
        /// 
        ///  
        /// <para>
        /// A recovery point is a point in time view of a virtual tape at which all the data on
        /// the tape is consistent. If your gateway crashes, virtual tapes that have recovery
        /// points can be recovered to a new gateway.
        /// </para>
        ///  <note>
        /// <para>
        /// The virtual tape can be retrieved to only one gateway. The retrieved tape is read-only.
        /// The virtual tape can be retrieved to only a gateway-VTL. There is no charge for retrieving
        /// recovery points.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the RetrieveTapeRecoveryPoint service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public RetrieveTapeRecoveryPointResponse RetrieveTapeRecoveryPoint(RetrieveTapeRecoveryPointRequest request)
        {
            var marshaller = new RetrieveTapeRecoveryPointRequestMarshaller();
            var unmarshaller = RetrieveTapeRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<RetrieveTapeRecoveryPointRequest,RetrieveTapeRecoveryPointResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveTapeRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeRecoveryPoint operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetrieveTapeRecoveryPoint
        ///         operation.</returns>
        public IAsyncResult BeginRetrieveTapeRecoveryPoint(RetrieveTapeRecoveryPointRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RetrieveTapeRecoveryPointRequestMarshaller();
            var unmarshaller = RetrieveTapeRecoveryPointResponseUnmarshaller.Instance;

            return BeginInvoke<RetrieveTapeRecoveryPointRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RetrieveTapeRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieveTapeRecoveryPoint.</param>
        /// 
        /// <returns>Returns a  RetrieveTapeRecoveryPointResult from StorageGateway.</returns>
        public  RetrieveTapeRecoveryPointResponse EndRetrieveTapeRecoveryPoint(IAsyncResult asyncResult)
        {
            return EndInvoke<RetrieveTapeRecoveryPointResponse>(asyncResult);
        }

        #endregion
        
        #region  SetLocalConsolePassword

        /// <summary>
        /// Sets the password for your VM local console. When you log in to the local console
        /// for the first time, you log in to the VM with the default credentials. We recommend
        /// that you set a new password. You don't need to know the default password to set a
        /// new password.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLocalConsolePassword service method.</param>
        /// 
        /// <returns>The response from the SetLocalConsolePassword service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public SetLocalConsolePasswordResponse SetLocalConsolePassword(SetLocalConsolePasswordRequest request)
        {
            var marshaller = new SetLocalConsolePasswordRequestMarshaller();
            var unmarshaller = SetLocalConsolePasswordResponseUnmarshaller.Instance;

            return Invoke<SetLocalConsolePasswordRequest,SetLocalConsolePasswordResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetLocalConsolePassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLocalConsolePassword operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetLocalConsolePassword
        ///         operation.</returns>
        public IAsyncResult BeginSetLocalConsolePassword(SetLocalConsolePasswordRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SetLocalConsolePasswordRequestMarshaller();
            var unmarshaller = SetLocalConsolePasswordResponseUnmarshaller.Instance;

            return BeginInvoke<SetLocalConsolePasswordRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetLocalConsolePassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLocalConsolePassword.</param>
        /// 
        /// <returns>Returns a  SetLocalConsolePasswordResult from StorageGateway.</returns>
        public  SetLocalConsolePasswordResponse EndSetLocalConsolePassword(IAsyncResult asyncResult)
        {
            return EndInvoke<SetLocalConsolePasswordResponse>(asyncResult);
        }

        #endregion
        
        #region  ShutdownGateway

        /// <summary>
        /// Shuts down a gateway. To specify which gateway to shut down, use the Amazon Resource
        /// Name (ARN) of the gateway in the body of your request.
        /// 
        ///  
        /// <para>
        /// The operation shuts down the gateway service component running in the storage gateway's
        /// virtual machine (VM) and not the VM.
        /// </para>
        ///  <note>
        /// <para>
        /// If you want to shut down the VM, it is recommended that you first shut down the gateway
        /// component in the VM to avoid unpredictable conditions.
        /// </para>
        ///  </note> 
        /// <para>
        /// After the gateway is shutdown, you cannot call any other API except <a>StartGateway</a>,
        /// <a>DescribeGatewayInformation</a>, and <a>ListGateways</a>. For more information,
        /// see <a>ActivateGateway</a>. Your applications cannot read from or write to the gateway's
        /// storage volumes, and there are no snapshots taken.
        /// </para>
        ///  <note>
        /// <para>
        /// When you make a shutdown request, you will get a <code>200 OK</code> success response
        /// immediately. However, it might take some time for the gateway to shut down. You can
        /// call the <a>DescribeGatewayInformation</a> API to check the status. For more information,
        /// see <a>ActivateGateway</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// If do not intend to use the gateway again, you must delete the gateway (using <a>DeleteGateway</a>)
        /// to no longer pay software charges associated with the gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ShutdownGateway service method.</param>
        /// 
        /// <returns>The response from the ShutdownGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public ShutdownGatewayResponse ShutdownGateway(ShutdownGatewayRequest request)
        {
            var marshaller = new ShutdownGatewayRequestMarshaller();
            var unmarshaller = ShutdownGatewayResponseUnmarshaller.Instance;

            return Invoke<ShutdownGatewayRequest,ShutdownGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ShutdownGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ShutdownGateway operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndShutdownGateway
        ///         operation.</returns>
        public IAsyncResult BeginShutdownGateway(ShutdownGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ShutdownGatewayRequestMarshaller();
            var unmarshaller = ShutdownGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<ShutdownGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ShutdownGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginShutdownGateway.</param>
        /// 
        /// <returns>Returns a  ShutdownGatewayResult from StorageGateway.</returns>
        public  ShutdownGatewayResponse EndShutdownGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<ShutdownGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  StartGateway

        /// <summary>
        /// Starts a gateway that you previously shut down (see <a>ShutdownGateway</a>). After
        /// the gateway starts, you can then make other API calls, your applications can read
        /// from or write to the gateway's storage volumes and you will be able to take snapshot
        /// backups.
        /// 
        ///  <note>
        /// <para>
        /// When you make a request, you will get a 200 OK success response immediately. However,
        /// it might take some time for the gateway to be ready. You should call <a>DescribeGatewayInformation</a>
        /// and check the status before making any additional API calls. For more information,
        /// see <a>ActivateGateway</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To specify which gateway to start, use the Amazon Resource Name (ARN) of the gateway
        /// in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartGateway service method.</param>
        /// 
        /// <returns>The response from the StartGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public StartGatewayResponse StartGateway(StartGatewayRequest request)
        {
            var marshaller = new StartGatewayRequestMarshaller();
            var unmarshaller = StartGatewayResponseUnmarshaller.Instance;

            return Invoke<StartGatewayRequest,StartGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGateway operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartGateway
        ///         operation.</returns>
        public IAsyncResult BeginStartGateway(StartGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StartGatewayRequestMarshaller();
            var unmarshaller = StartGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<StartGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartGateway.</param>
        /// 
        /// <returns>Returns a  StartGatewayResult from StorageGateway.</returns>
        public  StartGatewayResponse EndStartGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<StartGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBandwidthRateLimit

        /// <summary>
        /// Updates the bandwidth rate limits of a gateway. You can update both the upload and
        /// download bandwidth rate limit or specify only one of the two. If you don't set a bandwidth
        /// rate limit, the existing rate limit remains.
        /// 
        ///  
        /// <para>
        /// By default, a gateway's bandwidth rate limits are not set. If you don't set any limit,
        /// the gateway does not have any limitations on its bandwidth usage and could potentially
        /// use the maximum available bandwidth.
        /// </para>
        ///  
        /// <para>
        /// To specify which gateway to update, use the Amazon Resource Name (ARN) of the gateway
        /// in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimit service method.</param>
        /// 
        /// <returns>The response from the UpdateBandwidthRateLimit service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public UpdateBandwidthRateLimitResponse UpdateBandwidthRateLimit(UpdateBandwidthRateLimitRequest request)
        {
            var marshaller = new UpdateBandwidthRateLimitRequestMarshaller();
            var unmarshaller = UpdateBandwidthRateLimitResponseUnmarshaller.Instance;

            return Invoke<UpdateBandwidthRateLimitRequest,UpdateBandwidthRateLimitResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBandwidthRateLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimit operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBandwidthRateLimit
        ///         operation.</returns>
        public IAsyncResult BeginUpdateBandwidthRateLimit(UpdateBandwidthRateLimitRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateBandwidthRateLimitRequestMarshaller();
            var unmarshaller = UpdateBandwidthRateLimitResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateBandwidthRateLimitRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBandwidthRateLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBandwidthRateLimit.</param>
        /// 
        /// <returns>Returns a  UpdateBandwidthRateLimitResult from StorageGateway.</returns>
        public  UpdateBandwidthRateLimitResponse EndUpdateBandwidthRateLimit(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBandwidthRateLimitResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChapCredentials

        /// <summary>
        /// Updates the Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified
        /// iSCSI target. By default, a gateway does not have CHAP enabled; however, for added
        /// security, you might use it.
        /// 
        ///  <important> 
        /// <para>
        /// When you update CHAP credentials, all existing connections on the target are closed
        /// and initiators must reconnect with the new credentials.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChapCredentials service method.</param>
        /// 
        /// <returns>The response from the UpdateChapCredentials service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public UpdateChapCredentialsResponse UpdateChapCredentials(UpdateChapCredentialsRequest request)
        {
            var marshaller = new UpdateChapCredentialsRequestMarshaller();
            var unmarshaller = UpdateChapCredentialsResponseUnmarshaller.Instance;

            return Invoke<UpdateChapCredentialsRequest,UpdateChapCredentialsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChapCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChapCredentials operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChapCredentials
        ///         operation.</returns>
        public IAsyncResult BeginUpdateChapCredentials(UpdateChapCredentialsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateChapCredentialsRequestMarshaller();
            var unmarshaller = UpdateChapCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateChapCredentialsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChapCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChapCredentials.</param>
        /// 
        /// <returns>Returns a  UpdateChapCredentialsResult from StorageGateway.</returns>
        public  UpdateChapCredentialsResponse EndUpdateChapCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChapCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGatewayInformation

        /// <summary>
        /// Updates a gateway's metadata, which includes the gateway's name and time zone. To
        /// specify which gateway to update, use the Amazon Resource Name (ARN) of the gateway
        /// in your request.
        /// 
        ///  <note>
        /// <para>
        /// For Gateways activated after September 2, 2015, the gateway's ARN contains the gateway
        /// ID rather than the gateway name. However, changing the name of the gateway has no
        /// effect on the gateway's ARN.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewayInformation service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public UpdateGatewayInformationResponse UpdateGatewayInformation(UpdateGatewayInformationRequest request)
        {
            var marshaller = new UpdateGatewayInformationRequestMarshaller();
            var unmarshaller = UpdateGatewayInformationResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayInformationRequest,UpdateGatewayInformationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewayInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGatewayInformation
        ///         operation.</returns>
        public IAsyncResult BeginUpdateGatewayInformation(UpdateGatewayInformationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateGatewayInformationRequestMarshaller();
            var unmarshaller = UpdateGatewayInformationResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateGatewayInformationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGatewayInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewayInformation.</param>
        /// 
        /// <returns>Returns a  UpdateGatewayInformationResult from StorageGateway.</returns>
        public  UpdateGatewayInformationResponse EndUpdateGatewayInformation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGatewayInformationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGatewaySoftwareNow

        /// <summary>
        /// Updates the gateway virtual machine (VM) software. The request immediately triggers
        /// the software update.
        /// 
        ///  <note>
        /// <para>
        /// When you make this request, you get a <code>200 OK</code> success response immediately.
        /// However, it might take some time for the update to complete. You can call <a>DescribeGatewayInformation</a>
        /// to verify the gateway is in the <code>STATE_RUNNING</code> state.
        /// </para>
        ///  </note> <important>
        /// <para>
        /// A software update forces a system restart of your gateway. You can minimize the chance
        /// of any disruption to your applications by increasing your iSCSI Initiators' timeouts.
        /// For more information about increasing iSCSI Initiator timeouts for Windows and Linux,
        /// see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/ConfiguringiSCSIClientInitiatorWindowsClient.html#CustomizeWindowsiSCSISettings">Customizing
        /// Your Windows iSCSI Settings</a> and <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/ConfiguringiSCSIClientInitiatorRedHatClient.html#CustomizeLinuxiSCSISettings">Customizing
        /// Your Linux iSCSI Settings</a>, respectively.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewaySoftwareNow service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public UpdateGatewaySoftwareNowResponse UpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest request)
        {
            var marshaller = new UpdateGatewaySoftwareNowRequestMarshaller();
            var unmarshaller = UpdateGatewaySoftwareNowResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewaySoftwareNowRequest,UpdateGatewaySoftwareNowResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewaySoftwareNow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGatewaySoftwareNow
        ///         operation.</returns>
        public IAsyncResult BeginUpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateGatewaySoftwareNowRequestMarshaller();
            var unmarshaller = UpdateGatewaySoftwareNowResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateGatewaySoftwareNowRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGatewaySoftwareNow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewaySoftwareNow.</param>
        /// 
        /// <returns>Returns a  UpdateGatewaySoftwareNowResult from StorageGateway.</returns>
        public  UpdateGatewaySoftwareNowResponse EndUpdateGatewaySoftwareNow(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGatewaySoftwareNowResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMaintenanceStartTime

        /// <summary>
        /// Updates a gateway's weekly maintenance start time information, including day and time
        /// of the week. The maintenance time is the time in your gateway's time zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceStartTime service method.</param>
        /// 
        /// <returns>The response from the UpdateMaintenanceStartTime service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public UpdateMaintenanceStartTimeResponse UpdateMaintenanceStartTime(UpdateMaintenanceStartTimeRequest request)
        {
            var marshaller = new UpdateMaintenanceStartTimeRequestMarshaller();
            var unmarshaller = UpdateMaintenanceStartTimeResponseUnmarshaller.Instance;

            return Invoke<UpdateMaintenanceStartTimeRequest,UpdateMaintenanceStartTimeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMaintenanceStartTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceStartTime operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMaintenanceStartTime
        ///         operation.</returns>
        public IAsyncResult BeginUpdateMaintenanceStartTime(UpdateMaintenanceStartTimeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateMaintenanceStartTimeRequestMarshaller();
            var unmarshaller = UpdateMaintenanceStartTimeResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateMaintenanceStartTimeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMaintenanceStartTime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMaintenanceStartTime.</param>
        /// 
        /// <returns>Returns a  UpdateMaintenanceStartTimeResult from StorageGateway.</returns>
        public  UpdateMaintenanceStartTimeResponse EndUpdateMaintenanceStartTime(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMaintenanceStartTimeResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSnapshotSchedule

        /// <summary>
        /// Updates a snapshot schedule configured for a gateway volume.
        /// 
        ///  
        /// <para>
        /// The default snapshot schedule for volume is once every 24 hours, starting at the creation
        /// time of the volume. You can use this API to change the snapshot schedule configured
        /// for the volume.
        /// </para>
        ///  
        /// <para>
        /// In the request you must identify the gateway volume whose snapshot schedule you want
        /// to update, and the schedule information, including when you want the snapshot to begin
        /// on a day and the frequency (in hours) of snapshots.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateSnapshotSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public UpdateSnapshotScheduleResponse UpdateSnapshotSchedule(UpdateSnapshotScheduleRequest request)
        {
            var marshaller = new UpdateSnapshotScheduleRequestMarshaller();
            var unmarshaller = UpdateSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateSnapshotScheduleRequest,UpdateSnapshotScheduleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotSchedule operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSnapshotSchedule
        ///         operation.</returns>
        public IAsyncResult BeginUpdateSnapshotSchedule(UpdateSnapshotScheduleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateSnapshotScheduleRequestMarshaller();
            var unmarshaller = UpdateSnapshotScheduleResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateSnapshotScheduleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSnapshotSchedule.</param>
        /// 
        /// <returns>Returns a  UpdateSnapshotScheduleResult from StorageGateway.</returns>
        public  UpdateSnapshotScheduleResponse EndUpdateSnapshotSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSnapshotScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVTLDeviceType

        /// <summary>
        /// Updates the type of medium changer in a gateway-VTL. When you activate a gateway-VTL,
        /// you select a medium changer type for the gateway-VTL. This operation enables you to
        /// select a different type of medium changer after a gateway-VTL is activated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVTLDeviceType service method.</param>
        /// 
        /// <returns>The response from the UpdateVTLDeviceType service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        public UpdateVTLDeviceTypeResponse UpdateVTLDeviceType(UpdateVTLDeviceTypeRequest request)
        {
            var marshaller = new UpdateVTLDeviceTypeRequestMarshaller();
            var unmarshaller = UpdateVTLDeviceTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateVTLDeviceTypeRequest,UpdateVTLDeviceTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVTLDeviceType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVTLDeviceType operation on AmazonStorageGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVTLDeviceType
        ///         operation.</returns>
        public IAsyncResult BeginUpdateVTLDeviceType(UpdateVTLDeviceTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateVTLDeviceTypeRequestMarshaller();
            var unmarshaller = UpdateVTLDeviceTypeResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateVTLDeviceTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVTLDeviceType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVTLDeviceType.</param>
        /// 
        /// <returns>Returns a  UpdateVTLDeviceTypeResult from StorageGateway.</returns>
        public  UpdateVTLDeviceTypeResponse EndUpdateVTLDeviceType(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVTLDeviceTypeResponse>(asyncResult);
        }

        #endregion
        
    }
}