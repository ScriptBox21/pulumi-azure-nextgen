// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NotificationHubs.V20160301.Inputs
{

    /// <summary>
    /// Description of a NotificationHub GcmCredential.
    /// </summary>
    public sealed class GcmCredentialArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The GCM endpoint.
        /// </summary>
        [Input("gcmEndpoint")]
        public Input<string>? GcmEndpoint { get; set; }

        /// <summary>
        /// The Google API key.
        /// </summary>
        [Input("googleApiKey")]
        public Input<string>? GoogleApiKey { get; set; }

        public GcmCredentialArgs()
        {
        }
    }
}