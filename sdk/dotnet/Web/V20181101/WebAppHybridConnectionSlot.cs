// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20181101
{
    /// <summary>
    /// Hybrid Connection contract. This is used to configure a Hybrid Connection.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/v20181101:WebAppHybridConnectionSlot")]
    public partial class WebAppHybridConnectionSlot : Pulumi.CustomResource
    {
        /// <summary>
        /// The hostname of the endpoint.
        /// </summary>
        [Output("hostname")]
        public Output<string?> Hostname { get; private set; } = null!;

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource Name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The port of the endpoint.
        /// </summary>
        [Output("port")]
        public Output<int?> Port { get; private set; } = null!;

        /// <summary>
        /// The ARM URI to the Service Bus relay.
        /// </summary>
        [Output("relayArmUri")]
        public Output<string?> RelayArmUri { get; private set; } = null!;

        /// <summary>
        /// The name of the Service Bus relay.
        /// </summary>
        [Output("relayName")]
        public Output<string?> RelayName { get; private set; } = null!;

        /// <summary>
        /// The name of the Service Bus key which has Send permissions. This is used to authenticate to Service Bus.
        /// </summary>
        [Output("sendKeyName")]
        public Output<string?> SendKeyName { get; private set; } = null!;

        /// <summary>
        /// The value of the Service Bus key. This is used to authenticate to Service Bus. In ARM this key will not be returned
        /// normally, use the POST /listKeys API instead.
        /// </summary>
        [Output("sendKeyValue")]
        public Output<string?> SendKeyValue { get; private set; } = null!;

        /// <summary>
        /// The name of the Service Bus namespace.
        /// </summary>
        [Output("serviceBusNamespace")]
        public Output<string?> ServiceBusNamespace { get; private set; } = null!;

        /// <summary>
        /// The suffix for the service bus endpoint. By default this is .servicebus.windows.net
        /// </summary>
        [Output("serviceBusSuffix")]
        public Output<string?> ServiceBusSuffix { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a WebAppHybridConnectionSlot resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppHybridConnectionSlot(string name, WebAppHybridConnectionSlotArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20181101:WebAppHybridConnectionSlot", name, args ?? new WebAppHybridConnectionSlotArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppHybridConnectionSlot(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20181101:WebAppHybridConnectionSlot", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:WebAppHybridConnectionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160801:WebAppHybridConnectionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:WebAppHybridConnectionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:WebAppHybridConnectionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:WebAppHybridConnectionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:WebAppHybridConnectionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20201001:WebAppHybridConnectionSlot"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppHybridConnectionSlot resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppHybridConnectionSlot Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebAppHybridConnectionSlot(name, id, options);
        }
    }

    public sealed class WebAppHybridConnectionSlotArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The hostname of the endpoint.
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// The name of the web app.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The namespace for this hybrid connection.
        /// </summary>
        [Input("namespaceName", required: true)]
        public Input<string> NamespaceName { get; set; } = null!;

        /// <summary>
        /// The port of the endpoint.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// The ARM URI to the Service Bus relay.
        /// </summary>
        [Input("relayArmUri")]
        public Input<string>? RelayArmUri { get; set; }

        /// <summary>
        /// The name of the Service Bus relay.
        /// </summary>
        [Input("relayName", required: true)]
        public Input<string> RelayName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Service Bus key which has Send permissions. This is used to authenticate to Service Bus.
        /// </summary>
        [Input("sendKeyName")]
        public Input<string>? SendKeyName { get; set; }

        /// <summary>
        /// The value of the Service Bus key. This is used to authenticate to Service Bus. In ARM this key will not be returned
        /// normally, use the POST /listKeys API instead.
        /// </summary>
        [Input("sendKeyValue")]
        public Input<string>? SendKeyValue { get; set; }

        /// <summary>
        /// The name of the Service Bus namespace.
        /// </summary>
        [Input("serviceBusNamespace")]
        public Input<string>? ServiceBusNamespace { get; set; }

        /// <summary>
        /// The suffix for the service bus endpoint. By default this is .servicebus.windows.net
        /// </summary>
        [Input("serviceBusSuffix")]
        public Input<string>? ServiceBusSuffix { get; set; }

        /// <summary>
        /// The name of the slot for the web app.
        /// </summary>
        [Input("slot", required: true)]
        public Input<string> Slot { get; set; } = null!;

        public WebAppHybridConnectionSlotArgs()
        {
        }
    }
}
