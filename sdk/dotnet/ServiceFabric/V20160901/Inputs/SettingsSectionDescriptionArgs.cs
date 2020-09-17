// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceFabric.V20160901.Inputs
{

    /// <summary>
    /// ServiceFabric section settings
    /// </summary>
    public sealed class SettingsSectionDescriptionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of settings section
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("parameters", required: true)]
        private InputList<Inputs.SettingsParameterDescriptionArgs>? _parameters;

        /// <summary>
        /// Collection of settings in the section, each setting is a tuple consisting of setting name and value
        /// </summary>
        public InputList<Inputs.SettingsParameterDescriptionArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Inputs.SettingsParameterDescriptionArgs>());
            set => _parameters = value;
        }

        public SettingsSectionDescriptionArgs()
        {
        }
    }
}