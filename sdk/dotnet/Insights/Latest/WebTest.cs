// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Insights.Latest
{
    /// <summary>
    /// An Application Insights web test definition.
    /// </summary>
    public partial class WebTest : Pulumi.CustomResource
    {
        /// <summary>
        /// An XML configuration specification for a WebTest.
        /// </summary>
        [Output("configuration")]
        public Output<Outputs.WebTestPropertiesResponseConfiguration?> Configuration { get; private set; } = null!;

        /// <summary>
        /// Purpose/user defined descriptive test for this WebTest.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Is the test actively being monitored.
        /// </summary>
        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        /// <summary>
        /// Interval in seconds between test runs for this WebTest. Default value is 300.
        /// </summary>
        [Output("frequency")]
        public Output<int?> Frequency { get; private set; } = null!;

        /// <summary>
        /// The kind of web test that this web test watches. Choices are ping and multistep.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// A list of where to physically run the tests from to give global coverage for accessibility of your application.
        /// </summary>
        [Output("locations")]
        public Output<ImmutableArray<Outputs.WebTestGeolocationResponse>> Locations { get; private set; } = null!;

        /// <summary>
        /// Azure resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Current state of this component, whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Allow for retries should this WebTest fail.
        /// </summary>
        [Output("retryEnabled")]
        public Output<bool?> RetryEnabled { get; private set; } = null!;

        /// <summary>
        /// Unique ID of this WebTest. This is typically the same value as the Name field.
        /// </summary>
        [Output("syntheticMonitorId")]
        public Output<string> SyntheticMonitorId { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Seconds until this WebTest will timeout and fail. Default value is 30.
        /// </summary>
        [Output("timeout")]
        public Output<int?> Timeout { get; private set; } = null!;

        /// <summary>
        /// Azure resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The kind of web test this is, valid choices are ping and multistep.
        /// </summary>
        [Output("webTestKind")]
        public Output<string> WebTestKind { get; private set; } = null!;

        /// <summary>
        /// User defined name if this WebTest.
        /// </summary>
        [Output("webTestName")]
        public Output<string> WebTestName { get; private set; } = null!;


        /// <summary>
        /// Create a WebTest resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebTest(string name, WebTestArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:insights/latest:WebTest", name, args ?? new WebTestArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebTest(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:insights/latest:WebTest", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:insights/v20150501:WebTest"},
                    new Pulumi.Alias { Type = "azure-nextgen:insights/v20201005preview:WebTest"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebTest resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebTest Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebTest(name, id, options);
        }
    }

    public sealed class WebTestArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// An XML configuration specification for a WebTest.
        /// </summary>
        [Input("configuration")]
        public Input<Inputs.WebTestPropertiesConfigurationArgs>? Configuration { get; set; }

        /// <summary>
        /// Purpose/user defined descriptive test for this WebTest.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Is the test actively being monitored.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Interval in seconds between test runs for this WebTest. Default value is 300.
        /// </summary>
        [Input("frequency")]
        public Input<int>? Frequency { get; set; }

        /// <summary>
        /// The kind of web test that this web test watches. Choices are ping and multistep.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("locations", required: true)]
        private InputList<Inputs.WebTestGeolocationArgs>? _locations;

        /// <summary>
        /// A list of where to physically run the tests from to give global coverage for accessibility of your application.
        /// </summary>
        public InputList<Inputs.WebTestGeolocationArgs> Locations
        {
            get => _locations ?? (_locations = new InputList<Inputs.WebTestGeolocationArgs>());
            set => _locations = value;
        }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Allow for retries should this WebTest fail.
        /// </summary>
        [Input("retryEnabled")]
        public Input<bool>? RetryEnabled { get; set; }

        /// <summary>
        /// Unique ID of this WebTest. This is typically the same value as the Name field.
        /// </summary>
        [Input("syntheticMonitorId", required: true)]
        public Input<string> SyntheticMonitorId { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Seconds until this WebTest will timeout and fail. Default value is 30.
        /// </summary>
        [Input("timeout")]
        public Input<int>? Timeout { get; set; }

        /// <summary>
        /// The kind of web test this is, valid choices are ping and multistep.
        /// </summary>
        [Input("webTestKind", required: true)]
        public Input<string> WebTestKind { get; set; } = null!;

        /// <summary>
        /// User defined name if this WebTest.
        /// </summary>
        [Input("webTestName", required: true)]
        public Input<string> WebTestName { get; set; } = null!;

        public WebTestArgs()
        {
        }
    }
}
