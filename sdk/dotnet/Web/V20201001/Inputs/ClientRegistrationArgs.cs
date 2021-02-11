// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20201001.Inputs
{

    public sealed class ClientRegistrationArgs : Pulumi.ResourceArgs
    {
        [Input("clientId")]
        public Input<string>? ClientId { get; set; }

        [Input("clientSecretSettingName")]
        public Input<string>? ClientSecretSettingName { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        public ClientRegistrationArgs()
        {
        }
    }
}
