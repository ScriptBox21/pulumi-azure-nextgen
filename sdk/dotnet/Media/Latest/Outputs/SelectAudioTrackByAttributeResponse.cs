// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.Latest.Outputs
{

    [OutputType]
    public sealed class SelectAudioTrackByAttributeResponse
    {
        /// <summary>
        /// The TrackAttribute to filter the tracks by.
        /// </summary>
        public readonly string Attribute;
        /// <summary>
        /// Optional designation for single channel audio tracks.  Can be used to combine the tracks into stereo or multi-channel audio tracks.
        /// </summary>
        public readonly string? ChannelMapping;
        /// <summary>
        /// The type of AttributeFilter to apply to the TrackAttribute in order to select the tracks.
        /// </summary>
        public readonly string Filter;
        /// <summary>
        /// The value to filter the tracks by.  Only used when AttributeFilter.ValueEquals is specified for the Filter property.
        /// </summary>
        public readonly string? FilterValue;
        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.AudioTrackDescriptor'.
        /// </summary>
        public readonly string OdataType;

        [OutputConstructor]
        private SelectAudioTrackByAttributeResponse(
            string attribute,

            string? channelMapping,

            string filter,

            string? filterValue,

            string odataType)
        {
            Attribute = attribute;
            ChannelMapping = channelMapping;
            Filter = filter;
            FilterValue = filterValue;
            OdataType = odataType;
        }
    }
}
