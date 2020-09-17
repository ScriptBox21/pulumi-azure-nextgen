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
    /// A file in an HTTP web server.
    /// </summary>
    public sealed class HttpDatasetArgs : Pulumi.ResourceArgs
    {
        [Input("additionalHeaders")]
        private InputMap<object>? _additionalHeaders;

        /// <summary>
        /// The headers for the HTTP Request. e.g. request-header-name-1:request-header-value-1
        /// ...
        /// request-header-name-n:request-header-value-n Type: string (or Expression with resultType string).
        /// </summary>
        public InputMap<object> AdditionalHeaders
        {
            get => _additionalHeaders ?? (_additionalHeaders = new InputMap<object>());
            set => _additionalHeaders = value;
        }

        [Input("annotations")]
        private InputList<ImmutableDictionary<string, object>>? _annotations;

        /// <summary>
        /// List of tags that can be used for describing the Dataset.
        /// </summary>
        public InputList<ImmutableDictionary<string, object>> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<ImmutableDictionary<string, object>>());
            set => _annotations = value;
        }

        /// <summary>
        /// The data compression method used on files.
        /// </summary>
        [Input("compression")]
        public InputUnion<Inputs.DatasetBZip2CompressionArgs, InputUnion<Inputs.DatasetDeflateCompressionArgs, InputUnion<Inputs.DatasetGZipCompressionArgs, InputUnion<Inputs.DatasetTarCompressionArgs, InputUnion<Inputs.DatasetTarGZipCompressionArgs, Inputs.DatasetZipDeflateCompressionArgs>>>>>? Compression { get; set; }

        /// <summary>
        /// Dataset description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The folder that this Dataset is in. If not specified, Dataset will appear at the root level.
        /// </summary>
        [Input("folder")]
        public Input<Inputs.DatasetFolderArgs>? Folder { get; set; }

        /// <summary>
        /// The format of files.
        /// </summary>
        [Input("format")]
        public InputUnion<Inputs.AvroFormatArgs, InputUnion<Inputs.JsonFormatArgs, InputUnion<Inputs.OrcFormatArgs, InputUnion<Inputs.ParquetFormatArgs, Inputs.TextFormatArgs>>>>? Format { get; set; }

        /// <summary>
        /// Linked service reference.
        /// </summary>
        [Input("linkedServiceName", required: true)]
        public Input<Inputs.LinkedServiceReferenceArgs> LinkedServiceName { get; set; } = null!;

        [Input("parameters")]
        private InputMap<Inputs.ParameterSpecificationArgs>? _parameters;

        /// <summary>
        /// Parameters for dataset.
        /// </summary>
        public InputMap<Inputs.ParameterSpecificationArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<Inputs.ParameterSpecificationArgs>());
            set => _parameters = value;
        }

        [Input("relativeUrl")]
        private InputMap<object>? _relativeUrl;

        /// <summary>
        /// The relative URL based on the URL in the HttpLinkedService refers to an HTTP file Type: string (or Expression with resultType string).
        /// </summary>
        public InputMap<object> RelativeUrl
        {
            get => _relativeUrl ?? (_relativeUrl = new InputMap<object>());
            set => _relativeUrl = value;
        }

        [Input("requestBody")]
        private InputMap<object>? _requestBody;

        /// <summary>
        /// The body for the HTTP request. Type: string (or Expression with resultType string).
        /// </summary>
        public InputMap<object> RequestBody
        {
            get => _requestBody ?? (_requestBody = new InputMap<object>());
            set => _requestBody = value;
        }

        [Input("requestMethod")]
        private InputMap<object>? _requestMethod;

        /// <summary>
        /// The HTTP method for the HTTP request. Type: string (or Expression with resultType string).
        /// </summary>
        public InputMap<object> RequestMethod
        {
            get => _requestMethod ?? (_requestMethod = new InputMap<object>());
            set => _requestMethod = value;
        }

        [Input("schema")]
        private InputMap<object>? _schema;

        /// <summary>
        /// Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement.
        /// </summary>
        public InputMap<object> Schema
        {
            get => _schema ?? (_schema = new InputMap<object>());
            set => _schema = value;
        }

        [Input("structure")]
        private InputMap<object>? _structure;

        /// <summary>
        /// Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement.
        /// </summary>
        public InputMap<object> Structure
        {
            get => _structure ?? (_structure = new InputMap<object>());
            set => _structure = value;
        }

        /// <summary>
        /// Type of dataset.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public HttpDatasetArgs()
        {
        }
    }
}