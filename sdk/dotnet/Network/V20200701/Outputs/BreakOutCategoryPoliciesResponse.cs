// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200701.Outputs
{

    [OutputType]
    public sealed class BreakOutCategoryPoliciesResponse
    {
        /// <summary>
        /// Flag to control breakout of o365 allow category.
        /// </summary>
        public readonly bool? Allow;
        /// <summary>
        /// Flag to control breakout of o365 default category.
        /// </summary>
        public readonly bool? Default;
        /// <summary>
        /// Flag to control breakout of o365 optimize category.
        /// </summary>
        public readonly bool? Optimize;

        [OutputConstructor]
        private BreakOutCategoryPoliciesResponse(
            bool? allow,

            bool? @default,

            bool? optimize)
        {
            Allow = allow;
            Default = @default;
            Optimize = optimize;
        }
    }
}