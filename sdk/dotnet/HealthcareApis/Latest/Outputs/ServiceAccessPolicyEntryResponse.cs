// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HealthcareApis.Latest.Outputs
{

    [OutputType]
    public sealed class ServiceAccessPolicyEntryResponse
    {
        /// <summary>
        /// An Azure AD object ID (User or Apps) that is allowed access to the FHIR service.
        /// </summary>
        public readonly string ObjectId;

        [OutputConstructor]
        private ServiceAccessPolicyEntryResponse(string objectId)
        {
            ObjectId = objectId;
        }
    }
}