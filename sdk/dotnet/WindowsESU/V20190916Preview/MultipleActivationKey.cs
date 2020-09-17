// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.WindowsESU.V20190916Preview
{
    /// <summary>
    /// MAK key details.
    /// </summary>
    public partial class MultipleActivationKey : Pulumi.CustomResource
    {
        /// <summary>
        /// Agreement number under which the key is requested.
        /// </summary>
        [Output("agreementNumber")]
        public Output<string?> AgreementNumber { get; private set; } = null!;

        /// <summary>
        /// End of support of security updates activated by the MAK key.
        /// </summary>
        [Output("expirationDate")]
        public Output<string> ExpirationDate { get; private set; } = null!;

        /// <summary>
        /// Number of activations/servers using the MAK key.
        /// </summary>
        [Output("installedServerNumber")]
        public Output<int?> InstalledServerNumber { get; private set; } = null!;

        /// <summary>
        /// &lt;code&gt; true &lt;/code&gt; if user has eligible on-premises Windows physical or virtual machines, and that the requested key will only be used in their organization; &lt;code&gt; false &lt;/code&gt; otherwise.
        /// </summary>
        [Output("isEligible")]
        public Output<bool?> IsEligible { get; private set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// MAK 5x5 key.
        /// </summary>
        [Output("multipleActivationKey")]
        public Output<string> MultipleActivationKeyValue { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Type of OS for which the key is requested.
        /// </summary>
        [Output("osType")]
        public Output<string?> OsType { get; private set; } = null!;

        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Type of support
        /// </summary>
        [Output("supportType")]
        public Output<string?> SupportType { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a MultipleActivationKey resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MultipleActivationKey(string name, MultipleActivationKeyArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:windowsesu/v20190916preview:MultipleActivationKey", name, args ?? new MultipleActivationKeyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MultipleActivationKey(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:windowsesu/v20190916preview:MultipleActivationKey", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing MultipleActivationKey resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MultipleActivationKey Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new MultipleActivationKey(name, id, options);
        }
    }

    public sealed class MultipleActivationKeyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Agreement number under which the key is requested.
        /// </summary>
        [Input("agreementNumber")]
        public Input<string>? AgreementNumber { get; set; }

        /// <summary>
        /// Number of activations/servers using the MAK key.
        /// </summary>
        [Input("installedServerNumber")]
        public Input<int>? InstalledServerNumber { get; set; }

        /// <summary>
        /// &lt;code&gt; true &lt;/code&gt; if user has eligible on-premises Windows physical or virtual machines, and that the requested key will only be used in their organization; &lt;code&gt; false &lt;/code&gt; otherwise.
        /// </summary>
        [Input("isEligible")]
        public Input<bool>? IsEligible { get; set; }

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The name of the MAK key.
        /// </summary>
        [Input("multipleActivationKeyName", required: true)]
        public Input<string> MultipleActivationKeyName { get; set; } = null!;

        /// <summary>
        /// Type of OS for which the key is requested.
        /// </summary>
        [Input("osType")]
        public Input<string>? OsType { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Type of support
        /// </summary>
        [Input("supportType")]
        public Input<string>? SupportType { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public MultipleActivationKeyArgs()
        {
        }
    }
}