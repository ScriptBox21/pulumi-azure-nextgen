// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Search.V20200801Preview.Outputs
{

    [OutputType]
    public sealed class PrivateEndpointConnectionResponse
    {
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Describes the properties of an existing Private Endpoint connection to the Azure Cognitive Search service.
        /// </summary>
        public readonly Outputs.PrivateEndpointConnectionPropertiesResponse? Properties;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private PrivateEndpointConnectionResponse(
            string id,

            string name,

            Outputs.PrivateEndpointConnectionPropertiesResponse? properties,

            string type)
        {
            Id = id;
            Name = name;
            Properties = properties;
            Type = type;
        }
    }
}
