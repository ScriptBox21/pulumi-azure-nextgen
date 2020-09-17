// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.SignalRService.V20200701Preview.Inputs
{

    /// <summary>
    /// Upstream auth settings.
    /// </summary>
    public sealed class UpstreamAuthSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gets or sets the managed identity settings. It's required if the auth type is set to ManagedIdentity.
        /// </summary>
        [Input("managedIdentity")]
        public Input<Inputs.ManagedIdentitySettingsArgs>? ManagedIdentity { get; set; }

        /// <summary>
        /// Gets or sets the type of auth. None or ManagedIdentity is supported now.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public UpstreamAuthSettingsArgs()
        {
        }
    }
}