// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901.Inputs
{

    public sealed class IdentityProvidersArgs : Pulumi.ResourceArgs
    {
        [Input("azureActiveDirectory")]
        public Input<Inputs.AzureActiveDirectoryArgs>? AzureActiveDirectory { get; set; }

        [Input("customOpenIdConnectProviders")]
        private InputMap<Inputs.CustomOpenIdConnectProviderArgs>? _customOpenIdConnectProviders;
        public InputMap<Inputs.CustomOpenIdConnectProviderArgs> CustomOpenIdConnectProviders
        {
            get => _customOpenIdConnectProviders ?? (_customOpenIdConnectProviders = new InputMap<Inputs.CustomOpenIdConnectProviderArgs>());
            set => _customOpenIdConnectProviders = value;
        }

        [Input("facebook")]
        public Input<Inputs.FacebookArgs>? Facebook { get; set; }

        [Input("gitHub")]
        public Input<Inputs.GitHubArgs>? GitHub { get; set; }

        [Input("google")]
        public Input<Inputs.GoogleArgs>? Google { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("twitter")]
        public Input<Inputs.TwitterArgs>? Twitter { get; set; }

        public IdentityProvidersArgs()
        {
        }
    }
}
