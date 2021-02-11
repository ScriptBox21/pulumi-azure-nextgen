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
    /// Details of customized scripts to execute for setting up the cluster.
    /// </summary>
    public sealed class SetupScriptsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Customized setup scripts
        /// </summary>
        [Input("scripts")]
        public Input<Inputs.ScriptsToExecuteArgs>? Scripts { get; set; }

        public SetupScriptsArgs()
        {
        }
    }
}
