// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.CustomerInsights.V20170426.Outputs
{

    [OutputType]
    public sealed class CanonicalProfileDefinitionResponseResult
    {
        /// <summary>
        /// Canonical profile ID.
        /// </summary>
        public readonly int? CanonicalProfileId;
        /// <summary>
        /// Properties of the canonical profile.
        /// </summary>
        public readonly ImmutableArray<Outputs.CanonicalProfileDefinitionResponsePropertiesResult> Properties;

        [OutputConstructor]
        private CanonicalProfileDefinitionResponseResult(
            int? canonicalProfileId,

            ImmutableArray<Outputs.CanonicalProfileDefinitionResponsePropertiesResult> properties)
        {
            CanonicalProfileId = canonicalProfileId;
            Properties = properties;
        }
    }
}
