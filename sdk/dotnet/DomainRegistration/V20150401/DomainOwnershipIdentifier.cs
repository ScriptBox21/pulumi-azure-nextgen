// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DomainRegistration.V20150401
{
    /// <summary>
    /// Domain ownership Identifier.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:domainregistration/v20150401:DomainOwnershipIdentifier")]
    public partial class DomainOwnershipIdentifier : Pulumi.CustomResource
    {
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
        /// Ownership Id.
        /// </summary>
        [Output("ownershipId")]
        public Output<string?> OwnershipId { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a DomainOwnershipIdentifier resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DomainOwnershipIdentifier(string name, DomainOwnershipIdentifierArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:domainregistration/v20150401:DomainOwnershipIdentifier", name, args ?? new DomainOwnershipIdentifierArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DomainOwnershipIdentifier(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:domainregistration/v20150401:DomainOwnershipIdentifier", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:domainregistration/latest:DomainOwnershipIdentifier"},
                    new Pulumi.Alias { Type = "azure-nextgen:domainregistration/v20180201:DomainOwnershipIdentifier"},
                    new Pulumi.Alias { Type = "azure-nextgen:domainregistration/v20190801:DomainOwnershipIdentifier"},
                    new Pulumi.Alias { Type = "azure-nextgen:domainregistration/v20200601:DomainOwnershipIdentifier"},
                    new Pulumi.Alias { Type = "azure-nextgen:domainregistration/v20200901:DomainOwnershipIdentifier"},
                    new Pulumi.Alias { Type = "azure-nextgen:domainregistration/v20201001:DomainOwnershipIdentifier"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DomainOwnershipIdentifier resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DomainOwnershipIdentifier Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new DomainOwnershipIdentifier(name, id, options);
        }
    }

    public sealed class DomainOwnershipIdentifierArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of domain.
        /// </summary>
        [Input("domainName", required: true)]
        public Input<string> DomainName { get; set; } = null!;

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Name of identifier.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Ownership Id.
        /// </summary>
        [Input("ownershipId")]
        public Input<string>? OwnershipId { get; set; }

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public DomainOwnershipIdentifierArgs()
        {
        }
    }
}
