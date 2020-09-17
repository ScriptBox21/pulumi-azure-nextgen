// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NotificationHubs.V20140901.Inputs
{

    /// <summary>
    /// Namespace properties.
    /// </summary>
    public sealed class NamespacePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The time the namespace was created.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// Whether or not the namespace is set as Critical.
        /// </summary>
        [Input("critical")]
        public Input<bool>? Critical { get; set; }

        /// <summary>
        /// Whether or not the namespace is currently enabled.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Gets or sets the namespace type.
        /// </summary>
        [Input("namespaceType")]
        public Input<string>? NamespaceType { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the Namespace.
        /// </summary>
        [Input("provisioningState")]
        public Input<string>? ProvisioningState { get; set; }

        /// <summary>
        /// Specifies the targeted region in which the namespace should be created. It can be any of the following values: Australia East, Australia Southeast, Central US, East US, East US 2, West US, North Central US, South Central US, East Asia, Southeast Asia, Brazil South, Japan East, Japan West, North Europe, West Europe
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// ScaleUnit where the namespace gets created
        /// </summary>
        [Input("scaleUnit")]
        public Input<string>? ScaleUnit { get; set; }

        /// <summary>
        /// Endpoint you can use to perform NotificationHub operations.
        /// </summary>
        [Input("serviceBusEndpoint")]
        public Input<string>? ServiceBusEndpoint { get; set; }

        /// <summary>
        /// Status of the namespace. It can be any of these values:1 = Created/Active2 = Creating3 = Suspended4 = Deleting
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// The Id of the Azure subscription associated with the namespace.
        /// </summary>
        [Input("subscriptionId")]
        public Input<string>? SubscriptionId { get; set; }

        public NamespacePropertiesArgs()
        {
        }
    }
}