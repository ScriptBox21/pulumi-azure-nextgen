// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20200901.Outputs
{

    [OutputType]
    public sealed class OriginGroupOverrideActionParametersResponse
    {
        public readonly string OdataType;
        /// <summary>
        /// defines the OriginGroup that would override the DefaultOriginGroup.
        /// </summary>
        public readonly Outputs.ResourceReferenceResponse OriginGroup;

        [OutputConstructor]
        private OriginGroupOverrideActionParametersResponse(
            string odataType,

            Outputs.ResourceReferenceResponse originGroup)
        {
            OdataType = odataType;
            OriginGroup = originGroup;
        }
    }
}
