// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200501Preview.Inputs
{

    public sealed class DatasetCreateRequestQueryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The SQL/PostgreSQL/MySQL datastore name.
        /// </summary>
        [Input("datastoreName")]
        public Input<string>? DatastoreName { get; set; }

        /// <summary>
        /// SQL Quey.
        /// </summary>
        [Input("query")]
        public Input<string>? Query { get; set; }

        public DatasetCreateRequestQueryArgs()
        {
        }
    }
}
