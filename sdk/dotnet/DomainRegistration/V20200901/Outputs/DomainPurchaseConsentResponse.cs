// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DomainRegistration.V20200901.Outputs
{

    [OutputType]
    public sealed class DomainPurchaseConsentResponse
    {
        /// <summary>
        /// Timestamp when the agreements were accepted.
        /// </summary>
        public readonly string? AgreedAt;
        /// <summary>
        /// Client IP address.
        /// </summary>
        public readonly string? AgreedBy;
        /// <summary>
        /// List of applicable legal agreement keys. This list can be retrieved using ListLegalAgreements API under &lt;code&gt;TopLevelDomain&lt;/code&gt; resource.
        /// </summary>
        public readonly ImmutableArray<string> AgreementKeys;

        [OutputConstructor]
        private DomainPurchaseConsentResponse(
            string? agreedAt,

            string? agreedBy,

            ImmutableArray<string> agreementKeys)
        {
            AgreedAt = agreedAt;
            AgreedBy = agreedBy;
            AgreementKeys = agreementKeys;
        }
    }
}
