// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200501Preview.Inputs
{

    public sealed class DatasetCreateRequestDataPathArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The datastore name.
        /// </summary>
        [Input("datastoreName")]
        public Input<string>? DatastoreName { get; set; }

        /// <summary>
        /// Path within the datastore.
        /// </summary>
        [Input("relativePath")]
        public Input<string>? RelativePath { get; set; }

        public DatasetCreateRequestDataPathArgs()
        {
        }
    }
}
