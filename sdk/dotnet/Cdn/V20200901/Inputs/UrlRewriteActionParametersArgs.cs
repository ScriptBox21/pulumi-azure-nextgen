// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20200901.Inputs
{

    /// <summary>
    /// Defines the parameters for the url rewrite action.
    /// </summary>
    public sealed class UrlRewriteActionParametersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Define the relative URL to which the above requests will be rewritten by.
        /// </summary>
        [Input("destination", required: true)]
        public Input<string> Destination { get; set; } = null!;

        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        /// <summary>
        /// Whether to preserve unmatched path. Default value is true.
        /// </summary>
        [Input("preserveUnmatchedPath")]
        public Input<bool>? PreserveUnmatchedPath { get; set; }

        /// <summary>
        /// define a request URI pattern that identifies the type of requests that may be rewritten. If value is blank, all strings are matched.
        /// </summary>
        [Input("sourcePattern", required: true)]
        public Input<string> SourcePattern { get; set; } = null!;

        public UrlRewriteActionParametersArgs()
        {
        }
    }
}
