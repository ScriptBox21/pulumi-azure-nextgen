// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Inputs
{

    /// <summary>
    /// The data stored in Optimized Row Columnar (ORC) format.
    /// </summary>
    public sealed class OrcFormatArgs : Pulumi.ResourceArgs
    {
        [Input("deserializer")]
        private InputMap<object>? _deserializer;

        /// <summary>
        /// Deserializer. Type: string (or Expression with resultType string).
        /// </summary>
        public InputMap<object> Deserializer
        {
            get => _deserializer ?? (_deserializer = new InputMap<object>());
            set => _deserializer = value;
        }

        [Input("serializer")]
        private InputMap<object>? _serializer;

        /// <summary>
        /// Serializer. Type: string (or Expression with resultType string).
        /// </summary>
        public InputMap<object> Serializer
        {
            get => _serializer ?? (_serializer = new InputMap<object>());
            set => _serializer = value;
        }

        /// <summary>
        /// Type of dataset storage format.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public OrcFormatArgs()
        {
        }
    }
}