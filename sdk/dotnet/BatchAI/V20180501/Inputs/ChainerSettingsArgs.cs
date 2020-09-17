// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.BatchAI.V20180501.Inputs
{

    /// <summary>
    /// Chainer job settings.
    /// </summary>
    public sealed class ChainerSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Command line arguments that need to be passed to the python script.
        /// </summary>
        [Input("commandLineArgs")]
        public Input<string>? CommandLineArgs { get; set; }

        /// <summary>
        /// Number of processes to launch for the job execution. The default value for this property is equal to nodeCount property
        /// </summary>
        [Input("processCount")]
        public Input<int>? ProcessCount { get; set; }

        /// <summary>
        /// The path to the Python interpreter.
        /// </summary>
        [Input("pythonInterpreterPath")]
        public Input<string>? PythonInterpreterPath { get; set; }

        /// <summary>
        /// The python script to execute.
        /// </summary>
        [Input("pythonScriptFilePath", required: true)]
        public Input<string> PythonScriptFilePath { get; set; } = null!;

        public ChainerSettingsArgs()
        {
        }
    }
}