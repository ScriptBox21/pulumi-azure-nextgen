// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20150801.Inputs
{

    /// <summary>
    /// Represents information needed for cloning operation
    /// </summary>
    public sealed class CloningInfoArgs : Pulumi.ResourceArgs
    {
        [Input("appSettingsOverrides")]
        private InputMap<string>? _appSettingsOverrides;

        /// <summary>
        /// Application settings overrides for cloned web app. If specified these settings will override the settings cloned 
        ///             from source web app. If not specified, application settings from source web app are retained.
        /// </summary>
        public InputMap<string> AppSettingsOverrides
        {
            get => _appSettingsOverrides ?? (_appSettingsOverrides = new InputMap<string>());
            set => _appSettingsOverrides = value;
        }

        /// <summary>
        /// If true, clone custom hostnames from source web app
        /// </summary>
        [Input("cloneCustomHostNames")]
        public Input<bool>? CloneCustomHostNames { get; set; }

        /// <summary>
        /// Clone source control from source web app
        /// </summary>
        [Input("cloneSourceControl")]
        public Input<bool>? CloneSourceControl { get; set; }

        /// <summary>
        /// If specified configure load balancing for source and clone site
        /// </summary>
        [Input("configureLoadBalancing")]
        public Input<bool>? ConfigureLoadBalancing { get; set; }

        /// <summary>
        /// Correlation Id of cloning operation. This id ties multiple cloning operations
        ///             together to use the same snapshot
        /// </summary>
        [Input("correlationId")]
        public Input<string>? CorrelationId { get; set; }

        /// <summary>
        /// Hosting environment
        /// </summary>
        [Input("hostingEnvironment")]
        public Input<string>? HostingEnvironment { get; set; }

        /// <summary>
        /// Overwrite destination web app
        /// </summary>
        [Input("overwrite")]
        public Input<bool>? Overwrite { get; set; }

        /// <summary>
        /// ARM resource id of the source web app. Web app resource id is of the form 
        ///             /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots and 
        ///             /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for other slots
        /// </summary>
        [Input("sourceWebAppId")]
        public Input<string>? SourceWebAppId { get; set; }

        /// <summary>
        /// ARM resource id of the traffic manager profile to use if it exists. Traffic manager resource id is of the form 
        ///             /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}
        /// </summary>
        [Input("trafficManagerProfileId")]
        public Input<string>? TrafficManagerProfileId { get; set; }

        /// <summary>
        /// Name of traffic manager profile to create. This is only needed if traffic manager profile does not already exist
        /// </summary>
        [Input("trafficManagerProfileName")]
        public Input<string>? TrafficManagerProfileName { get; set; }

        public CloningInfoArgs()
        {
        }
    }
}