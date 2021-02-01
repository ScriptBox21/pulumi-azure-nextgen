// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200601.Inputs
{

    public sealed class TwitterRegistrationArgs : Pulumi.ResourceArgs
    {
        [Input("consumerKey")]
        public Input<string>? ConsumerKey { get; set; }

        [Input("consumerSecretSettingName")]
        public Input<string>? ConsumerSecretSettingName { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        public TwitterRegistrationArgs()
        {
        }
    }
}
