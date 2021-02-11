// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20210101.Inputs
{

    /// <summary>
    /// The ssl configuration for scoring
    /// </summary>
    public sealed class SslConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cert data
        /// </summary>
        [Input("cert")]
        public Input<string>? Cert { get; set; }

        /// <summary>
        /// CNAME of the cert
        /// </summary>
        [Input("cname")]
        public Input<string>? Cname { get; set; }

        /// <summary>
        /// Key data
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// Enable or disable ssl for scoring
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public SslConfigurationArgs()
        {
        }
    }
}
