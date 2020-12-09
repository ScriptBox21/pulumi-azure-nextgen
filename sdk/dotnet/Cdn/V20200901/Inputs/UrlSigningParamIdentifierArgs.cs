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
    /// Defines how to identify a parameter for a specific purpose e.g. expires
    /// </summary>
    public sealed class UrlSigningParamIdentifierArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates the purpose of the parameter
        /// </summary>
        [Input("paramIndicator", required: true)]
        public Input<string> ParamIndicator { get; set; } = null!;

        /// <summary>
        /// Parameter name
        /// </summary>
        [Input("paramName", required: true)]
        public Input<string> ParamName { get; set; } = null!;

        public UrlSigningParamIdentifierArgs()
        {
        }
    }
}
