// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200101.Outputs
{

    [OutputType]
    public sealed class RulesEngineResponse
    {
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Resource status.
        /// </summary>
        public readonly string ResourceState;
        /// <summary>
        /// A list of rules that define a particular Rules Engine Configuration.
        /// </summary>
        public readonly ImmutableArray<Outputs.RulesEngineRuleResponse> Rules;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private RulesEngineResponse(
            string id,

            string name,

            string resourceState,

            ImmutableArray<Outputs.RulesEngineRuleResponse> rules,

            string type)
        {
            Id = id;
            Name = name;
            ResourceState = resourceState;
            Rules = rules;
            Type = type;
        }
    }
}
