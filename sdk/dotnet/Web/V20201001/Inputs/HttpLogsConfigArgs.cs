// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20201001.Inputs
{

    /// <summary>
    /// Http logs configuration.
    /// </summary>
    public sealed class HttpLogsConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Http logs to azure blob storage configuration.
        /// </summary>
        [Input("azureBlobStorage")]
        public Input<Inputs.AzureBlobStorageHttpLogsConfigArgs>? AzureBlobStorage { get; set; }

        /// <summary>
        /// Http logs to file system configuration.
        /// </summary>
        [Input("fileSystem")]
        public Input<Inputs.FileSystemHttpLogsConfigArgs>? FileSystem { get; set; }

        public HttpLogsConfigArgs()
        {
        }
    }
}
