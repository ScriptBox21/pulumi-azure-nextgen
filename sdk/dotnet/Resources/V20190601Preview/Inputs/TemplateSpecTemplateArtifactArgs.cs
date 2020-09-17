// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Resources.V20190601Preview.Inputs
{

    /// <summary>
    /// Represents a Template Spec artifact containing an embedded Azure Resource Manager template.
    /// </summary>
    public sealed class TemplateSpecTemplateArtifactArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The kind of artifact.
        /// </summary>
        [Input("kind", required: true)]
        public Input<string> Kind { get; set; } = null!;

        /// <summary>
        /// A filesystem safe relative path of the artifact.
        /// </summary>
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        [Input("template", required: true)]
        private InputMap<object>? _template;

        /// <summary>
        /// The Azure Resource Manager template.
        /// </summary>
        public InputMap<object> Template
        {
            get => _template ?? (_template = new InputMap<object>());
            set => _template = value;
        }

        public TemplateSpecTemplateArtifactArgs()
        {
        }
    }
}