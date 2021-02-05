// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NetApp.V20190601
{
    /// <summary>
    /// NetApp account resource
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:netapp/v20190601:Account")]
    public partial class Account : Pulumi.CustomResource
    {
        /// <summary>
        /// Active Directories
        /// </summary>
        [Output("activeDirectories")]
        public Output<ImmutableArray<Outputs.ActiveDirectoryResponse>> ActiveDirectories { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Azure lifecycle management
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<object?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Account resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Account(string name, AccountArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:netapp/v20190601:Account", name, args ?? new AccountArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Account(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:netapp/v20190601:Account", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/latest:Account"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20170815:Account"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20190501:Account"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20190701:Account"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20190801:Account"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20191001:Account"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20191101:Account"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200201:Account"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200301:Account"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200501:Account"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200601:Account"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200701:Account"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200801:Account"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200901:Account"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20201101:Account"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Account resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Account Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Account(name, id, options);
        }
    }

    public sealed class AccountArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the NetApp account
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        [Input("activeDirectories")]
        private InputList<Inputs.ActiveDirectoryArgs>? _activeDirectories;

        /// <summary>
        /// Active Directories
        /// </summary>
        public InputList<Inputs.ActiveDirectoryArgs> ActiveDirectories
        {
            get => _activeDirectories ?? (_activeDirectories = new InputList<Inputs.ActiveDirectoryArgs>());
            set => _activeDirectories = value;
        }

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Input("tags")]
        public Input<object>? Tags { get; set; }

        public AccountArgs()
        {
        }
    }
}
