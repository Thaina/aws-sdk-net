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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Route53Domains.Model;
using Amazon.Route53Domains.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Route53Domains
{
    /// <summary>
    /// Implementation for accessing Route53Domains
    ///
    /// 
    /// </summary>
    public partial class AmazonRoute53DomainsClient : AmazonServiceClient, IAmazonRoute53Domains
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with the credentials loaded from the application's
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
        public AmazonRoute53DomainsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53DomainsConfig()) { }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with the credentials loaded from the application's
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
        public AmazonRoute53DomainsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53DomainsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRoute53DomainsClient Configuration Object</param>
        public AmazonRoute53DomainsClient(AmazonRoute53DomainsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoute53DomainsClient(AWSCredentials credentials)
            : this(credentials, new AmazonRoute53DomainsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53DomainsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoute53DomainsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Credentials and an
        /// AmazonRoute53DomainsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoute53DomainsClient Configuration Object</param>
        public AmazonRoute53DomainsClient(AWSCredentials credentials, AmazonRoute53DomainsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoute53DomainsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53DomainsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53DomainsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53DomainsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53DomainsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoute53DomainsClient Configuration Object</param>
        public AmazonRoute53DomainsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoute53DomainsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoute53DomainsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53DomainsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53DomainsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53DomainsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53DomainsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoute53DomainsClient Configuration Object</param>
        public AmazonRoute53DomainsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoute53DomainsConfig clientConfig)
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

        
        #region  CheckDomainAvailability


        /// <summary>
        /// This operation checks the availability of one domain name. Note that if the availability
        /// status of a domain is pending, you must submit another request to determine the availability
        /// of the domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainAvailability service method.</param>
        /// 
        /// <returns>The response from the CheckDomainAvailability service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public CheckDomainAvailabilityResponse CheckDomainAvailability(CheckDomainAvailabilityRequest request)
        {
            var marshaller = new CheckDomainAvailabilityRequestMarshaller();
            var unmarshaller = CheckDomainAvailabilityResponseUnmarshaller.Instance;

            return Invoke<CheckDomainAvailabilityRequest,CheckDomainAvailabilityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CheckDomainAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainAvailability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CheckDomainAvailabilityResponse> CheckDomainAvailabilityAsync(CheckDomainAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CheckDomainAvailabilityRequestMarshaller();
            var unmarshaller = CheckDomainAvailabilityResponseUnmarshaller.Instance;

            return InvokeAsync<CheckDomainAvailabilityRequest,CheckDomainAvailabilityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTagsForDomain


        /// <summary>
        /// This operation deletes the specified tags for a domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to delete one or more tags. The name of a domain. Type: String Default: None Constraints: The domain name can contain only the letters a through z, the numbers 0 through 9, and hyphen (-). Hyphens are allowed only when they&apos;re surrounded by letters, numbers, or other hyphens. You can&apos;t specify a hyphen at the beginning or end of a label. To specify an Internationalized Domain Name, you must convert the name to Punycode. Required: Yes</param>
        /// <param name="tagsToDelete">A list of tag keys to delete. Type: A list that contains the keys of the tags that you want to delete. Default: None Required: No'></param>
        /// 
        /// <returns>The response from the DeleteTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public DeleteTagsForDomainResponse DeleteTagsForDomain(string domainName, List<string> tagsToDelete)
        {
            var request = new DeleteTagsForDomainRequest();
            request.DomainName = domainName;
            request.TagsToDelete = tagsToDelete;
            return DeleteTagsForDomain(request);
        }


        /// <summary>
        /// This operation deletes the specified tags for a domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagsForDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public DeleteTagsForDomainResponse DeleteTagsForDomain(DeleteTagsForDomainRequest request)
        {
            var marshaller = new DeleteTagsForDomainRequestMarshaller();
            var unmarshaller = DeleteTagsForDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsForDomainRequest,DeleteTagsForDomainResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// This operation deletes the specified tags for a domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to delete one or more tags. The name of a domain. Type: String Default: None Constraints: The domain name can contain only the letters a through z, the numbers 0 through 9, and hyphen (-). Hyphens are allowed only when they&apos;re surrounded by letters, numbers, or other hyphens. You can&apos;t specify a hyphen at the beginning or end of a label. To specify an Internationalized Domain Name, you must convert the name to Punycode. Required: Yes</param>
        /// <param name="tagsToDelete">A list of tag keys to delete. Type: A list that contains the keys of the tags that you want to delete. Default: None Required: No'></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public Task<DeleteTagsForDomainResponse> DeleteTagsForDomainAsync(string domainName, List<string> tagsToDelete, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteTagsForDomainRequest();
            request.DomainName = domainName;
            request.TagsToDelete = tagsToDelete;
            return DeleteTagsForDomainAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagsForDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteTagsForDomainResponse> DeleteTagsForDomainAsync(DeleteTagsForDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTagsForDomainRequestMarshaller();
            var unmarshaller = DeleteTagsForDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsForDomainRequest,DeleteTagsForDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableDomainAutoRenew


        /// <summary>
        /// This operation disables automatic renewal of domain registration for the specified
        /// domain.
        /// 
        ///  <note>Caution! Amazon Route 53 doesn't have a manual renewal process, so if you disable
        /// automatic renewal, registration for the domain will not be renewed when the expiration
        /// date passes, and you will lose control of the domain name.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainAutoRenew service method.</param>
        /// 
        /// <returns>The response from the DisableDomainAutoRenew service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public DisableDomainAutoRenewResponse DisableDomainAutoRenew(DisableDomainAutoRenewRequest request)
        {
            var marshaller = new DisableDomainAutoRenewRequestMarshaller();
            var unmarshaller = DisableDomainAutoRenewResponseUnmarshaller.Instance;

            return Invoke<DisableDomainAutoRenewRequest,DisableDomainAutoRenewResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableDomainAutoRenew operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainAutoRenew operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisableDomainAutoRenewResponse> DisableDomainAutoRenewAsync(DisableDomainAutoRenewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableDomainAutoRenewRequestMarshaller();
            var unmarshaller = DisableDomainAutoRenewResponseUnmarshaller.Instance;

            return InvokeAsync<DisableDomainAutoRenewRequest,DisableDomainAutoRenewResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableDomainTransferLock


        /// <summary>
        /// This operation removes the transfer lock on the domain (specifically the <code>clientTransferProhibited</code>
        /// status) to allow domain transfers. We recommend you refrain from performing this action
        /// unless you intend to transfer the domain to a different registrar. Successful submission
        /// returns an operation ID that you can use to track the progress and completion of the
        /// action. If the request is not completed successfully, the domain registrant will be
        /// notified by email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainTransferLock service method.</param>
        /// 
        /// <returns>The response from the DisableDomainTransferLock service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public DisableDomainTransferLockResponse DisableDomainTransferLock(DisableDomainTransferLockRequest request)
        {
            var marshaller = new DisableDomainTransferLockRequestMarshaller();
            var unmarshaller = DisableDomainTransferLockResponseUnmarshaller.Instance;

            return Invoke<DisableDomainTransferLockRequest,DisableDomainTransferLockResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableDomainTransferLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainTransferLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisableDomainTransferLockResponse> DisableDomainTransferLockAsync(DisableDomainTransferLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableDomainTransferLockRequestMarshaller();
            var unmarshaller = DisableDomainTransferLockResponseUnmarshaller.Instance;

            return InvokeAsync<DisableDomainTransferLockRequest,DisableDomainTransferLockResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableDomainAutoRenew


        /// <summary>
        /// This operation configures Amazon Route 53 to automatically renew the specified domain
        /// before the domain registration expires. The cost of renewing your domain registration
        /// is billed to your AWS account.
        /// 
        ///  
        /// <para>
        /// The period during which you can renew a domain name varies by TLD. For a list of TLDs
        /// and their renewal policies, see <a href="http://wiki.gandi.net/en/domains/renew#renewal_restoration_and_deletion_times">"Renewal,
        /// restoration, and deletion times"</a> on the website for our registrar partner, Gandi.
        /// Route 53 requires that you renew before the end of the renewal period that is listed
        /// on the Gandi website so we can complete processing before the deadline.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainAutoRenew service method.</param>
        /// 
        /// <returns>The response from the EnableDomainAutoRenew service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public EnableDomainAutoRenewResponse EnableDomainAutoRenew(EnableDomainAutoRenewRequest request)
        {
            var marshaller = new EnableDomainAutoRenewRequestMarshaller();
            var unmarshaller = EnableDomainAutoRenewResponseUnmarshaller.Instance;

            return Invoke<EnableDomainAutoRenewRequest,EnableDomainAutoRenewResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableDomainAutoRenew operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainAutoRenew operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableDomainAutoRenewResponse> EnableDomainAutoRenewAsync(EnableDomainAutoRenewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableDomainAutoRenewRequestMarshaller();
            var unmarshaller = EnableDomainAutoRenewResponseUnmarshaller.Instance;

            return InvokeAsync<EnableDomainAutoRenewRequest,EnableDomainAutoRenewResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableDomainTransferLock


        /// <summary>
        /// This operation sets the transfer lock on the domain (specifically the <code>clientTransferProhibited</code>
        /// status) to prevent domain transfers. Successful submission returns an operation ID
        /// that you can use to track the progress and completion of the action. If the request
        /// is not completed successfully, the domain registrant will be notified by email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainTransferLock service method.</param>
        /// 
        /// <returns>The response from the EnableDomainTransferLock service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public EnableDomainTransferLockResponse EnableDomainTransferLock(EnableDomainTransferLockRequest request)
        {
            var marshaller = new EnableDomainTransferLockRequestMarshaller();
            var unmarshaller = EnableDomainTransferLockResponseUnmarshaller.Instance;

            return Invoke<EnableDomainTransferLockRequest,EnableDomainTransferLockResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableDomainTransferLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainTransferLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableDomainTransferLockResponse> EnableDomainTransferLockAsync(EnableDomainTransferLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableDomainTransferLockRequestMarshaller();
            var unmarshaller = EnableDomainTransferLockResponseUnmarshaller.Instance;

            return InvokeAsync<EnableDomainTransferLockRequest,EnableDomainTransferLockResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetContactReachabilityStatus


        /// <summary>
        /// For operations that require confirmation that the email address for the registrant
        /// contact is valid, such as registering a new domain, this operation returns information
        /// about whether the registrant contact has responded.
        /// 
        ///  
        /// <para>
        /// If you want us to resend the email, use the <code>ResendContactReachabilityEmail</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactReachabilityStatus service method.</param>
        /// 
        /// <returns>The response from the GetContactReachabilityStatus service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public GetContactReachabilityStatusResponse GetContactReachabilityStatus(GetContactReachabilityStatusRequest request)
        {
            var marshaller = new GetContactReachabilityStatusRequestMarshaller();
            var unmarshaller = GetContactReachabilityStatusResponseUnmarshaller.Instance;

            return Invoke<GetContactReachabilityStatusRequest,GetContactReachabilityStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContactReachabilityStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContactReachabilityStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetContactReachabilityStatusResponse> GetContactReachabilityStatusAsync(GetContactReachabilityStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetContactReachabilityStatusRequestMarshaller();
            var unmarshaller = GetContactReachabilityStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetContactReachabilityStatusRequest,GetContactReachabilityStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDomainDetail


        /// <summary>
        /// This operation returns detailed information about the domain. The domain's contact
        /// information is also returned as part of the output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail service method.</param>
        /// 
        /// <returns>The response from the GetDomainDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public GetDomainDetailResponse GetDomainDetail(GetDomainDetailRequest request)
        {
            var marshaller = new GetDomainDetailRequestMarshaller();
            var unmarshaller = GetDomainDetailResponseUnmarshaller.Instance;

            return Invoke<GetDomainDetailRequest,GetDomainDetailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainDetail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetDomainDetailResponse> GetDomainDetailAsync(GetDomainDetailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDomainDetailRequestMarshaller();
            var unmarshaller = GetDomainDetailResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainDetailRequest,GetDomainDetailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetOperationDetail


        /// <summary>
        /// This operation returns the current status of an operation that is not completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperationDetail service method.</param>
        /// 
        /// <returns>The response from the GetOperationDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        public GetOperationDetailResponse GetOperationDetail(GetOperationDetailRequest request)
        {
            var marshaller = new GetOperationDetailRequestMarshaller();
            var unmarshaller = GetOperationDetailResponseUnmarshaller.Instance;

            return Invoke<GetOperationDetailRequest,GetOperationDetailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOperationDetail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperationDetail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetOperationDetailResponse> GetOperationDetailAsync(GetOperationDetailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetOperationDetailRequestMarshaller();
            var unmarshaller = GetOperationDetailResponseUnmarshaller.Instance;

            return InvokeAsync<GetOperationDetailRequest,GetOperationDetailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        public ListDomainsResponse ListDomains()
        {
            return ListDomains(new ListDomainsRequest());
        }


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        public ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var marshaller = new ListDomainsRequestMarshaller();
            var unmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsRequest,ListDomainsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current AWS account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        public Task<ListDomainsResponse> ListDomainsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListDomainsAsync(new ListDomainsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDomainsRequestMarshaller();
            var unmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainsRequest,ListDomainsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListOperations


        /// <summary>
        /// This operation returns the operation IDs of operations that are not yet complete.
        /// </summary>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        public ListOperationsResponse ListOperations()
        {
            return ListOperations(new ListOperationsRequest());
        }


        /// <summary>
        /// This operation returns the operation IDs of operations that are not yet complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        public ListOperationsResponse ListOperations(ListOperationsRequest request)
        {
            var marshaller = new ListOperationsRequestMarshaller();
            var unmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return Invoke<ListOperationsRequest,ListOperationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// This operation returns the operation IDs of operations that are not yet complete.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        public Task<ListOperationsResponse> ListOperationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListOperationsAsync(new ListOperationsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOperations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListOperationsResponse> ListOperationsAsync(ListOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListOperationsRequestMarshaller();
            var unmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOperationsRequest,ListOperationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForDomain


        /// <summary>
        /// This operation returns all of the tags that are associated with the specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to get a list of tags.</param>
        /// 
        /// <returns>The response from the ListTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public ListTagsForDomainResponse ListTagsForDomain(string domainName)
        {
            var request = new ListTagsForDomainRequest();
            request.DomainName = domainName;
            return ListTagsForDomain(request);
        }


        /// <summary>
        /// This operation returns all of the tags that are associated with the specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForDomain service method.</param>
        /// 
        /// <returns>The response from the ListTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public ListTagsForDomainResponse ListTagsForDomain(ListTagsForDomainRequest request)
        {
            var marshaller = new ListTagsForDomainRequestMarshaller();
            var unmarshaller = ListTagsForDomainResponseUnmarshaller.Instance;

            return Invoke<ListTagsForDomainRequest,ListTagsForDomainResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// This operation returns all of the tags that are associated with the specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to get a list of tags.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public Task<ListTagsForDomainResponse> ListTagsForDomainAsync(string domainName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListTagsForDomainRequest();
            request.DomainName = domainName;
            return ListTagsForDomainAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTagsForDomainResponse> ListTagsForDomainAsync(ListTagsForDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForDomainRequestMarshaller();
            var unmarshaller = ListTagsForDomainResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForDomainRequest,ListTagsForDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterDomain


        /// <summary>
        /// This operation registers a domain. Domains are registered by the AWS registrar partner,
        /// Gandi. For some top-level domains (TLDs), this operation requires extra parameters.
        /// 
        ///  
        /// <para>
        /// When you register a domain, Amazon Route 53 does the following:
        /// </para>
        ///  <ul> <li>Creates a Amazon Route 53 hosted zone that has the same name as the domain.
        /// Amazon Route 53 assigns four name servers to your hosted zone and automatically updates
        /// your domain registration with the names of these name servers.</li> <li>Enables autorenew,
        /// so your domain registration will renew automatically each year. We'll notify you in
        /// advance of the renewal date so you can choose whether to renew the registration.</li>
        /// <li>Optionally enables privacy protection, so WHOIS queries return contact information
        /// for our registrar partner, Gandi, instead of the information you entered for registrant,
        /// admin, and tech contacts.</li> <li>If registration is successful, returns an operation
        /// ID that you can use to track the progress and completion of the action. If the request
        /// is not completed successfully, the domain registrant is notified by email.</li> <li>Charges
        /// your AWS account an amount based on the top-level domain. For more information, see
        /// <a href="http://aws.amazon.com/route53/pricing/">Amazon Route 53 Pricing</a>.</li>
        /// </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain service method.</param>
        /// 
        /// <returns>The response from the RegisterDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public RegisterDomainResponse RegisterDomain(RegisterDomainRequest request)
        {
            var marshaller = new RegisterDomainRequestMarshaller();
            var unmarshaller = RegisterDomainResponseUnmarshaller.Instance;

            return Invoke<RegisterDomainRequest,RegisterDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RegisterDomainResponse> RegisterDomainAsync(RegisterDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterDomainRequestMarshaller();
            var unmarshaller = RegisterDomainResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterDomainRequest,RegisterDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResendContactReachabilityEmail


        /// <summary>
        /// For operations that require confirmation that the email address for the registrant
        /// contact is valid, such as registering a new domain, this operation resends the confirmation
        /// email to the current email address for the registrant contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendContactReachabilityEmail service method.</param>
        /// 
        /// <returns>The response from the ResendContactReachabilityEmail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public ResendContactReachabilityEmailResponse ResendContactReachabilityEmail(ResendContactReachabilityEmailRequest request)
        {
            var marshaller = new ResendContactReachabilityEmailRequestMarshaller();
            var unmarshaller = ResendContactReachabilityEmailResponseUnmarshaller.Instance;

            return Invoke<ResendContactReachabilityEmailRequest,ResendContactReachabilityEmailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResendContactReachabilityEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendContactReachabilityEmail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ResendContactReachabilityEmailResponse> ResendContactReachabilityEmailAsync(ResendContactReachabilityEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResendContactReachabilityEmailRequestMarshaller();
            var unmarshaller = ResendContactReachabilityEmailResponseUnmarshaller.Instance;

            return InvokeAsync<ResendContactReachabilityEmailRequest,ResendContactReachabilityEmailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RetrieveDomainAuthCode


        /// <summary>
        /// This operation returns the AuthCode for the domain. To transfer a domain to another
        /// registrar, you provide this value to the new registrar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode service method.</param>
        /// 
        /// <returns>The response from the RetrieveDomainAuthCode service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public RetrieveDomainAuthCodeResponse RetrieveDomainAuthCode(RetrieveDomainAuthCodeRequest request)
        {
            var marshaller = new RetrieveDomainAuthCodeRequestMarshaller();
            var unmarshaller = RetrieveDomainAuthCodeResponseUnmarshaller.Instance;

            return Invoke<RetrieveDomainAuthCodeRequest,RetrieveDomainAuthCodeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveDomainAuthCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RetrieveDomainAuthCodeResponse> RetrieveDomainAuthCodeAsync(RetrieveDomainAuthCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RetrieveDomainAuthCodeRequestMarshaller();
            var unmarshaller = RetrieveDomainAuthCodeResponseUnmarshaller.Instance;

            return InvokeAsync<RetrieveDomainAuthCodeRequest,RetrieveDomainAuthCodeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TransferDomain


        /// <summary>
        /// This operation transfers a domain from another registrar to Amazon Route 53. When
        /// the transfer is complete, the domain is registered with the AWS registrar partner,
        /// Gandi.
        /// 
        ///  
        /// <para>
        /// For transfer requirements, a detailed procedure, and information about viewing the
        /// status of a domain transfer, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-transfer-to-route-53.html">Transferring
        /// Registration for a Domain to Amazon Route 53</a> in the Amazon Route 53 Developer
        /// Guide.
        /// </para>
        ///  
        /// <para>
        /// If the registrar for your domain is also the DNS service provider for the domain,
        /// we highly recommend that you consider transferring your DNS service to Amazon Route
        /// 53 or to another DNS service provider before you transfer your registration. Some
        /// registrars provide free DNS service when you purchase a domain registration. When
        /// you transfer the registration, the previous registrar will not renew your domain registration
        /// and could end your DNS service at any time.
        /// </para>
        ///  <note>Caution! If the registrar for your domain is also the DNS service provider
        /// for the domain and you don't transfer DNS service to another provider, your website,
        /// email, and the web applications associated with the domain might become unavailable.</note>
        /// 
        /// <para>
        /// If the transfer is successful, this method returns an operation ID that you can use
        /// to track the progress and completion of the action. If the transfer doesn't complete
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransferDomain service method.</param>
        /// 
        /// <returns>The response from the TransferDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public TransferDomainResponse TransferDomain(TransferDomainRequest request)
        {
            var marshaller = new TransferDomainRequestMarshaller();
            var unmarshaller = TransferDomainResponseUnmarshaller.Instance;

            return Invoke<TransferDomainRequest,TransferDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TransferDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TransferDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<TransferDomainResponse> TransferDomainAsync(TransferDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TransferDomainRequestMarshaller();
            var unmarshaller = TransferDomainResponseUnmarshaller.Instance;

            return InvokeAsync<TransferDomainRequest,TransferDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainContact


        /// <summary>
        /// This operation updates the contact information for a particular domain. Information
        /// for at least one contact (registrant, administrator, or technical) must be supplied
        /// for update.
        /// 
        ///  
        /// <para>
        /// If the update is successful, this method returns an operation ID that you can use
        /// to track the progress and completion of the action. If the request is not completed
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContact service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainContact service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public UpdateDomainContactResponse UpdateDomainContact(UpdateDomainContactRequest request)
        {
            var marshaller = new UpdateDomainContactRequestMarshaller();
            var unmarshaller = UpdateDomainContactResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainContactRequest,UpdateDomainContactResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateDomainContactResponse> UpdateDomainContactAsync(UpdateDomainContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDomainContactRequestMarshaller();
            var unmarshaller = UpdateDomainContactResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainContactRequest,UpdateDomainContactResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainContactPrivacy


        /// <summary>
        /// This operation updates the specified domain contact's privacy setting. When the privacy
        /// option is enabled, personal information such as postal or email address is hidden
        /// from the results of a public WHOIS query. The privacy services are provided by the
        /// AWS registrar, Gandi. For more information, see the <a href="http://www.gandi.net/domain/whois/?currency=USD&amp;amp;lang=en">Gandi
        /// privacy features</a>.
        /// 
        ///  
        /// <para>
        /// This operation only affects the privacy of the specified contact type (registrant,
        /// administrator, or tech). Successful acceptance returns an operation ID that you can
        /// use with GetOperationDetail to track the progress and completion of the action. If
        /// the request is not completed successfully, the domain registrant will be notified
        /// by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainContactPrivacy service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public UpdateDomainContactPrivacyResponse UpdateDomainContactPrivacy(UpdateDomainContactPrivacyRequest request)
        {
            var marshaller = new UpdateDomainContactPrivacyRequestMarshaller();
            var unmarshaller = UpdateDomainContactPrivacyResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainContactPrivacyRequest,UpdateDomainContactPrivacyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainContactPrivacy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateDomainContactPrivacyResponse> UpdateDomainContactPrivacyAsync(UpdateDomainContactPrivacyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDomainContactPrivacyRequestMarshaller();
            var unmarshaller = UpdateDomainContactPrivacyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainContactPrivacyRequest,UpdateDomainContactPrivacyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainNameservers


        /// <summary>
        /// This operation replaces the current set of name servers for the domain with the specified
        /// set of name servers. If you use Amazon Route 53 as your DNS service, specify the four
        /// name servers in the delegation set for the hosted zone for the domain. 
        /// 
        ///  
        /// <para>
        /// If successful, this operation returns an operation ID that you can use to track the
        /// progress and completion of the action. If the request is not completed successfully,
        /// the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainNameservers service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainNameservers service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public UpdateDomainNameserversResponse UpdateDomainNameservers(UpdateDomainNameserversRequest request)
        {
            var marshaller = new UpdateDomainNameserversRequestMarshaller();
            var unmarshaller = UpdateDomainNameserversResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainNameserversRequest,UpdateDomainNameserversResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainNameservers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainNameservers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateDomainNameserversResponse> UpdateDomainNameserversAsync(UpdateDomainNameserversRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDomainNameserversRequestMarshaller();
            var unmarshaller = UpdateDomainNameserversResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainNameserversRequest,UpdateDomainNameserversResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTagsForDomain


        /// <summary>
        /// This operation adds or updates tags for a specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to add or update tags. The name of a domain. Type: String Default: None Constraints: The domain name can contain only the letters a through z, the numbers 0 through 9, and hyphen (-). Hyphens are allowed only when they&apos;re surrounded by letters, numbers, or other hyphens. You can&apos;t specify a hyphen at the beginning or end of a label. To specify an Internationalized Domain Name, you must convert the name to Punycode. Required: Yes</param>
        /// <param name="tagsToUpdate">A list of the tag keys and values that you want to add or update. If you specify a key that already exists, the corresponding value will be replaced. Type: A complex type containing a list of tags Default: None Required: No'> Each tag includes the following elements: <ul> <li>Key The key (name) of a tag. Type: String Default: None Valid values: Unicode characters including alphanumeric, space, and ".:/=+\-@" Constraints: Each key can be 1-128 characters long. Required: Yes </li> <li>Value The value of a tag. Type: String Default: None Valid values: Unicode characters including alphanumeric, space, and ".:/=+\-@" Constraints: Each value can be 0-256 characters long. Required: Yes </li> </ul></param>
        /// 
        /// <returns>The response from the UpdateTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public UpdateTagsForDomainResponse UpdateTagsForDomain(string domainName, List<Tag> tagsToUpdate)
        {
            var request = new UpdateTagsForDomainRequest();
            request.DomainName = domainName;
            request.TagsToUpdate = tagsToUpdate;
            return UpdateTagsForDomain(request);
        }


        /// <summary>
        /// This operation adds or updates tags for a specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public UpdateTagsForDomainResponse UpdateTagsForDomain(UpdateTagsForDomainRequest request)
        {
            var marshaller = new UpdateTagsForDomainRequestMarshaller();
            var unmarshaller = UpdateTagsForDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateTagsForDomainRequest,UpdateTagsForDomainResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// This operation adds or updates tags for a specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to add or update tags. The name of a domain. Type: String Default: None Constraints: The domain name can contain only the letters a through z, the numbers 0 through 9, and hyphen (-). Hyphens are allowed only when they&apos;re surrounded by letters, numbers, or other hyphens. You can&apos;t specify a hyphen at the beginning or end of a label. To specify an Internationalized Domain Name, you must convert the name to Punycode. Required: Yes</param>
        /// <param name="tagsToUpdate">A list of the tag keys and values that you want to add or update. If you specify a key that already exists, the corresponding value will be replaced. Type: A complex type containing a list of tags Default: None Required: No'> Each tag includes the following elements: <ul> <li>Key The key (name) of a tag. Type: String Default: None Valid values: Unicode characters including alphanumeric, space, and ".:/=+\-@" Constraints: Each key can be 1-128 characters long. Required: Yes </li> <li>Value The value of a tag. Type: String Default: None Valid values: Unicode characters including alphanumeric, space, and ".:/=+\-@" Constraints: Each value can be 0-256 characters long. Required: Yes </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        public Task<UpdateTagsForDomainResponse> UpdateTagsForDomainAsync(string domainName, List<Tag> tagsToUpdate, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateTagsForDomainRequest();
            request.DomainName = domainName;
            request.TagsToUpdate = tagsToUpdate;
            return UpdateTagsForDomainAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateTagsForDomainResponse> UpdateTagsForDomainAsync(UpdateTagsForDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateTagsForDomainRequestMarshaller();
            var unmarshaller = UpdateTagsForDomainResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTagsForDomainRequest,UpdateTagsForDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}