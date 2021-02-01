// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200601.Inputs
{

    public sealed class CookieExpirationArgs : Pulumi.ResourceArgs
    {
        [Input("convention")]
        public Input<Pulumi.AzureNextGen.Web.V20200601.CookieExpirationConvention>? Convention { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("timeToExpiration")]
        public Input<string>? TimeToExpiration { get; set; }

        public CookieExpirationArgs()
        {
        }
    }
}
