// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DesktopVirtualization.V20190123Preview
{
    /// <summary>
    /// Schema for Application properties.
    /// </summary>
    public partial class Application : Pulumi.CustomResource
    {
        /// <summary>
        /// Command Line Arguments for Application.
        /// </summary>
        [Output("commandLineArguments")]
        public Output<string?> CommandLineArguments { get; private set; } = null!;

        /// <summary>
        /// Specifies whether this published application can be launched with command line arguments provided by the client, command line arguments specified at publish time, or no command line arguments at all.
        /// </summary>
        [Output("commandLineSetting")]
        public Output<string> CommandLineSetting { get; private set; } = null!;

        /// <summary>
        /// Description of Application.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Specifies a path for the executable file for the application.
        /// </summary>
        [Output("filePath")]
        public Output<string?> FilePath { get; private set; } = null!;

        /// <summary>
        /// Friendly name of Application.
        /// </summary>
        [Output("friendlyName")]
        public Output<string?> FriendlyName { get; private set; } = null!;

        /// <summary>
        /// the icon a 64 bit string as a byte array.
        /// </summary>
        [Output("iconContent")]
        public Output<string> IconContent { get; private set; } = null!;

        /// <summary>
        /// Hash of the icon.
        /// </summary>
        [Output("iconHash")]
        public Output<string> IconHash { get; private set; } = null!;

        /// <summary>
        /// Index of the icon.
        /// </summary>
        [Output("iconIndex")]
        public Output<int?> IconIndex { get; private set; } = null!;

        /// <summary>
        /// Path to icon.
        /// </summary>
        [Output("iconPath")]
        public Output<string?> IconPath { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Specifies whether to show the RemoteApp program in the RD Web Access server.
        /// </summary>
        [Output("showInPortal")]
        public Output<bool?> ShowInPortal { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Application resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Application(string name, ApplicationArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:desktopvirtualization/v20190123preview:Application", name, args ?? new ApplicationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Application(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:desktopvirtualization/v20190123preview:Application", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:desktopvirtualization/v20190924preview:Application"},
                    new Pulumi.Alias { Type = "azure-nextgen:desktopvirtualization/v20191210preview:Application"},
                    new Pulumi.Alias { Type = "azure-nextgen:desktopvirtualization/v20200921preview:Application"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Application resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Application Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Application(name, id, options);
        }
    }

    public sealed class ApplicationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the application group
        /// </summary>
        [Input("applicationGroupName", required: true)]
        public Input<string> ApplicationGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the application within the specified application group
        /// </summary>
        [Input("applicationName", required: true)]
        public Input<string> ApplicationName { get; set; } = null!;

        /// <summary>
        /// Command Line Arguments for Application.
        /// </summary>
        [Input("commandLineArguments")]
        public Input<string>? CommandLineArguments { get; set; }

        /// <summary>
        /// Specifies whether this published application can be launched with command line arguments provided by the client, command line arguments specified at publish time, or no command line arguments at all.
        /// </summary>
        [Input("commandLineSetting", required: true)]
        public Input<string> CommandLineSetting { get; set; } = null!;

        /// <summary>
        /// Description of Application.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Specifies a path for the executable file for the application.
        /// </summary>
        [Input("filePath")]
        public Input<string>? FilePath { get; set; }

        /// <summary>
        /// Friendly name of Application.
        /// </summary>
        [Input("friendlyName")]
        public Input<string>? FriendlyName { get; set; }

        /// <summary>
        /// Index of the icon.
        /// </summary>
        [Input("iconIndex")]
        public Input<int>? IconIndex { get; set; }

        /// <summary>
        /// Path to icon.
        /// </summary>
        [Input("iconPath")]
        public Input<string>? IconPath { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Specifies whether to show the RemoteApp program in the RD Web Access server.
        /// </summary>
        [Input("showInPortal")]
        public Input<bool>? ShowInPortal { get; set; }

        public ApplicationArgs()
        {
        }
    }
}
